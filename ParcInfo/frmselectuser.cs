using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public partial class frmselectuser : Form
    {
        public lblTextbox tbx = null;
        public frmselectuser(lblTextbox txtbx)
        {
            InitializeComponent();
            tbx = txtbx;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var userList = (from c in context.Utilisateurs
                                select new { c.Id, c.Nom, c.Prenom, c.Email, c.Tel }).ToList();
                dgUsers.DataSource = userList;
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if(dgUsers.SelectedRows.Count > 0)
            {
                var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                string Nom = myrow.Cells[1].Value.ToString();
                string Prenom = myrow.Cells[2].Value.ToString();
                tbx.TxtValue = Nom + " " + Prenom;
                tbx.Lblid = id;
                Close();
            }
            else
            {
                MessageBox.Show("aucune");
            }
            


        }
    }
}
