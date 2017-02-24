namespace SaveMyFiles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIntro_NonEnable = new System.Windows.Forms.TextBox();
            this.btnFileBackup = new System.Windows.Forms.Button();
            this.txtSelectedFileLocation = new System.Windows.Forms.TextBox();
            this.lblNo_Interact_FileLocation = new System.Windows.Forms.Label();
            this.btnBackupLocation = new System.Windows.Forms.Button();
            this.lblNo_Interact_BackupLocation = new System.Windows.Forms.Label();
            this.txtSelectedBackupLocation = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIntro_NonEnable
            // 
            this.txtIntro_NonEnable.BackColor = System.Drawing.Color.White;
            this.txtIntro_NonEnable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntro_NonEnable.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIntro_NonEnable.Enabled = false;
            this.txtIntro_NonEnable.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntro_NonEnable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIntro_NonEnable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtIntro_NonEnable.Location = new System.Drawing.Point(13, 13);
            this.txtIntro_NonEnable.Name = "txtIntro_NonEnable";
            this.txtIntro_NonEnable.Size = new System.Drawing.Size(958, 41);
            this.txtIntro_NonEnable.TabIndex = 0;
            this.txtIntro_NonEnable.Text = "Welcome to Save My Files! Press the button below to begin.";
            this.txtIntro_NonEnable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFileBackup
            // 
            this.btnFileBackup.Location = new System.Drawing.Point(99, 103);
            this.btnFileBackup.Name = "btnFileBackup";
            this.btnFileBackup.Size = new System.Drawing.Size(147, 43);
            this.btnFileBackup.TabIndex = 1;
            this.btnFileBackup.Text = "Select file to backup ";
            this.btnFileBackup.UseVisualStyleBackColor = true;
            this.btnFileBackup.Click += new System.EventHandler(this.btnFileBackup_Click);
            // 
            // txtSelectedFileLocation
            // 
            this.txtSelectedFileLocation.Location = new System.Drawing.Point(329, 121);
            this.txtSelectedFileLocation.Name = "txtSelectedFileLocation";
            this.txtSelectedFileLocation.Size = new System.Drawing.Size(520, 20);
            this.txtSelectedFileLocation.TabIndex = 2;
            // 
            // lblNo_Interact_FileLocation
            // 
            this.lblNo_Interact_FileLocation.AutoSize = true;
            this.lblNo_Interact_FileLocation.Location = new System.Drawing.Point(329, 103);
            this.lblNo_Interact_FileLocation.Name = "lblNo_Interact_FileLocation";
            this.lblNo_Interact_FileLocation.Size = new System.Drawing.Size(65, 13);
            this.lblNo_Interact_FileLocation.TabIndex = 3;
            this.lblNo_Interact_FileLocation.Text = "Selected file";
            // 
            // btnBackupLocation
            // 
            this.btnBackupLocation.Location = new System.Drawing.Point(99, 175);
            this.btnBackupLocation.Name = "btnBackupLocation";
            this.btnBackupLocation.Size = new System.Drawing.Size(147, 43);
            this.btnBackupLocation.TabIndex = 4;
            this.btnBackupLocation.Text = "Select backup location";
            this.btnBackupLocation.UseVisualStyleBackColor = true;
            this.btnBackupLocation.Click += new System.EventHandler(this.btnBackupLocation_Click);
            // 
            // lblNo_Interact_BackupLocation
            // 
            this.lblNo_Interact_BackupLocation.AutoSize = true;
            this.lblNo_Interact_BackupLocation.Location = new System.Drawing.Point(329, 175);
            this.lblNo_Interact_BackupLocation.Name = "lblNo_Interact_BackupLocation";
            this.lblNo_Interact_BackupLocation.Size = new System.Drawing.Size(84, 13);
            this.lblNo_Interact_BackupLocation.TabIndex = 6;
            this.lblNo_Interact_BackupLocation.Text = "Backup location";
            // 
            // txtSelectedBackupLocation
            // 
            this.txtSelectedBackupLocation.Location = new System.Drawing.Point(329, 193);
            this.txtSelectedBackupLocation.Name = "txtSelectedBackupLocation";
            this.txtSelectedBackupLocation.Size = new System.Drawing.Size(520, 20);
            this.txtSelectedBackupLocation.TabIndex = 5;
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(329, 272);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(279, 83);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Save My Files!";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(329, 148);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 8;
            this.txtFileName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 448);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblNo_Interact_BackupLocation);
            this.Controls.Add(this.txtSelectedBackupLocation);
            this.Controls.Add(this.btnBackupLocation);
            this.Controls.Add(this.lblNo_Interact_FileLocation);
            this.Controls.Add(this.txtSelectedFileLocation);
            this.Controls.Add(this.btnFileBackup);
            this.Controls.Add(this.txtIntro_NonEnable);
            this.Name = "Form1";
            this.Text = "Save My Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntro_NonEnable;
        private System.Windows.Forms.Button btnFileBackup;
        private System.Windows.Forms.TextBox txtSelectedFileLocation;
        private System.Windows.Forms.Label lblNo_Interact_FileLocation;
        private System.Windows.Forms.Button btnBackupLocation;
        private System.Windows.Forms.Label lblNo_Interact_BackupLocation;
        private System.Windows.Forms.TextBox txtSelectedBackupLocation;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtFileName;
    }
}

