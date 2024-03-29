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
using System.Security.Cryptography;
using System.Net.Mail;

namespace ParcInfo.ucParametre
{
    public partial class CreateUser : UserControl
    {
        public int idU;
        public CreateUser()
        {
            InitializeComponent();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var c = context.Clients.Where(d => d.IsDeleted == 0).ToList();
                dgClient.DataSource = Methods.ToDataTable(c.Select(cl => new { cl.IdCLient, cl.id, cl.Nom, cl.Tel }).ToList());
                Methods.Nice_grid(
                                 new string[] { "IdCLient", "id", "Nom", "Tel" },
                                 new string[] { "ID Client", "id", "Nom", "Tel" },
                                 dgClient
                                 );
                dgClient.MultiSelect = true;
                Methods.FilterDataGridViewIni(dgClient, txtFind, btnFind);
            }
        }
        public CreateUser(int idUser)
        {
            InitializeComponent();
            idU = idUser;
            btnEditUser.Visible = true;
            btnDelUser.Visible = true;
            btnAdd.Visible = false;
            btnEditUser.Location = new Point(770, 435);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var user = context.Utilisateurs.Find(idUser);
                var listC = (from cx in context.AffectationClients
                             join x in context.Clients on cx.Idclient equals x.id
                             where cx.Idutilisateur == idUser && cx.IsDeleted == 0
                             select x).ToList();
                dgClient.DataSource = Methods.ToDataTable(listC.Where(d => d.IsDeleted == 0).Select(
                    cl => new
                    {
                        cl.IdCLient,
                        cl.id,
                        cl.Nom,
                        cl.Tel
                    }).ToList());
                Methods.Nice_grid(
                                 new string[] { "IdCLient", "id", "Nom", "Tel" },
                                 new string[] { "ID Client", "id", "Nom", "Tel" },
                                 dgClient
                                 );
                dgClient.MultiSelect = true;
                Methods.FilterDataGridViewIni(dgClient, txtFind, btnFind);

                txtNom.Text = user.Nom;
                txtPrenom.Text = user.Prenom;
                txtAdresse.Text = user.Adresse;
                txtVille.Text = user.Ville;
                txtTel.Text = user.Tel;
                txtEmail.Text = user.Email;
                if (user.isAdmin == 1)
                {
                    ckAdmin.Checked = true;
                }
                if (user.Utilisateur3 != null)
                {

                }

                GetAllCheckbox(pnlRoles);

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int txtEmpty = 0;
                txtEmpty = Methods.Focus(this);
                List<string> lst = new List<string>();
                List<int> idListClient = new List<int>();
                if (txtEmpty == 0)
                {
                    // get values
                    string Nom = txtNom.Text;
                    string Prenom = txtPrenom.Text;
                    string Adr = txtAdresse.Text;
                    string Ville = txtVille.Text;
                    string Tel = txtTel.Text;
                    string Email = txtEmail.Text;
                    string password = Methods.CreatePassword(8);
                    int isAdmin = 0;
                    if (ckAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    var haspass = Methods.MD5Hash(password);
                    var user = new Utilisateur
                    {
                        Nom = Nom,
                        Prenom = Prenom,
                        Adresse = Adr,
                        Ville = Ville,
                        Tel = Tel,
                        Email = Email,
                        isAdmin = isAdmin,
                        Datecreation = DateTime.Now,
                        password_u = haspass,
                        IsDeleted = 0,
                        Creepar = GlobVars.cuUser.Id
                    };
                    context.Utilisateurs.Add(user);
                    var emailEmp = context.Employees.Any(i => i.Email == Email);
                    var emailEs = context.Utilisateurs.Any(i => i.Email == Email);
                    if (!emailEs && !emailEmp)
                    {
                        var body = Methods.stringMsg(Nom, Prenom, Email, password);
                        CheckBoxC(pnlRoles, lst);
                        idListClient = getSelectedClient();
                        if (isAdmin == 0)
                        {
                            foreach (var item in lst)
                            {
                                context.RoleUtilisateurs.Add(new RoleUtilisateur
                                {
                                    Nom = item,
                                    IdUtilisateur = user.Id,
                                    IsDeleted = 0,
                                    Creepar = GlobVars.cuUser.Id
                                });
                            }

                            foreach (var item in idListClient)
                            {
                                context.AffectationClients.Add(new AffectationClient
                                {
                                    Idclient = item,
                                    Idutilisateur = user.Id,
                                    Creepar = GlobVars.cuUser.Id,

                                    IsDeleted = 0
                                });
                            }
                        }
                        context.UserActivities.Add(new UserActivity
                        {
                            Iduser = GlobVars.cuUser.Id,
                            Activity = $"Utilisateur [{user.IdUser}] Créer le {DateTime.Now}"
                        });
                        context.SaveChanges();
                       
                        Methods.sendEmail(Email, body);
                        MessageBox.Show("Insertion effectuée");
                        Methods.Clear(this);
                      

                    }
                    else
                    {
                        MessageBox.Show("email already exists");
                    }
                }
            }
        }


        // get checkbox value
        
        public void GetAllCheckbox(Control ctrl)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listR = context.GetListRoles(idU);
                foreach (Control item in ctrl.Controls)
                {
                    if (item is GroupBox)
                    {
                        GetAllCheckbox(item);
                    }
                    foreach (var r in listR)
                    {
                        if (item is CheckBox cb)
                        {
                            if (cb.Text == r.Nom)
                            {
                                cb.Checked = true;
                            }
                            else if (cb.Text + " " + cb.Parent.Text == r.Nom)
                            {
                                cb.Checked = true;
                            }
                        }
                        else if (item is RadioButton rb)
                        {
                            if (rb.Text == r.Nom)
                            {
                                rb.Checked = true;
                            }
                        }
                    }
                }
            }
        }
        // get Selected Client
        public List<int> getSelectedClient()
        {
            List<int> listC = new List<int>();
            if (dgClient.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgClient.SelectedRows)
                {
                    listC.Add(int.Parse(row.Cells["id"].Value.ToString()));
                }
            }

            return listC;
        }
        // Get Roles Values
        public void CheckBoxC(Control ctrl, List<string> ls)
        {
            List<string> str = new List<string>();
            foreach (Control item in ctrl.Controls)
            {
                if (item is GroupBox && item.Enabled == true)
                {
                    CheckBoxC(item, ls);
                }
                else if (item is CheckBox cv)
                {
                    if (cv.Checked)
                    {
                        var t = "";
                        if (cv.Text == "Ajouter" || cv.Text == "Modifier" || cv.Text == "Supprimer")
                            t = cv.Text + " " + item.Parent.Text;
                        else
                            t = cv.Text;

                        ls.Add(t);
                    }
                }
                else if (item is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        ls.Add(rb.Text);
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            GetAllCheckbox(pnlRoles);

        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int txtEmpty = 0;
                txtEmpty = Methods.Focus(this);
                if (txtEmpty == 0)
                {
                    List<string> lst = new List<string>();
                    var listRoles = context.GetListRoles(idU);
                    CheckBoxC(pnlRoles, lst);
                    var deleteList = listRoles.Select(cs => cs.Nom).ToList().Except(lst);
                    var insertList = lst.Except(listRoles.Select(c => c.Nom).ToList());
                    var user = context.Utilisateurs.Find(idU);
                    foreach (var r in deleteList)
                    {
                        var c = listRoles.Where(ro => ro.Nom == r).FirstOrDefault();
                        if (c != null)
                        {
                            c.IsDeleted = 1;
                            c.Datemodification = DateTime.Now;
                            c.Modifierpar = GlobVars.cuUser.Id;
                        }
                    }
                    foreach (var item in insertList)
                    {
                        context.RoleUtilisateurs.Add(new RoleUtilisateur
                        {
                            Nom = item,
                            IdUtilisateur = idU,
                            IsDeleted = 0,
                            Creepar = GlobVars.cuUser.Id,
                            Datecreation = DateTime.Now
                        });
                    }
                    user.Nom = txtNom.Text;
                    user.Prenom = txtPrenom.Text;
                    user.Adresse = txtAdresse.Text;
                    user.Ville = txtVille.Text;
                    user.Tel = txtTel.Text;
                    txtEmail.Text = txtEmail.Text;
                    int isAdmin = 0;
                    if (ckAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    user.isAdmin = isAdmin;
                    user.Datemodification = DateTime.Now;
                    user.Modifierpar = GlobVars.cuUser.Id;
                    context.UserActivities.Add(new UserActivity
                    {
                        Iduser = GlobVars.cuUser.Id,
                        Activity = $"Utilisateur [{user.IdUser}] Modifié le {DateTime.Now}"
                    });
                    context.SaveChanges();
                    MessageBox.Show("Utilisateur modifié");

                }


            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                Utilisateur c = context.Utilisateurs.Find(idU);

                DialogResult result = MessageBox.Show("Voulez-vous supprimer le utlisateur suivant ?", "confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    c.IsDeleted = 1;
                    c.Datemodification = DateTime.Now;
                    c.Modifierpar = GlobVars.cuUser.Id;
                    context.SaveChanges();
                    MessageBox.Show("utlisateur supprimé");
                    GlobVars.frmindex.ShowControl(new ListUtilisateur());
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void chreq_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chreq, gpDemande);
        }

        private void chinterv_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chinterv, gpIntervention);
        }

        private void chproduct_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chproduct, gpProduitAff);
        }

        private void chkemployee_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chkemployee, gpemployee);
        }

        private void chproducts_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chproducts, gpProduit);
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chreq, gpDemande);
            ManageCheckGroupBox(chinterv, gpIntervention);
            ManageCheckGroupBox(chproduct, gpProduitAff);
            ManageCheckGroupBox(chkemployee, gpemployee);
            ManageCheckGroupBox(chproducts, gpProduit);
        }

        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            if (chk.Parent == grp)
            {
                grp.Parent.Controls.Add(chk);

                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                chk.BringToFront();
            }

            grp.Enabled = chk.Checked;
        }
    }
}
