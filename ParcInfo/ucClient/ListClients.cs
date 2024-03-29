﻿using ParcInfo.Classes;
using ParcInfo.ucInterevntion;
using ParcInfo.ucParametre;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace ParcInfo.ucClient
{
    public partial class ListClients : UserControl
    {
        string GetRoleName;
        public ListClients()
        {
            InitializeComponent();

            var t = GlobVars.cuUser.RoleUtilisateurs1;
            foreach (var v in t)
                if (v.Nom.Contains("Consulter") && v.Nom.Contains("client") && v.IsDeleted != 1)
                    GetRoleName = v.Nom;
        }
        private void ListClients_Load(object sender, EventArgs e)
        {
            Methods.CheckRoles(this.Controls);

            if (GlobVars.cuUser.isAdmin == 0)
                if (GetRoleName == "Consulter tous les client")
                    GetAllClients();
                else
                    GetAssignedClients();
            else
                GetAllClients();

        }

        public void GetAllClients()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var vr = context.Clients.Where(c => c.IsDeleted == 0).ToList();
                dgClients.DataSource = Methods.ToDataTable(vr.Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    Duree = ((c.GetTotalHours > 0 ? c.GetTotalHours : 0) + "/" + c.Heurecontract),
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    userID = c.Utilisateur1 != null ? c.Utilisateur1.Id : 0,
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                    c.IsDeleted
                }).ToList());
                myGrid();
            }
        }
        public void GetAllDeletedClients()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var vr = context.Clients.Where(c => c.IsDeleted == 1).ToList();
                dgClients.DataSource = Methods.ToDataTable(vr.Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    Duree = ((c.GetTotalHours > 0 ? c.GetTotalHours : 0) + "/" + c.Heurecontract),
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    userID = c.Utilisateur1 != null ? c.Utilisateur1.Id : 0,
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                    c.IsDeleted
                }).ToList());
                myGrid();
            }
        }

        public void GetAssignedClients()
        {
            using (var context = new ParcInformatiqueEntities())
            {
                var clt = (from c in context.Clients
                           join af in context.AffectationClients on c.id equals af.Idclient
                           where af.Idutilisateur == GlobVars.cuUser.Id
                           select c).ToList();

                dgClients.DataSource = Methods.ToDataTable(clt.Where(c => c.IsDeleted == 0).Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    Duree = ((c.GetTotalHours > 0 ? c.GetTotalHours : 0) + "/" + c.Heurecontract),
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    userID = c.Utilisateur1 != null ? c.Utilisateur1.Id : 0,
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                    c.IsDeleted
                }).ToList());
                myGrid();
            }
        }

        public void GetAssigneDeletedClients()
        {
            using (var db = new ParcInformatiqueEntities())
            {
                var clt = (from c in db.Clients
                           join af in db.AffectationClients on c.id equals af.Idclient
                           where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 1
                           select c).ToList();

                dgClients.DataSource = Methods.ToDataTable(clt.Where(c => c.IsDeleted == 1).Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    Duree = ((c.GetTotalHours > 0 ? c.GetTotalHours : 0) + "/" + c.Heurecontract),
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    userID = c.Utilisateur1 != null ? c.Utilisateur1.Id : 0,
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                    c.IsDeleted
                }).ToList());
                myGrid();
            }
        }

        private void gpEmployee_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                ListEmployees lse = new ListEmployees(id);

                GlobVars.lsback.Add(lse);
                GlobVars.frmindex.pictureBox2.Show();

                GlobVars.frmindex.ShowControl(lse, true);
            }
        }
        private void btnNewClient_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new CreateClient(0, ""));
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();

                GlobVars.frmindex.ShowControl(new CreateClient(id, code));
            }
        }
        private void gpIntervention_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();

                ListeIntervention lsinter = new ListeIntervention(id, code);

                GlobVars.lsback.Add(lsinter);
                GlobVars.frmindex.pictureBox2.Show();

                GlobVars.frmindex.ShowControl(lsinter);
            }

        }
        private void gpDemande_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string nom = myrow.Cells["Nom"].Value.ToString();

                ListDemande lsinter = new ListDemande(id, nom);

                GlobVars.lsback.Add(lsinter);
                GlobVars.frmindex.pictureBox2.Show();

                GlobVars.frmindex.ShowControl(new ListDemande(id, nom));
            }
        }
        private void gpProduit_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();

                ListProduitClient lsinter = new ListProduitClient(id, code);

                GlobVars.lsback.Add(lsinter);
                GlobVars.frmindex.pictureBox2.Show();

                GlobVars.frmindex.ShowControl(lsinter);
            }
        }

        //start new intervention for seelcted request
        private void btnStartIntervention_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Etes-vous sûr de vouloir commencer une intervention?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = dgClients.CurrentRow.Index;
                    int id = int.Parse(dgClients.Rows[index].Cells["id"].Value.ToString());
                    //GlobVars.selectedClient = id;

                    GlobVars.frmindex.ShowControl(new NewIntervention(id));
                }
            }
        }
        private void CkDeletedClient_CheckedChanged(object sender, EventArgs e)
        {
            btnStartIntervention.Click -= btnStartIntervention_Click;
            //gpEmployee.Click -= gpEmployee_Click;
            //gpProduit.Click -= gpProduit_Click;
            //gpIntervention.Click -= gpIntervention_Click;
            //gpDemande.Click -= gpDemande_Click;

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (GlobVars.cuUser.isAdmin == 0)
                    if (GetRoleName == "Consulter tous les client")
                        if (CkDeletedClient.Checked)
                        {
                            GetAllDeletedClients();
                            //  Methods.ChangeDeltedRow(dgClients);
                        }
                        else
                        {
                            GetAllClients();

                        }
                    else if (CkDeletedClient.Checked)
                    {
                        GetAssigneDeletedClients();
                        //   Methods.ChangeDeltedRow(dgClients);
                    }else
                        GetAssignedClients();
                else
                    if (CkDeletedClient.Checked)
                    {
                        GetAllDeletedClients();
                        // Methods.ChangeDeltedRow(dgClients);
                    }
                    else
                    {
                        GetAllClients();
                        btnStartIntervention.Click += btnStartIntervention_Click;
                        //gpEmployee.Click += gpEmployee_Click;
                        //gpProduit.Click += gpProduit_Click;
                        //gpIntervention.Click += gpIntervention_Click;
                        //gpDemande.Click += gpDemande_Click;
                    }
            }
        }

        private void dgClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var myrow = dgClients.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    // Modifier par / date modification
                    string nomUser = myrow.Cells["userMod"].Value.ToString();
                    string date = myrow.Cells["dateMod"].Value.ToString();
                    int idUser = (int)myrow.Cells["userID"].Value;

                    int loc = 325;
                    lblEdited.Text = nomUser;
                    loc += lblEdited.Width;
                    lblMod.Location = new Point(loc, 462);
                    lblID.Text = idUser.ToString();
                    lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
                    lblEditedDate.Text = date;
                    var Cli = context.Clients.Where(c => c.id == id).FirstOrDefault();
                    if (Cli != null)
                    {
                        lblEmpC.Text = Cli.Employees.Where(d => d.IsDeleted == 0).Count().ToString();
                        lblInterC.Text = Cli.Interventions.Where(d => d.IsDeleted == 0).Count().ToString();
                        var demC = (from c in Cli.Employees
                                    from d in c.Demandes
                                    select d).ToList();
                        lblDemC.Text = demC.Where(d => d.IsDeleted == 0).Count().ToString();
                        lblProdC.Text = Cli.ProduitClients.Where(d => d.IsDeleted == 0).Count().ToString();
                    }

                }
            }

        }

        public void myGrid()
        {
            Methods.Nice_grid(
                new string[] { "IdCLient", "id", "Nom", "Adresse", "Tel", "Fax", "Siteweb","Duree", "Prixheur", "Heurecontract", "Debutcontract", "IsDeleted" },
                new string[] { "ID Client", "id", "Nom", "Adresse", "Tel", "Fax", "Site web ","Duree", "Prix Heure", "Heure Contract", "Debut Contract", "IsDeleted" },
                dgClients
                );

            Methods.FilterDataGridViewIni(dgClients, txtFind, btnFind);

        }

        private void dgClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //if (dgClients.SelectedRows.Count > 0)
                //{
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();
                GlobVars.frmindex.ShowControl(new CreateClient(id, code));
                //}
            }
        }
        public void CountToZero()
        {
            if (dgClients.Rows.Count == 0)
            {
                lblDemC.Text = "0";
                lblEmpC.Text = "0";
                lblInterC.Text = "0";
                lblProdC.Text = "0";
                int loc = 325;
                loc += lblEdited.Width;
                lblMod.Location = new Point(loc, 462);
                lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
                lblEdited.Text = "aucune";
                lblEditedDate.Text = "**-**-****";
                lblID.Text = "0";
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            CountToZero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
            int id = int.Parse(myrow.Cells["id"].Value.ToString());
            MessageBox.Show(id.ToString());
        }

        private void lblEdited_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int idU = int.Parse(lblID.Text);
            if (idU > 0)
            {
                GlobVars.frmindex.ShowControl(new CardUsers(idU));
            }
        }
    }
}
