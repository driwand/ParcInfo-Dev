using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucControls;
using ParcInfo.Classes;
using ParcInfo.ucInterevntion;

namespace ParcInfo.ucDemande
{
    public partial class FicheDemande1 : UserControl
    {
        public int interventionName = 1;
        public int ReqId;
        public int ClientId;
        public string ReqStat;

        public FicheDemande1(int IdReq,string NomClient = "")
        {
            InitializeComponent();
            using (var db = new ParcInformatiqueEntities())
            {
                var currentReq = db.Demandes.Where(r => r.Id == IdReq).FirstOrDefault();
                if (currentReq != null)
                {
                    ReqId = IdReq;
                    lblClientName.Text = currentReq.Employee.Client.Nom;
                    ReqStat = currentReq.Getstatut;
                    ClientId = currentReq.Employee.Client.id;
                    txtNom.Text = currentReq.Employee.Nom;
                    txtPrenom.Text = currentReq.Employee.Prenom;
                    txtDepart.Text = currentReq.Employee.Departement.Nom;
                    txtTel.Text = currentReq.Employee.Tel;
                    txtStatut.Text = currentReq.Getstatut;
                    txtDate.Text = currentReq.Datedemande.ToString();
                    MultiLineLabel ml = new MultiLineLabel();

                    ml.Parent = pnlDesc;
                    ml.Margin = new Padding(0, 4, 0, 0);
                    ml.AutoSize = true;
                    ml.MultiLine = true;
                    ml.Text = currentReq.Description_d;//show text of description
                    int o = ml.Height;

                    // pnlDesc.Size = new Size(300, o); //make size of panel as the height of text

                    ml = new MultiLineLabel();
                    pnlDesc.Controls.Add(ml);
                }
           
                foreach (var inter in currentReq.Interventions)
                {
                    ShowIntervention(
                        inter.IdIntrv,
                        inter.Utilisateur.Nom,
                        inter.DateIntervention.ToString(),
                        inter.Debut.ToString(),
                        inter.Fin.ToString(),
                        inter.Duree.ToString(),
                        inter.TypeIntervention,
                        inter.Statut
                        );
                }
                lblClientName.Text = $"[{NomClient}]";
            }
        }
        void ShowIntervention(string idInterv, string intervenant, string dateinter, string debut, string fin, string duree, string type, string statut)
        {
            InfoInterv infointerv = new InfoInterv();
            infointerv.Name = "int" + interventionName;
            infointerv.Margin = new Padding(0, 0, 0, 10);
            infointerv.LblID = idInterv;
            infointerv.TxtUser = intervenant;
            infointerv.TxtDateInterv = dateinter;
            infointerv.TxtDebut = debut;
            infointerv.TxtFin = fin;
            infointerv.TxtDebut = duree;
            infointerv.TxtType = type;
            infointerv.TxtStatut = statut;

            interventionName++;

            panInterv.Controls.Add(infointerv);
        }

        private void pnlDesc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FicheDemande1_Load(object sender, EventArgs e)
        {
            Methods.CheckRoles(Controls);

            if (ReqStat == "terminer")
                BtnstartInterventionFich.Visible = false;
        }

        private void BtnstartInterventionFich_Click(object sender, EventArgs e)
        {
            if (ReqStat != "terminer")
                GlobVars.frmindex.ShowControl(new NewIntervention(ClientId, ReqId));
        }
    }
}
