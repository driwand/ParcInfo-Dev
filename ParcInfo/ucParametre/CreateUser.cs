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

            using (ParcInformatiqueEntities context  = new ParcInformatiqueEntities())
            {
                var c = context.Clients.Where(d => d.IsDeleted == 0).ToList();
                dgClient.DataSource = Methods.ToDataTable(c.Select(cl => new { cl.IdCLient,cl.id, cl.Nom, cl.Tel }).ToList());
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
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                var listC = (from cx in context.AffectationClients
                         where cx.Idutilisateur == idUser && cx.IsDeleted == 0
                         join x in context.Clients on cx.Idclient equals x.id
                         select x).ToList();
              //  var c = context.Clients.Where(d => d.IsDeleted == 0).ToList();
                dgClient.DataSource = Methods.ToDataTable(listC.Where(d=> d.IsDeleted == 0).Select(
                    cl => new {
                    cl.IdCLient,
                    cl.id,
                    cl.Nom, cl.Tel }).ToList());
                Methods.Nice_grid(
                                 new string[] { "IdCLient", "id", "Nom", "Tel" },
                                 new string[] { "ID Client", "id", "Nom", "Tel" },
                                 dgClient
                                 );
                dgClient.MultiSelect = true;
                Methods.FilterDataGridViewIni(dgClient, txtFind, btnFind);
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

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
                       Password_u = haspass
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
                                    Creepar = GlobVars.currentUser
                                });
                           }

                            foreach (var item in idListClient)
                            {
                                context.AffectationClients.Add(new AffectationClient
                                {
                                    Idclient = item,
                                    Idutilisateur = user.Id,
                                    Creepar = GlobVars.currentUser,
                                    IsDeleted = 0
                                });
                            }
                        }
                        context.SaveChanges();
                        //Methods.sendEmail(Email, body);
                    }
                    else
                    {
                        MessageBox.Show("email already exists");
                    }
                }       
            }
        }
 

        public void GetValues()
        {
            using (var context = new ParcInformatiqueEntities())
            {
                List<CheckBox> lstr = new List<CheckBox>();
               GetAllCheckbox(pnlRoles, lstr);
                if (idU > 0)
                {
                    var listR = context.GetListRoles(idU);
                    //foreach (var item in listR)
                    //{
                    //    foreach (var c in lstr)
                    //    {
                    //        if (item.Nom == c.Text)
                    //        {
                    //            c.Checked = true;
                    //        }
                    //        else if (item.Nom == c.Text + " " + c.Parent.Text)
                    //        {
                    //            c.Checked = true;
                    //        }
                    //    }
                    //}
                    foreach (var c in lstr)
                    {
                        foreach (var item in listR)
                        {
                            if (item.Nom == c.Text)
                            {
                                c.Checked = true;
                            }
                            else if (item.Nom == c.Text + " " + c.Parent.Text)
                            {
                                c.Checked = true;
                            }
                        }
                    }
                }
            }
        }
      
        public void GetAllCheckbox(Control ctrl , List<CheckBox> ls)
        {
            //foreach (Control item in ctrl.Controls)
            //{
            //    if (item is CheckBox c)
            //    {
            //        ls.Add(c);
            //    }
            //}


            foreach (Control item in ctrl.Controls)
            {
                if (item is GroupBox)
                {
                    GetAllCheckbox(item, ls);
                }
                else if (item is CheckBox cv)
                {
                    ls.Add(cv);

                }
            }
        }

        // get Selected Client
        public  List<int> getSelectedClient()
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
        public void CheckBoxC(Control ctrl,List<string> ls)
        {
            List<string> str = new List<string>();
            foreach (Control item in ctrl.Controls)
            {
                if (item is GroupBox)
                {
                    CheckBoxC(item,ls);
                }
                else if (item is CheckBox cv)
                {
                    if (cv.Checked)
                    {
                        var t = "";
                        if (cv.Text == "Ajouter" ||  cv.Text == "Modifier" || cv.Text == "Supprimer")
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
            //List<string> lst = new List<string>();
            //CheckBoxC(pnlRoles, lst);
            //foreach (var item in lst)
            //{
            //    MessageBox.Show(item);
            //}
            //var listt = getSelectedClient();
            //foreach (var item in listt)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            GetValues();
            //foreach (Control item in pnlRoles.Controls)
            //{
            //    foreach (Control c in item.Controls)
            //    {
            //        MessageBox.Show(c.Name);
            //    }
            //}
        }

       
    }
}
