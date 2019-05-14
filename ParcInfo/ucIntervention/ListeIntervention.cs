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
        List<string> toorderby = new List<string> { "en retard", "en cours", "terminer" };
        string RoleName;

        public ListeIntervention(string statutInterv, int countInterv)
        {
            InitializeComponent();
            GetRoleName();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (countInterv == 0 && statutInterv == "")
                {
                    if (GlobVars.cuUser.isAdmin == 0)
                        GetALlInterevntions(true);
                    else
                        GetALlInterevntions();
                }
                else
                {
                    GetInterventionByStatut(statutInterv);
                }

                Methods.Nice_grid(
                    new string[] { "IdIntrv", "Nom", "Debut", "Fin", "IdDemande", "Getstatut", "IdClient" },
                    new string[] { "ID Intervention", "Client", "Debut Intervention", "Fin Intervention", "Demande", "Statut", "Idclient" },
                    dgIntervention);
            }
        }
        public ListeIntervention(int idClient, string Code)
        {
            InitializeComponent();
            GetRoleName();

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
                                  ir.Datemodification,
                                  ir.DateIntervention
                              }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();
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

        private void ListeIntervention_Load(object sender, EventArgs e)
        {
            Methods.ChangeColorCell(dgIntervention);

        }

        public void GetRoleName()
        {
            var t = GlobVars.cuUser.RoleUtilisateurs1.Where(x => x.IsDeleted == 0);
            foreach (var v in t)
                if (v.Nom.ToLower().Contains("Consulter".ToLower()) && v.Nom.ToLower().Contains("interventions".ToLower()) && v.IsDeleted != 1)
                    RoleName = v.Nom.ToLower();
        }

        public void GetALlInterevntions(bool assigned = false)
        {
            if (assigned == true)
            {
                if (RoleName == "Consulter tous les interventions".ToLower())
                {
                    assigned = false;
                    GetALlInterevntions();
                }
                else
                {

                    using (var context = new ParcInformatiqueEntities())
                    {
                        var ls = (from ir in context.GetAssignedInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention })
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
                                      ir.Datemodification,
                                      ir.DateIntervention
                                  }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();

                        Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind, ls);
                    }
                }
            }
            else
                using (var context = new ParcInformatiqueEntities())
                {
                    var ls = (from ir in context.GetInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention })
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
                                  ir.Datemodification,
                                  ir.DateIntervention
                              }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();

                    Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind, ls);
                }
        }

        public void GetInterventionByStatut(string statutInterv, bool assigned = false)
        {
            int hasll = 0;
            if (GlobVars.cuUser.isAdmin == 0)
            {
                if (RoleName == "Consulter tous les interventions".ToLower())
                {
                    hasll = 1;
                    GetALlInterevntions();
                }
                else
                {
                    using (var context = new ParcInformatiqueEntities())
                    {
                        var ls = (from ir in context.GetAssignedInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention }, statutInterv)
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
                                      ir.Datemodification,
                                      ir.DateIntervention
                                  }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();
                        statutit = statutInterv;

                        Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind, ls);
                    }
                }
            }
            if (GlobVars.cuUser.isAdmin == 1 || hasll == 1)
                using (var context = new ParcInformatiqueEntities())
                {
                    var ls = (from ir in context.GetInterventionBystatut(new Label[] { lblTotalIntervention, lblTitleIntervention }, statutInterv)
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
                                  ir.Datemodification,
                                  ir.DateIntervention
                              }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();
                    statutit = statutInterv;

                    Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind, ls);
                }
        }

        private void dgIntervention_DoubleClick(object sender, EventArgs e)
        {

        }
        private void dgIntervention_Click(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void chDelIntr_CheckedChanged(object sender, EventArgs e)
        {

            if (chDelIntr.Checked && idclient != 0)
                Showintervention(idclient, true);
            else if (!chDelIntr.Checked && idclient != 0)
                Showintervention(idclient, false);
            if (statutit != null)
            {
                if (chDelIntr.Checked)
                    Showintervention(0, true, statutit);
                else if (!chDelIntr.Checked)
                    Showintervention(0, false, statutit);
            }
            else
            {
                if (chDelIntr.Checked && idclient == 0)
                    Showintervention(0, true);
                else if (!chDelIntr.Checked && idclient == 0)
                    Showintervention(0, false);

            }

            Methods.ChangeColorCell(dgIntervention);
            
        }

        public void Showintervention(int id = 0, bool isdeleted = false, string statut = null)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                int hasall = 0;
                if (GlobVars.cuUser.isAdmin == 0)
                {
                    if (RoleName == "Consulter tous les interventions".ToLower())
                    {
                        hasall = 1;
                    }
                    if (hasall == 0)
                    {
                        var ls = (from ir in db.GetAssignedInterventionBystatut(null, null, isdeleted)
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
                                      ir.Datemodification,
                                      ir.DateIntervention
                                  }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();
                        if (id != 0)
                            ls = ls.Where(i => i.Idclient == id).ToList();

                        if (statut != null)
                            ls = ls.Where(i => i.Getstatut == statut).ToList();

                        dgIntervention.DataSource = Methods.ToDataTable(ls);
                        lblTotalIntervention.Text = ls.Count().ToString();
                    }
                }
                if (GlobVars.cuUser.isAdmin == 1 || hasall == 1)
                {
                    var ls = (from ir in db.GetInterventionBystatut(null, null, isdeleted)
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
                                  ir.Datemodification,
                                  ir.DateIntervention
                              }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).ToList();
                    if (id != 0)
                        ls = ls.Where(i => i.Idclient == id).ToList();

                    if (statut != null)
                        ls = ls.Where(i => i.Getstatut == statut).ToList();

                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                    lblTotalIntervention.Text = ls.Count().ToString();
                }
            }
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
                lblMod.Location = new Point(loc, 456);

                lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 456);
                lblEditedDate.Text = dgIntervention.Rows[index].Cells["Datemodification"].Value.ToString();
            }
            else
            {
                lblEdited.Text = "aucun";
                lblEdited.Location = new Point(333, 456);
                lblEditedDate.Text = "**/**/****";
            }


        }

        private void lblEdited_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new CardUsers(idUser));
        }

        private void dgIntervention_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int index = dgIntervention.CurrentRow.Index;

                int selectedInt = int.Parse(dgIntervention.Rows[index].Cells["id"].Value.ToString());

                if (dgIntervention.Rows[index].Cells["IdDemande"].Value.ToString() != "")
                {
                    

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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgIntervention_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            GetDetails();
        }
    }
}