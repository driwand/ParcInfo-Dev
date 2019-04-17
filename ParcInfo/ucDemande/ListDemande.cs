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
        public ListDemande(int idEmployee)
        {
            InitializeComponent();
            {
                using (var context = new ParcInformatiqueEntities())
                {
                    var reqEmploye = context.Employees.Find(idEmployee).Demandes.ToList();
                    dgDemande.DataSource = reqEmploye;
                }
            }
        }
        public ListDemande(string statutReq, int countReq)
        {
            InitializeComponent();
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                    if (countReq == 0 && statutReq == "")
                    {
                        dgDemande.DataSource = context.GetRequestbyStatut(lblTotalRequest);
                    }
                    else
                    {
                        dgDemande.DataSource = context.GetRequestbyStatut(lblTotalRequest, statutReq);
                    }
                }
            }
        }
       

        public void clientRequets()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var demand = Methods.ToDataTable<Demande>(context.Demandes.ToList());
                dgDemande.DataSource = demand;

                if (GlobVars.selectedEmploye > 0)
                {
                    string name = GlobVars.BtnName;
                    int id = GlobVars.selectedEmploye;
                    var emp = context.Employees.Find(id);
                    lblEmployeClient.Visible = true;
                    switch (name)
                    {
                        case "gpDemandeEncours":
                            Methods.getDemande(dgDemande, id, "en cours");
                            lblEmployeClient.Text = $"[{emp.Nom} {emp.Prenom}]";
                            break;
                        case "gpDemandeEnRetard":
                            Methods.getDemande(dgDemande, id, "en retard");
                            lblEmployeClient.Text = $"[{emp.Nom} {emp.Prenom}]";
                            break;
                        case "gpDemandeE":
                            Methods.getDemande(dgDemande, id, "");
                            lblEmployeClient.Text = $"[{emp.Nom} {emp.Prenom}]";
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private void ListRequest_Load(object sender, EventArgs e)
        {
            //ControlsClass.CreateRadiusBorder(this);

        }

        private void dgDemande_DoubleClick(object sender, EventArgs e)
        {
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