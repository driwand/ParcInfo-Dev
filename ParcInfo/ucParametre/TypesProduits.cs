using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucControls;
using ParcInfo.ucClient;

namespace ParcInfo.settings
{
    public partial class TypesProduits : UserControl
    {
        int typeName = 1;
        string ctrlName;

        public TypesProduits()
        {
            InitializeComponent();
            txtlblType.DelType += new EventHandler(DelDep_clicked);




        }
        void DelDep_clicked(object sender, EventArgs e)
        {
            ctrlName = ((Control)sender).Name;
            if (flowLayoutPanel1.Controls.Count > 1)
            {
                //lblTextbox dx = this.Controls.Find("userC" + userName, false) as lblTextbox;
                txtlblType tbx = this.Controls.Find(ctrlName, true).FirstOrDefault() as txtlblType;
                flowLayoutPanel1.Controls.Remove(tbx);
            }
        }
        private void TypesProduits_Load(object sender, EventArgs e)
        {
            // txtlblDepartement depr = new txtlblDepartement();
            txtlblType type = new txtlblType();
            type.Name = "type" + typeName;
            type.Margin = new Padding(0, 0, 0, 12);
            
            typeName++;
            flowLayoutPanel1.Controls.Add(type);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // txtlblDepartement depr = new txtlblDepartement();
            txtlblType type = new txtlblType();
            type.Name = "type" + typeName;
            type.Margin = new Padding(0, 0, 0, 12);
            typeName++;
            flowLayoutPanel1.Controls.Add(type);

            flowLayoutPanel1.Height += 23;

            if (flowLayoutPanel1.Size == flowLayoutPanel1.MaximumSize)
            {
                flowLayoutPanel1.AutoScroll = true;

            }
            flowLayoutPanel1.Controls.Add(type);
        }
    }
}
