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
        int idclient;
        string statutit;
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
                    lblSource.Text = $"[{Code}]";
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
                lblEditedDate.Text = dgIntervention.Rows[index].Cells["Datemodification"].Value.ToString();
            }
        }
    }
}
