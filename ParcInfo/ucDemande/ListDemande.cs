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
                        var lsReq = context.Demandes.ToList();
                        dgDemande.DataSource = lsReq;
                        lblTotalRequest.Text = lsReq.Count().ToString();

                    }
                    else
                    {
                        dgDemande.DataSource = getRequest(statutReq);
                        lblTotalRequest.Text = countReq.ToString();
                    }
                }
            }
        }
        public List<Demande> getRequest(string stat, bool tes = false)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var lsReq = new List<Demande>();

                switch (stat)
                {
                    case "en cours":
                        lblTotalRequest.BackColor = Color.FromArgb(250, 130, 49);
                        break;
                    case "en retard":
                        lblTotalRequest.BackColor = Color.FromArgb(252, 92, 101);
                        break;
                    case "terminer":
                        lblTotalRequest.BackColor = Color.FromArgb(32, 191, 107);
                        break;
                }

                lsReq = (from c in context.Demandes
                         where c.Statut == stat
                         select c).ToList();


                return lsReq.ToList();
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
            GlobVars.selectedRequest = int.Parse(dgDemande.Rows[index].Cells[0].Value.ToString());
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                GlobVars.selectedClient = context.Demandes.Find(GlobVars.selectedRequest).Employee.Client.id;
            }

        }
    }
}