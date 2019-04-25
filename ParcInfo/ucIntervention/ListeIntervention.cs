﻿using System;
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

namespace ParcInfo.ucInterevntion
{
    public partial class ListeIntervention : UserControl
    {
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
                                 IdClient = ir.Client.id
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
                                  IdClient = ir.Client.id
                              }).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                }
              
                Methods.Nice_grid(
                    new string[] { "IdIntrv", "Nom" ,"Debut", "Fin", "Idclient", "IdDemande","Getstatut"},
                    new string[] { "ID Intervention", "Client", "Debut Intervention", "Fin Intervention",  "Demande", "Statut" },
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
                                  ir.Getstatut
                              }).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                    Methods.Nice_grid(
                       new string[] { "IdIntrv", "Nom", "Debut", "Fin", "Idclient", "IdDemande", "Getstatut" },
                       new string[] { "ID Intervention", "Client", "Debut Intervention", "Fin Intervention", "Demande", "Statut" },
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
                            int.Parse(dgIntervention.Rows[index].Cells["IdClient"].Value.ToString()))
                            );
                }

            }
        }

        private void chDelIntr_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void ListeIntervention_Load(object sender, EventArgs e)
        {

        }

        private void dgIntervention_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgIntervention.SelectedRows.Count > 0)
            {
                var myrow = dgIntervention.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var interv = (from c in context.Interventions
                               where c.Id == id && c.Modifierpar != null
                               join u in context.Utilisateurs on c.Modifierpar equals u.Id
                               select new { u.Nom, c.Datemodification }).FirstOrDefault();
                    if (interv != null)
                    {
                        int loc = 325;
                        lblEdited.Text = interv.Nom;
                        loc += lblEdited.Width;
                        lblMod.Location = new Point(loc, 459);
                        // MessageBox.Show(clt.Nom.Length.ToString());
                        lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 459);
                        lblEditedDate.Text = interv.Datemodification.ToString();
                    }
                    else
                    {
                        lblEdited.Text = "aucune";
                        lblEditedDate.Text = "****-**-**";
                    }
                }
            }
        }
    }
}
