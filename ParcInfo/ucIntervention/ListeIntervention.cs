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
using ParcInfo.ucControls;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using ParcInfo.ucParametre;

namespace ParcInfo.ucInterevntion
{
    public partial class ListeIntervention : UserControl
    {
        int idclient;
        string statutit;
        int idUser;
        public ListeIntervention(string statutInterv,int countInterv)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (countInterv == 0 && statutInterv == "")
                {

                    var ls = (from ir in context.GetInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention })
                             select new {
                                 ir.IdIntrv,
                                 ir.Id,
                                 ir.Client.Nom,
                                 ir.Debut,
                                 ir.Fin,
                                 ir.IdDemande,
                                 ir.Getstatut,
                                 ir.Idclient,
                                 Edited = ir.UtilisateurEdit.Nom,
                                 ir.Modifierpar,
                                 ir.Datemodification
                             }).ToList();

                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                }
                else
                {
                    var ls = (from ir in context.GetInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention }, statutInterv)
                              select new {
                                  ir.IdIntrv,
                                  ir.Id,
                                  ir.Client.Nom,
                                  ir.Debut,
                                  ir.Fin,
                                  ir.IdDemande,
                                  ir.Getstatut,
                                  ir.Idclient,
                                  Edited = ir.UtilisateurEdit.Nom,
                                  ir.Modifierpar,
                                  ir.Datemodification
                              }).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                    statutit = statutInterv;
                }
              
                Methods.Nice_grid(
                    new string[] { "IdIntrv", "Nom" ,"Debut", "Fin", "IdDemande","Getstatut", "IdClient" },
                    new string[] { "ID Intervention", "Client", "Debut Intervention", "Fin Intervention", "Demande", "Statut", "Idclient" },
                    dgIntervention);

                Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind);
                
            }
        }
        public ListeIntervention(int idClient,string Code)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (idClient > 0 && Code != "")
                {
                    idclient = idClient;
                    lblTitleIntervention.Text = "Les intervention du";
                    lblSource.Text = $"[{Code}]";
                    lblSource.ForeColor = Color.FromArgb(0, 168, 255);
                    lblSource.Visible = true;
                    var ls = (from ir in context.GetInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention })
                              where ir.Idclient == idClient
                              select new
                              {
                                  ir.IdIntrv,
                                  ir.Id,
                                  ir.Client.Nom,
                                  ir.Debut,
                                  ir.Fin,
                                  ir.IdDemande,
                                  ir.Getstatut,
                                  ir.Idclient,
                                  Edited = ir.UtilisateurEdit.Nom,
                                  ir.Modifierpar,
                                  ir.Datemodification
                              }).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                    lblTotalIntervention.Text = ls.Count().ToString();
                    Methods.Nice_grid(
                        new string[] { "IdIntrv", "Nom", "Debut", "Fin", "IdDemande", "Getstatut", "IdClient" },
                        new string[] { "ID Intervention", "Client", "Debut Intervention", "Fin Intervention", "Demande", "Statut", "Idclient" },
                        dgIntervention);
                    Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind);
                }
            }
        }
        private void dgIntervention_DoubleClick(object sender, EventArgs e)
        {
            if (dgIntervention.SelectedRows.Count > 0)
            {
                int index = dgIntervention.CurrentRow.Index;
                
                int selectedInt = int.Parse(dgIntervention.Rows[index].Cells["id"].Value.ToString());
                
                if (dgIntervention.Rows[index].Cells["IdDemande"].Value.ToString() != "")
                {
                    GlobVars.frmBack = this;

                    GlobVars.frmindex.ShowControl(
                        new NewIntervention(
                            0,
                            0, 
                            selectedInt,
                            int.Parse(dgIntervention.Rows[index].Cells["IdDemande"].Value.ToString()))
                            );
                }
                else
                {
                    GlobVars.frmBack = this;

                    GlobVars.frmindex.ShowControl(
                        new NewIntervention(
                            0,
                            0,
                            selectedInt,
                            int.Parse(dgIntervention.Rows[index].Cells["Idclient"].Value.ToString()))
                            );
                }

            }
        }
        private void dgIntervention_Click(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void chDelIntr_CheckedChanged(object sender, EventArgs e)
        {            
            if (chDelIntr.Checked && idclient == 0)
                Showintervention(0, true);
            else if (!chDelIntr.Checked && idclient == 0)
                Showintervention(0, false);
            

            if (chDelIntr.Checked && idclient != 0)
                Showintervention(idclient, true);
            else if(!chDelIntr.Checked && idclient != 0)
                Showintervention(idclient, false);


            if (chDelIntr.Checked && statutit != null)
                Showintervention(0, true, statutit);
            else if (!chDelIntr.Checked && statutit != null)
                Showintervention(0, false, statutit);

        }

        public void Showintervention(int id = 0,bool isdeleted = false, string statut = null)
        { 
            using (var db = new ParcInformatiqueEntities())
            {
                var ls = (from ir in db.GetInterventionBystatut(null,null,isdeleted)
                          select new
                          {
                              ir.IdIntrv,
                              ir.Id,
                              ir.Client.Nom,
                              ir.Debut,
                              ir.Fin,
                              ir.IdDemande,
                              ir.Getstatut,
                              ir.Idclient,
                              Edited = ir.UtilisateurEdit.Nom,
                              ir.Modifierpar,
                              ir.Datemodification
                          }).ToList();

                if (id != 0)
                    ls = ls.Where(i => i.Idclient == id).ToList();

                if (statut != null)
                    ls = ls.Where(i => i.Getstatut == statut).ToList();

                dgIntervention.DataSource = Methods.ToDataTable(ls);
                lblTotalIntervention.Text = ls.Count().ToString();
            }
        }

        private void ListeIntervention_Load(object sender, EventArgs e)
        {

        }

        private void dgIntervention_Paint(object sender, PaintEventArgs e)
        {
            if (dgIntervention.SelectedRows.Count > 0)
            {
                GetDetails();
            }
        }

        public void GetDetails()
        {
            if (dgIntervention.SelectedRows.Count > 0)
            {
                int index = dgIntervention.CurrentRow.Index;
                lblEdited.Text = dgIntervention.Rows[index].Cells["Edited"].Value.ToString();
                
                idUser = Convert.ToInt32(dgIntervention.Rows[index].Cells["Modifierpar"].Value);

                int loc = 333;
                loc += lblEdited.Width;
                lblMod.Location = new Point(loc, 459);
                
                lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 459);
                lblEditedDate.Text = dgIntervention.Rows[index].Cells["Datemodification"].Value.ToString();
            }
        }

        private void lblEdited_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new CardUsers(idUser));
        }
    }
}
