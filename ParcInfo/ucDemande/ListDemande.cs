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
        //public ListDemande(int idEmployee,string statut,int count)
        //{
        //    InitializeComponent();
        //    {
        //        using (var db = new ParcInformatiqueEntities())
        //        {


        //            if (count == 0 && statut == "")
        //            {
        //              // var d = db.GetRequestbyStatut(lblTotalRequest);
        //                dgDemande.DataSource = db.GetRequestbyStatut(lblTotalRequest).Where(e => e.IdEmployee == idEmployee).ToList();
        //            }
        //            else
        //            {
        //                 var d = db.GetRequestbyStatut(lblTotalRequest, statut);
        //                dgDemande.DataSource = d.Where(e => e.IdEmployee == idEmployee).ToList();
        //            }
        //        }
        //    }
        //}
        public ListDemande(string statutReq, int countReq, int idEmploye)
        {
            InitializeComponent();
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    if (countReq == 0 && statutReq == "" && idEmploye == 0)
                    {
                        dgDemande.DataSource = context.GetRequestbyStatut(lblTotalRequest);
                    }
                 
                    else
                    {
                        dgDemande.DataSource = context.GetRequestbyStatut(lblTotalRequest, statutReq, idEmploye);
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