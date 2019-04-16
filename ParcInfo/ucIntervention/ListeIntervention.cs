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

namespace ParcInfo.ucInterevntion
{
    public partial class ListeIntervention : UserControl
    {
        public ListeIntervention()
        {
            InitializeComponent();
        }

        public string statutInterv;
        public int countInterv;
        private void ListeIntervention_Load(object sender, EventArgs e)
        {            
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (countInterv == 0 && statutInterv == "")
                {
                    var lsInter = context.Interventions.ToList();
                    dgIntervention.DataSource = lsInter;
                    lblTotalIntervention.Text = lsInter.Count().ToString();

                }
                else
                {
                    dgIntervention.DataSource = getInterventions(statutInterv);
                    lblTotalIntervention.Text = countInterv.ToString();
                }
            }

        }
        public List<Intervention> getInterventions(string stat,bool tes=false)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var lsInter = new List<Intervention>();

                switch (stat)
                {
                    case "en cours":
                        lblTotalIntervention.BackColor = Color.FromArgb(250, 130, 49);
                        break;
                    case "en retard":
                        lblTotalIntervention.BackColor = Color.FromArgb(252, 92, 101);
                        break;
                    case "terminer":
                        lblTotalIntervention.BackColor = Color.FromArgb(32, 191, 107);
                        break;
                }

                if (stat == "")
                {
                    lsInter = (from c in context.Interventions
                               select c).ToList();
                }
                else
                {
                    lsInter = (from c in context.Interventions
                               where c.Statut == stat
                               select c).ToList();
                }

                return lsInter.ToList();
            }
        }
        private void dgIntervention_DoubleClick(object sender, EventArgs e)
        {
            if (dgIntervention.SelectedRows.Count > -1)
            {
                int index = dgIntervention.CurrentRow.Index;
                
                int sl = int.Parse(dgIntervention.Rows[index].Cells["id"].Value.ToString());
                GlobVars.frmindex.ShowControl(new NewIntervention() { currentInterv = sl});
            }
        }
        public void AddTxtDescription(string userInfo, string details, string description,Panel container)
        {
            MultiLineLabel ml = new MultiLineLabel();

            //adding description with more details to panel
            TxtDescription us = new TxtDescription();

            ml.Parent = us.pnlText;
            ml.AutoSize = true;
            ml.MultiLine = true;
            us.lblUser.Text = userInfo; //show name of current user in description
            us.lblDetails.Text = details; //datetime.now in description

            ml.Text = description;//show text of description
            int o = ml.Height;

            us.pnlText.Size = new Size(300, o); //make size of panel as the height of text

            ml = new MultiLineLabel();
            container.Controls.Add(us);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
