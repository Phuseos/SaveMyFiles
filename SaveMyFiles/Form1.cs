using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Creates full backups of chosen files / folders to a selected location
    Later: Remember backups made and restore when asked
           Repeated backup creation based on schedule
*/

namespace SaveMyFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDiag = new OpenFileDialog();
            
            //Show the dialog 
            DialogResult dRes = ofDiag.ShowDialog();

            string fPath = null;
            string FileName = null;

            if (dRes == DialogResult.OK)
            {
                fPath = ofDiag.FileName;
                FileName = System.IO.Path.GetFileName(ofDiag.FileName);
            }

            //Now that we have the filename and path, load it into the textbox
            txtSelectedFileLocation.Text = fPath;
            txtFileName.Text = FileName;
        }

        private void btnBackupLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDiag = new OpenFileDialog();

            string fPath = null;

            //Show the dialog
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    fPath = fbd.SelectedPath;
                }
                else
                {
                    MessageBox.Show("You have not selected a folder to write the document to.");
                    return;
                }
            }

            //Now that we have the filename and path, load it into the textbox
            txtSelectedBackupLocation.Text = fPath;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelectedFileLocation.Text))
            {
                MessageBox.Show("There's no file to backup selected, do this first.");
                return;
            }
            if (string.IsNullOrEmpty(txtSelectedBackupLocation.Text))
            {
                MessageBox.Show("There's no backup location selected, do this first.");
                return;
            }

            //Now backup the file
            System.IO.File.Copy(txtSelectedFileLocation.Text, txtSelectedBackupLocation.Text + "/" + txtFileName.Text + ".BACKUP");

            MessageBox.Show("File succesfully backed as " + txtSelectedBackupLocation.Text + "/" + txtFileName.Text + ".BACKUP");
        }
    }
}
