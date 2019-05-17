using System;
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
using System.Threading;

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
            using (var dio = new SaveFileDialog())
            {
                dio.Filter = "Backup File (*.bak)|*.bak";
                dio.ShowDialog();
                if (dio.ShowDialog() == DialogResult.OK)
                    Fullbackup(dio.FileName);
            }
        }

        private void btnDifferentialBackup_Click(object sender, EventArgs e)
        {
            using (var dio = new SaveFileDialog())
            {
                dio.Filter = "Backup File (*.bak)|*.bak";
                dio.ShowDialog();
                if (dio.ShowDialog() == DialogResult.OK)
                    DifferentialBackup(dio.FileName);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (var dio = new OpenFileDialog())
            {
                dio.Filter = "Backup File (*.bak)|*.bak";
                
                if (dio.ShowDialog() == DialogResult.OK)
                    RestoreDatabase(dio.FileName);
            }
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

        public void Fullbackup(string path)
        {
            Backup bkpDBFull = new Backup();

            bkpDBFull.Action = BackupActionType.Database;

            bkpDBFull.Database = "ParcInformatique";
            bkpDBFull.Devices.AddDevice($@"{path}", DeviceType.File);
            bkpDBFull.BackupSetName = "ParcInformatique database Backup";
            bkpDBFull.BackupSetDescription = "ParcInformatique database - Full Backup";

            bkpDBFull.ExpirationDate = DateTime.Today.AddDays(10);

            bkpDBFull.Initialize = false;
            
            try
            {
                Server myServer = new Server(".");
                bkpDBFull.SqlBackup(myServer);
            }
            catch
            {
                MessageBox.Show("Error while saving backup");
            }
        }

        public void DifferentialBackup(string path)
        {
            Backup bkpDBDifferential = new Backup();

            bkpDBDifferential.Action = BackupActionType.Database;

            bkpDBDifferential.Database = "ParcInformatique";

            bkpDBDifferential.Devices.AddDevice($@"{path}.bak", DeviceType.File);
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



        public void RestoreDatabase(string path)
        {
            Restore restoreDB = new Restore();
            restoreDB.Database = "ParcInformatique";
            restoreDB.Action = RestoreActionType.Database;
            restoreDB.Devices.AddDevice($@"{path}", DeviceType.File);

            restoreDB.ReplaceDatabase = true;
            restoreDB.NoRecovery = true;

            Server myserver = new Server(".");
            try
            {
                restoreDB.SqlRestore(myserver);
            }
            catch
            {
                MessageBox.Show("Error ");
            }   
        }

        private void btnPickIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Choisire icon";

                dlg.Filter = "Icon files (*.Icon)|*.Ico";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    imgicon = new Bitmap(dlg.FileName);
                    picIcon.Image = imgicon;
                }
            }
        }

        private void AppSettingcs_Load(object sender, EventArgs e)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                var par = db.ParametreParcinfoes.FirstOrDefault();
                if (par != null)
                {
                    if (par.Logoapp != null)
                    {
                        applogo.Image = Methods.ByteArrayToImage(par.Logoapp);
                        applogo.SizeMode = PictureBoxSizeMode.Zoom;
                        //if (par.Iconapp != null)
                        //{
                        //    System.Drawing.Bitmap bitmap = Methods.ByteArrayToImage(par.Iconapp) as System.Drawing.Bitmap;
                        //    IntPtr ico = bitmap.GetHicon();
                        //    Icon icon = Icon.FromHandle(ico);

                        //    deffrm.Icon = icon;
                        //}
                    }

                }
            }
        }

        private void btnpicklogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Choisire Logo";

                dlg.Filter = "Icon files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    imglogo = new Bitmap(dlg.FileName);
                    applogo.Image = imglogo;
                }
            }
        }
    }
}
