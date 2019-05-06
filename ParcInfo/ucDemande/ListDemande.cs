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
using ParcInfo.ucDemande;
using ParcInfo.ucParametre;

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
        public int Idcli;
        public string statut;
        public int employee;
        public int iduser;
        string RoleName;
        List<string> toorderby = new List<string>() { "en retard", "en attente", "en cours", "terminer" };

        //listdemande of selected client
        public ListDemande(int idClient, string nom)
        {
            InitializeComponent();
            using (var db = new ParcInformatiqueEntities())
            {
                Idcli = idClient;

                var lsreq = (from d in db.GetRequestbyStatut()
                             where d.Employee.Client.id == idClient
                             select new
                             {
                                 d.Id,
                                 d.IdReq,
                                 d.Datedemande,
                                 Desc = Methods.GetDesc(d.Description_d, 4),
                                 d.Employee.Nom,
                                 d.Getstatut,
                                 IdClient = d.Employee.Client.id,
                                 d.IsDeleted
                             }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();


                dgDemande.DataSource = Methods.ToDataTable(lsreq);

                Methods.Nice_grid(
                    new string[] { "IdReq", "Datedemande", "Desc", "Nom", "Getstatut" },
                    new string[] { "ID Demande", "Date Demande", "Description", "Employee", "Statut" },
                    dgDemande);

                Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind);
            }
        }
        public ListDemande(string statutReq, int countReq, int idEmploye)
        {
            InitializeComponent();
            {
                if (statutReq == "terminer")
                {
                    btnTraiter.Visible = false;
                    gpFind.Size = new Size(863, 50);
                    txtFind.Size = new Size(683, 20);
                    btnFind.Location = new Point(829, 15);
                }   
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    employee = idEmploye;
                    GetRoleName();
                    if (countReq == 0 && statutReq == "" && idEmploye == 0)
                    {
                        if (GlobVars.cuUser.isAdmin == 1)
                            GetAllRequest();
                        else
                            if (RoleName == "Consulter tous les demandes".ToLower())
                                GetAllRequest();
                            else
                                GetAllRequest(true);
                    }

                    else
                    {
                        statut = statutReq;
                        if (GlobVars.cuUser.isAdmin == 1)
                            GetRequestByStatut(statut, idEmploye);
                        else
                            if (RoleName == "Consulter tous les demandes".ToLower())
                            GetRequestByStatut(statut, idEmploye);
                        else
                            GetRequestByStatut(statut, idEmploye, true);
                    }

                    HideColumns(new string[] { "id", "IdClient" }, dgDemande);

                    Methods.Nice_grid(
                        new string[] { "IdReq", "Datedemande", "Desc", "Nom", "Getstatut" },
                        new string[] { "ID Demande", "Date Demande", "Description", "Employee", "Statut" },
                        dgDemande);

                    if (idEmploye > 0)
                    {

                        Employee em = context.Employees.Find(idEmploye);
                        lblEmployeClient.Text = $"[{em.Nom} {em.Prenom}]";
                        lblEmployeClient.Visible = true;
                        dgDemande.Columns["Nom"].Visible = false;
                        lblEmployeClient.ForeColor = Color.FromArgb(0, 168, 255);
                    }
                }
            }
        }
        public void GetRoleName()
        {
            var t = GlobVars.cuUser.RoleUtilisateurs1.Where(x => x.IsDeleted == 0);
            foreach (var v in t)
                if (v.Nom.ToLower().Contains("Consulter".ToLower()) && v.Nom.ToLower().Contains("demande".ToLower()) && v.IsDeleted != 1)
                    RoleName = v.Nom.ToLower();
        }

        public void HideColumns(string[] clms, DataGridView grid)
        {
            foreach (var s in clms)
            {
                grid.Columns[s].Visible = false;
            }
        }

        public void GetAllRequest(bool assigned = false)
        {
            using (var context = new ParcInformatiqueEntities())
            {
                if (assigned == false)
                {
                    var lsreq = (from d in context.GetRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest })
                                 select new
                                 {
                                     d.Id,
                                     d.IdReq,
                                     d.Datedemande,
                                     Desc = Methods.GetDesc(d.Description_d, 4),
                                     Nom = d.Employee.Nom != null ? d.Employee.Nom : "",
                                     d.Getstatut,
                                     IdClient = d.Employee.Client.id != 0 ? d.Employee.Client.id.ToString() : "",
                                     d.IsDeleted
                                 }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();

                    Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, lsreq);
                }
                else
                {
                    var lsreq = (from d in context.GetAssignedRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest })
                                 select new
                                 {
                                     d.Id,
                                     d.IdReq,
                                     d.Datedemande,
                                     Desc = Methods.GetDesc(d.Description_d, 4),
                                     Nom = d.Employee.Nom != null ? d.Employee.Nom : "",
                                     d.Getstatut,
                                     IdClient = d.Employee.Client.id != 0 ? d.Employee.Client.id.ToString() : "",
                                     d.IsDeleted
                                 }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();

                    Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, lsreq);
                }
            }
        }

        public void GetRequestByStatut(string statutReq, int idEmploye, bool assigned = false)
        {
            using (var context = new ParcInformatiqueEntities())
            {
                if (assigned == false)
                {
                    var lsreq = (from d in context.GetRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest }, statutReq, idEmploye)
                                 select new
                                 {
                                     d.Id,
                                     d.IdReq,
                                     d.Datedemande,
                                     Desc = Methods.GetDesc(d.Description_d, 4),
                                     d.Employee.Nom,
                                     d.Getstatut,
                                     IdClient = d.Employee.Client.id,
                                     d.IsDeleted
                                 }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();

                    Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, lsreq);
                }
                else
                {
                    var lsreq = (from d in context.GetAssignedRequestbyStatut(new Label[] { lblTotalRequest, lblListRequest }, statutReq, idEmploye)
                                 select new
                                 {
                                     d.Id,
                                     d.IdReq,
                                     d.Datedemande,
                                     Desc = Methods.GetDesc(d.Description_d, 4),
                                     d.Employee.Nom,
                                     d.Getstatut,
                                     IdClient = d.Employee.Client.id,
                                     d.IsDeleted
                                 }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();

                    Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, lsreq);
                }
            }
        }


        private void ListRequest_Load(object sender, EventArgs e)
        {
            //ControlsClass.CreateRadiusBorder(this);
            Methods.ChangeColorCell(dgDemande);
            if (dgDemande.SelectedRows.Count > 0)
                dgDemande.Rows[0].Selected = false;
        }

        private void btnTraiter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirmation", "Etes-vous sûr de vouloir commencer une intervention ?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgDemande.SelectedRows.Count > 0)
                    if ((int)dgDemande.Rows[dgDemande.CurrentRow.Index].Cells["IsDeleted"].Value == 0)
                        StartIntervention();
                    else
                        MessageBox.Show("Vous ne pouvez pas traiter une demande supprimer");
            }
        }

        private void dgDemande_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get mouse position relative to the vehicles grid
                var relativeMousePosition = dgDemande.PointToClient(Cursor.Position);

                // Show the context menu
                contextMenuStrip1.Show(dgDemande, relativeMousePosition);
            }
        }

        private void menuDetails_Click(object sender, EventArgs e)
        {
            DetailsRequest();
        }

        public void DetailsRequest()
        {
            if (dgDemande.SelectedRows.Count > 0)
            {
                int index = dgDemande.CurrentRow.Index;
                int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());

                GlobVars.frmindex.ShowControl(new FicheDemande1(selectedRequest));
            }
        }

        public void StartIntervention()
        {
            if (dgDemande.SelectedRows.Count > 0)
            {
                int index = dgDemande.CurrentRow.Index;
                int selectedRequest = int.Parse(dgDemande.Rows[index].Cells["Id"].Value.ToString());

                if (dgDemande.Rows[index].Cells["GetStatut"].Value.ToString() == "terminer")
                    MessageBox.Show("Youn cant start intervention for done request");
                else
                {
                    int idcl = int.Parse(dgDemande.Rows[index].Cells["IdClient"].Value.ToString());
                    GlobVars.frmindex.ShowControl(new NewIntervention(idcl, selectedRequest));
                }
            }
        }

        private void menuStartIntervention_Click(object sender, EventArgs e)
        {
            StartIntervention();
        }

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelete.Checked && Idcli == 0)
                ShowRequest(0, 0, true);
            else if (!cbDelete.Checked && Idcli == 0)
                ShowRequest(0, 0, false);

            if (cbDelete.Checked && Idcli != 0)
                ShowRequest(Idcli, 0, true);
            else if (!cbDelete.Checked && Idcli != 0)
                ShowRequest(Idcli, 0, false);


            if (cbDelete.Checked && statut != null)
                ShowRequest(0, 0, true, statut);
            else if (!cbDelete.Checked && statut != null)
                ShowRequest(0, 0, false, statut);

            if (cbDelete.Checked && employee != 0)
                ShowRequest(0, employee, true);
            else if (!cbDelete.Checked && employee != 0)
                ShowRequest(0, employee, false);

            if (dgDemande.SelectedRows.Count > 0)
                dgDemande.Rows[0].Selected = false;

            Methods.ChangeColorCell(dgDemande);
        }
        public void ShowRequest(int idclt = 0, int idemployee = 0, bool isdeleted = false, string statut = null)
        {
            using (var context = new ParcInformatiqueEntities())
            {
                int hasall = 0;
                if (isdeleted == true)
                    btnTraiter.Click -= btnTraiter_Click;
                else
                    btnTraiter.Click += btnTraiter_Click;

                if (GlobVars.cuUser.isAdmin == 0)
                {
                    if (RoleName == "Consulter tous les demandes".ToLower())
                    {
                        hasall = 1;
                    }
                    if (hasall == 0)
                    {
                        var ls = (from d in context.GetAssignedRequestbyStatut(null, null, idemployee, isdeleted)
                                  select new
                                  {
                                      d.Id,
                                      d.IdReq,
                                      d.Datedemande,
                                      Desc = Methods.GetDesc(d.Description_d, 4),
                                      d.Employee.Nom,
                                      d.Getstatut,
                                      IdClient = d.Employee.Client.id,
                                      d.IsDeleted
                                  }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();

                        if (idclt != 0)
                            ls = ls.Where(i => i.IdClient == idclt).ToList();

                        if (statut != null)
                            ls = ls.Where(i => i.Getstatut == statut).ToList();

                        Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, ls);
                    }
                }
                if (GlobVars.cuUser.isAdmin == 1 || hasall == 1)
                {
                    var ls = (from d in context.GetRequestbyStatut(null, null, idemployee, isdeleted)
                              select new
                              {
                                  d.Id,
                                  d.IdReq,
                                  d.Datedemande,
                                  Desc = Methods.GetDesc(d.Description_d, 4),
                                  d.Employee.Nom,
                                  d.Getstatut,
                                  IdClient = d.Employee.Client.id,
                                  d.IsDeleted
                              }).OrderBy(i => toorderby.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).ToList();

                    if (idclt != 0)
                        ls = ls.Where(i => i.IdClient == idclt).ToList();

                    if (statut != null)
                        ls = ls.Where(i => i.Getstatut == statut).ToList();

                    Methods.FilterDataGridViewIni(dgDemande, txtFind, btnFind, ls);
                }
            }
        }

        private void lblEdited_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new CardUsers(iduser));
        }

        private void dgDemande_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                DetailsRequest();
        }
    }
}