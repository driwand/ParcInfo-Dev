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

namespace ParcInfo.ucDemande
{
    public partial class FichDemande : UserControl
    {
        int interventionName = 1;
        public FichDemande(int IdReq)
        {
            InitializeComponent();

            using (var db = new ParcInformatiqueEntities())
            {
                var currentReq = db.GetRequests.Where(r => r.Id == IdReq).FirstOrDefault();
                lblDemande.Text = currentReq.IdReq;
                lblNom.Text = currentReq.Employee.Nom;
                lblPrenom.Text = currentReq.Employee.Prenom;
                lbltel.Text = currentReq.Employee.Tel.ToString();
                lblDepart.Text = currentReq.Employee.Departement.Nom;
                lblStatut.Text = currentReq.Statut;
                lblDateDemande.Text = currentReq.Datedemande.ToString();

                //MultiLineLabel ml = new MultiLineLabel();
                //ml.Margin = new Padding(0, 10, 0, 0);

                //ml.Parent = pnlDesc;
                //ml.AutoSize = true;
                //ml.MultiLine = true;
                //ml.Text = currentReq.Description_d;//show text of description
                //int o = ml.Height;

                //pnlDesc.Size = new Size(300, o); //make size of panel as the height of text

                //ml = new MultiLineLabel();
                //pnlDesc.Controls.Add(ml);

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
            }
        }

        void ShowIntervention(string idInterv,string intervenant,string dateinter,string debut,string fin,string duree,string type,string statut)
        {
            infoIntervention infointerv = new infoIntervention();
            infointerv.Name = idInterv;
            infointerv.lblIntervenant.Text = intervenant;
            infointerv.lblDateCreation.Text = dateinter;
            infointerv.lblDebut.Text = debut;
            infointerv.lblFin.Text = fin;
            infointerv.lblDuree.Text = duree;
            infointerv.lblType.Text = type;
            infointerv.lblStatut.Text = statut;

            interventionName++;

            flowLayoutPanel1.Controls.Add(infointerv);
        }

        private void FichDemande_Load(object sender, EventArgs e)
        {

        }
    }
}
