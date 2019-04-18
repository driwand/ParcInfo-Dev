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
                        dgDemande.DataSource = (from d in context.GetRequestbyStatut(lblTotalRequest)
                                               select new
                                               {
                                                   d.Id,
                                                   Idreq = "DEM-" + Methods.Splitdate(d.Datedemande.ToString()) + d.Id,
                                                   d.Datedemande,
                                                   Desc = Methods.GetDesc(d.Description_d,4),
                                                   d.Employee.Nom,
                                                   d.Getstatut
                                               }).ToList();
                    }
                 
                    else
                    {
                        dgDemande.DataSource = (from d in context.GetRequestbyStatut(lblTotalRequest, statutReq, idEmploye)
                                               select new {
                                                   d.Id,
                                                   Idreq = "DEM-" + Methods.Splitdate(d.Datedemande.ToString()) + d.Id,
                                                   d.Datedemande,
                                                   Desc = Methods.GetDesc(d.Description_d, 4),
                                                   d.Employee.Nom,
                                                   d.Getstatut
                                               }).ToList();
                        
                        if (idEmploye > 0)
                        {
                            Employee em = context.Employees.Find(idEmploye);
                            lblEmployeClient.Text = $"[{em.Nom} {em.Prenom}]";
                            lblEmployeClient.Visible = true;
                        }
                    }
                    dgDemande.Columns["id"].Visible = false;

                    //Methods.Nice_grid(
                    //    new string[] { "idInter", "Debut", "Fin", "Idclient", "IdDemande", "Getstatut" },
                    //    new string[] { "ID Intervention", "Debut Intervention", "Fin Intervention", "Client", "Demande", "Statut" },
                    //    dgDemande);
                }
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
        }

        private void btnTraiter_Click(object sender, EventArgs e)
        {
            int index = dgDemande.CurrentRow.Index;
            int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());
            using (var db = new ParcInformatiqueEntities())
            {
                int idClient = db.Employees.Find(selectedRequest).Client.id;
                GlobVars.frmindex.ShowControl(new NewIntervention() { selectedRequest = selectedRequest, selectedClient = idClient });
            }
        }
    }
}