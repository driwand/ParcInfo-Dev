﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.frmList
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();

            crysFacture f = new crysFacture();
            crystalReportViewer1.ReportSource = f;
            
        }
    }
}
