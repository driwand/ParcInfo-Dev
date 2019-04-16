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


        public ListDemande()
        {
            InitializeComponent();
        }

        private void ListRequest_Load(object sender, EventArgs e)
        {
            //ControlsClass.CreateRadiusBorder(this);


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

        private void dgDemande_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnTraiter_Click(object sender, EventArgs e)
        {
            int index = dgDemande.CurrentRow.Index;
            GlobVars.selectedRequest = int.Parse(dgDemande.Rows[index].Cells[0].Value.ToString());
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                GlobVars.selectedClient = context.Demandes.Find(GlobVars.selectedRequest).Employee.Client.id;
            }

        }
    }
}