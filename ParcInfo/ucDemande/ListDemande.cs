using System;
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

                var res = db.Demandes.Where(x => x.Employee.Client.id == idClient).ToList();
                dgDemande.DataSource = res;
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
            int index = dgDemande.CurrentRow.Index;
            int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());

            GlobVars.frmindex.ShowControl(new FichDemande(selectedRequest));
        }

        private void btnTraiter_Click(object sender, EventArgs e)
        {
            int index = dgDemande.CurrentRow.Index;
            int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());

            if (dgDemande.Rows[index].Cells["GetStatut"].Value.ToString() == "terminer")
                MessageBox.Show("Youn cant start intervention for done request");
            else
            {
                int idcl = int.Parse(dgDemande.Rows[index].Cells["IdClient"].Value.ToString());
                GlobVars.frmindex.ShowControl(new NewIntervention(idcl,selectedRequest));
            }
        }
    }
}