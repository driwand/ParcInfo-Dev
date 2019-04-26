﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using System.Data.Entity;
using Microsoft.SqlServer.Management.Common;
using System.Configuration;
using System.Data.SqlClient;
using ParcInfo.Classes;
using System.Diagnostics;

namespace ParcInfo.ucParametre
{
    public partial class AppSettingcs : UserControl
    {
        Image imglogo = null;
        Image imgicon = null;
        public AppSettingcs()
        {
            InitializeComponent();

            applogo.AllowDrop = true;
        }

        private void applogo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void applogo_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                imglogo = Image.FromFile(pic);
                applogo.Image = imglogo;
            }

        }

        private void btnFullBack_Click(object sender, EventArgs e)
        {
            Fullbackup();
        }

        private void btnDifferentialBackup_Click(object sender, EventArgs e)
        {
            DifferentialBackup();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            RestoreDatabase();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                var defpara = db.ParametreParcinfoes.FirstOrDefault();

                int dayvalue = Convert.ToInt32(numDays.Value);
                ParametreParcinfo pr = new ParametreParcinfo
                {
                    Nomapp = txtappname.Text != "" ? txtappname.Text : defpara.Nomapp,
                    Reatrddemande = dayvalue != defpara.Reatrddemande ? dayvalue : defpara.Reatrddemande,
                    Logoapp = imglogo != null ? Methods.ImageToByteArray(imglogo) : defpara.Logoapp,
                    Iconapp = imgicon != null ? Methods.ImageToByteArray(imgicon) : defpara.Iconapp,
                };

                defpara.Iconapp = pr.Iconapp;
                defpara.Logoapp = pr.Logoapp;
                defpara.Nomapp = pr.Nomapp;
                defpara.Reatrddemande = pr.Reatrddemande;
                
                db.SaveChanges();

                if (imglogo != null || imgicon != null)
                {
                    var result = MessageBox.Show("do you wannt to restart", ".", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
        }

        public void Fullbackup()
        {
            Backup bkpDBFull = new Backup();
            
            bkpDBFull.Action = BackupActionType.Database;
            
            bkpDBFull.Database = "ParcInformatique";
            bkpDBFull.Devices.AddDevice(@"D:\ParcInformatiqueFull.bak", DeviceType.File);
            bkpDBFull.BackupSetName = "ParcInformatique database Backup";
            bkpDBFull.BackupSetDescription = "ParcInformatique database - Full Backup";

            bkpDBFull.ExpirationDate = DateTime.Today.AddDays(10);

            bkpDBFull.Initialize = false;

            Server myServer = new Server(".");
            bkpDBFull.SqlBackup(myServer);
        }

        public void DifferentialBackup()
        {
            Backup bkpDBDifferential = new Backup();

            bkpDBDifferential.Action = BackupActionType.Database;
            
            bkpDBDifferential.Database = "ParcInformatique";

            bkpDBDifferential.Devices.AddDevice(@"D:\ParcInformatique.bak", DeviceType.File);
            bkpDBDifferential.BackupSetName = "ParcInformatique database Backup";
            bkpDBDifferential.BackupSetDescription = "ParcInformatique database - Differential Backup";

            bkpDBDifferential.ExpirationDate = DateTime.Today.AddDays(10);
            bkpDBDifferential.Initialize = false;
            bkpDBDifferential.Incremental = true;

            Server myServer = new Server(".");

            try
            {
                bkpDBDifferential.SqlBackup(myServer);
            }
            catch
            {
                MessageBox.Show("You cant do a differential backup with out having an existing full back up");
            }
            
        }



        public void RestoreDatabase()
        {
            Restore restoreDB = new Restore();
            restoreDB.Database = "ParcInformatique";
            restoreDB.Action = RestoreActionType.Database;
            restoreDB.Devices.AddDevice(@"D:\ParcInformatiqueFull.bak", DeviceType.File);

            restoreDB.ReplaceDatabase = true;
            restoreDB.NoRecovery = true;

            Server myserver = new Server(".");
            restoreDB.SqlRestore(myserver);
        }

        private void btnPickIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Png files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    imgicon = new Bitmap(dlg.FileName);
                    picIcon.Image = imgicon;
                }
            }
        }
    }
}
