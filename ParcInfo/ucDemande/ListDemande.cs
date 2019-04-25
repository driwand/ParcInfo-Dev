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

        public int Idcli;
        public string statut;
        public int employee;

        //listdemande of selected client
        public ListDemande(int idClient, string nom)
        {
            InitializeComponent();
            using (var db = new ParcInformatiqueEntities())
            {
                Idcli = idClient;

                var lsreq = (from d in db.GetRequestbyStatut()
                                        where d.Employee.Client.id == idClient
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


                dgDemande.DataSource = Methods.ToDataTable(lsreq);

                Methods.Nice_grid(
                    new string[] { "IdReq", "Datedemande", "Desc", "Nom", "Getstatut" },
                    new string[] { "ID Demande", "Date Demande", "Description", "Employee", "Statut" },
                    dgDemande);

                Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind);
            }
        }

        public ListDemande(string statutReq, int countReq, int idEmploye)
        {
            InitializeComponent();
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    employee = idEmploye;
                    if (countReq == 0 && statutReq == "" && idEmploye == 0)
                    {
                        var lsreq = (from d in context.GetRequestbyStatut(new Label[] { lblTotalRequest,lblListRequest })
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

                        Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, lsreq);
                    }

                    else
                    {
                        statut = statutReq;
                        
                        var lsreq = (from d in context.GetRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest }, statutReq, idEmploye)
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

                        Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind,lsreq);
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

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelete.Checked && Idcli == 0)
                ShowRequest(0, 0, true);
            else if (!cbDelete.Checked && Idcli == 0)
                ShowRequest(0, 0, false);

            if (cbDelete.Checked && Idcli != 0)
                ShowRequest(Idcli, 0, true);
            else if (!cbDelete.Checked && Idcli != 0)
                ShowRequest(Idcli, 0, false);


            if (cbDelete.Checked && statut != null)
                ShowRequest(0, 0, true, statut);
            else if (!cbDelete.Checked && statut != null)
                ShowRequest(0, 0, false, statut);

            if (cbDelete.Checked && employee != 0)
                ShowRequest(0, employee, true);
            else if (!cbDelete.Checked && employee != 0)
                ShowRequest(0, employee, false);
        }

        public void ShowRequest(int idclt = 0,int idemployee = 0, bool isdeleted = false, string statut = null)
        {
            using (var context = new ParcInformatiqueEntities())
            {
                var ls = (from d in context.GetRequestbyStatut(null,null,idemployee,isdeleted)
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

                if (idclt != 0)
                    ls = ls.Where(i => i.IdClient == idclt).ToList();

                if (statut != null)
                    ls = ls.Where(i => i.Getstatut == statut).ToList();

                Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, ls);
            }
        }
    }
}