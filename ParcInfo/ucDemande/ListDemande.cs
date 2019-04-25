﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.Classes;
using ParcInfo.ucInterevntion;
using ParcInfo.ucDemande;

namespace ParcInfo.ucClient
{
    public partial class ListDemande : UserControl
    {


        public string LblText
        {
            get { return lblEmployeClient.Text; }
            set { lblEmployeClient.Text = value; }
        }
        public bool lblVisible
        {
            get { return lblEmployeClient.Visible; }
            set { lblEmployeClient.Visible = value; }
        }

        public ListDemande(int idClient, string nom)
        {
            InitializeComponent();
            using (var db = new ParcInformatiqueEntities())
            {
                //  var res = db.Demandes.Where(x => x.Employee.Client.id == idClient).ToList();
                lblEmployeClient.ForeColor = Color.FromArgb(0, 168, 255);
                lblEmployeClient.Visible = true;
                lblEmployeClient.Text = $"[{nom}]";
                dgDemande.DataSource = (from d in db.GetRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest })
                                        select new
                                        {
                                            d.Id,
                                            d.IdReq,
                                            d.Employee.Nom,
                                            
                                            Desc = Methods.GetDesc(d.Description_d, 4),
                                            d.Datedemande,
                                            d.Getstatut,
                                            IdClient = d.Employee.Client.id
                                        }).ToList();
                Methods.Nice_grid(
                      new string[] { "IdReq", "Nom", "Desc", "Datedemande",  "Getstatut" },
                      new string[] { "ID Demande", "Employee", "Description", "Date Demande", "Statut" },
                      dgDemande);
            }
        }

        public ListDemande(string statutReq, int countReq, int idEmploye)
        {
            InitializeComponent();
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    if (countReq == 0 && statutReq == "" && idEmploye == 0)
                    {
                        dgDemande.DataSource = (from d in context.GetRequestbyStatut(new Label[] { lblTotalRequest,lblListRequest })
                                                select new
                                                {
                                                    d.Id,
                                                    d.IdReq,
                                                    d.Datedemande,
                                                    Desc = Methods.GetDesc(d.Description_d, 4),
                                                    d.Employee.Nom,
                                                    d.Getstatut,
                                                    IdClient = d.Employee.Client.id
                                                }).ToList();
                    }

                    else
                    {
                        dgDemande.DataSource = (from d in context.GetRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest }, statutReq, idEmploye)
                                                select new {
                                                    d.Id,
                                                    d.IdReq,
                                                    d.Datedemande,
                                                    Desc = Methods.GetDesc(d.Description_d, 4),
                                                    d.Employee.Nom,
                                                    d.Getstatut,
                                                    IdClient = d.Employee.Client.id
                                                }).ToList();

                        if (idEmploye > 0)
                        {

                            Employee em = context.Employees.Find(idEmploye);
                            lblEmployeClient.Text = $"[{em.Nom} {em.Prenom}]";
                            lblEmployeClient.Visible = true;
                            dgDemande.Columns["Nom"].Visible = false;
                            lblEmployeClient.ForeColor = Color.FromArgb(0, 168, 255);
                        }
                    }
                    HideColumns(new string[] { "id", "IdClient" }, dgDemande);
                    
                    Methods.Nice_grid(
                        new string[] { "IdReq", "Datedemande", "Desc", "Nom", "Getstatut" },
                        new string[] { "ID Demande", "Date Demande", "Description", "Employee", "Statut" },
                        dgDemande);
                }
            }
        }

        public void HideColumns(string[] clms,DataGridView grid)
        {
            foreach (var s in clms)
            {
                grid.Columns[s].Visible = false;
            }
        }

        private void ListRequest_Load(object sender, EventArgs e)
        {
            //ControlsClass.CreateRadiusBorder(this);
        }

        private void dgDemande_DoubleClick(object sender, EventArgs e)
        {
            DetailsRequest();
        }

        private void btnTraiter_Click(object sender, EventArgs e)
        {
            StartIntervention();
        }

        private void dgDemande_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get mouse position relative to the vehicles grid
                var relativeMousePosition = dgDemande.PointToClient(Cursor.Position);

                // Show the context menu
                contextMenuStrip1.Show(dgDemande, relativeMousePosition);
            }
        }

        private void menuDetails_Click(object sender, EventArgs e)
        {
            DetailsRequest();
        }

        public void DetailsRequest()
        {
            if (dgDemande.SelectedRows.Count > 0)
            {
                int index = dgDemande.CurrentRow.Index;
                int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());

                GlobVars.frmindex.ShowControl(new FichDemande(selectedRequest));
            }
        }

        public void StartIntervention()
        {
            if (dgDemande.SelectedRows.Count > 0)
            {
                int index = dgDemande.CurrentRow.Index;
                int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());

                if (dgDemande.Rows[index].Cells["GetStatut"].Value.ToString() == "terminer")
                    MessageBox.Show("Youn cant start intervention for done request");
                else
                {
                    int idcl = int.Parse(dgDemande.Rows[index].Cells["IdClient"].Value.ToString());
                    GlobVars.frmindex.ShowControl(new NewIntervention(idcl, selectedRequest));
                }
            }
        }

        private void menuStartIntervention_Click(object sender, EventArgs e)
        {
            StartIntervention();
        }

        private void dgDemande_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDemande.SelectedRows.Count > 0)
            {
                var myrow = dgDemande.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var dem = (from c in context.Demandes
                                  where c.Id == id && c.Modifierpar != null
                                  join u in context.Utilisateurs on c.Modifierpar equals u.Id
                                  select new { u.Nom, c.Datemodification }).FirstOrDefault();
                    if (dem != null)
                    {
                        int loc = 325;
                        lblEdited.Text = dem.Nom;
                        loc += lblEdited.Width;
                        lblMod.Location = new Point(loc, 459);
                        // MessageBox.Show(clt.Nom.Length.ToString());
                        lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 459);
                        lblEditedDate.Text = dem.Datemodification.ToString();
                    }
                    else
                    {
                        lblEdited.Text = "aucune";
                        lblEditedDate.Text = "****-**-**";
                    }
                }
            }
        }
    }
}