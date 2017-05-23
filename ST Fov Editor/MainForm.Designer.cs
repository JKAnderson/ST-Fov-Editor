﻿namespace ST_Fov_Editor
{
    partial class MainForm
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
            this.labelBin = new System.Windows.Forms.Label();
            this.textBoxBin = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.labelCurrentHFov = new System.Windows.Forms.Label();
            this.textBoxCurrentHFov = new System.Windows.Forms.TextBox();
            this.numericUpDownDesiredHFov = new System.Windows.Forms.NumericUpDown();
            this.labelDesiredHFov = new System.Windows.Forms.Label();
            this.labelCurrentVFov = new System.Windows.Forms.Label();
            this.labelDesiredVFov = new System.Windows.Forms.Label();
            this.numericUpDownDesiredVFov = new System.Windows.Forms.NumericUpDown();
            this.textBoxCurrentVFov = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogBin = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredHFov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredVFov)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBin
            // 
            this.labelBin.AutoSize = true;
            this.labelBin.Location = new System.Drawing.Point(12, 9);
            this.labelBin.Name = "labelBin";
            this.labelBin.Size = new System.Drawing.Size(51, 13);
            this.labelBin.TabIndex = 0;
            this.labelBin.Text = "Bin folder";
            // 
            // textBoxBin
            // 
            this.textBoxBin.Location = new System.Drawing.Point(12, 25);
            this.textBoxBin.Name = "textBoxBin";
            this.textBoxBin.Size = new System.Drawing.Size(267, 20);
            this.textBoxBin.TabIndex = 1;
            this.textBoxBin.TextChanged += new System.EventHandler(this.textBoxBin_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(285, 23);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 48);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(72, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Game version";
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Items.AddRange(new object[] {
            "Please select a version...",
            "Shadow of Chernobyl (1.0004)",
            "Shadow of Chernobyl (1.0005)",
            "Shadow of Chernobyl (1.0006)",
            "Clear Sky (1.5.10)",
            "Call of Pripyat (1.6.02)"});
            this.comboBoxVersion.Location = new System.Drawing.Point(12, 64);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(348, 21);
            this.comboBoxVersion.TabIndex = 4;
            this.comboBoxVersion.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersion_SelectedIndexChanged);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(12, 91);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 5;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonPatch
            // 
            this.buttonPatch.Enabled = false;
            this.buttonPatch.Location = new System.Drawing.Point(12, 120);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(75, 23);
            this.buttonPatch.TabIndex = 6;
            this.buttonPatch.Text = "Patch";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonPatch_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(12, 149);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(100, 23);
            this.buttonRestore.TabIndex = 7;
            this.buttonRestore.Text = "Restore Backup";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // labelCurrentHFov
            // 
            this.labelCurrentHFov.AutoSize = true;
            this.labelCurrentHFov.Location = new System.Drawing.Point(93, 96);
            this.labelCurrentHFov.Name = "labelCurrentHFov";
            this.labelCurrentHFov.Size = new System.Drawing.Size(73, 13);
            this.labelCurrentHFov.TabIndex = 8;
            this.labelCurrentHFov.Text = "Current HFov:";
            // 
            // textBoxCurrentHFov
            // 
            this.textBoxCurrentHFov.Location = new System.Drawing.Point(174, 94);
            this.textBoxCurrentHFov.Name = "textBoxCurrentHFov";
            this.textBoxCurrentHFov.ReadOnly = true;
            this.textBoxCurrentHFov.Size = new System.Drawing.Size(50, 20);
            this.textBoxCurrentHFov.TabIndex = 9;
            // 
            // numericUpDownDesiredHFov
            // 
            this.numericUpDownDesiredHFov.Location = new System.Drawing.Point(174, 123);
            this.numericUpDownDesiredHFov.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownDesiredHFov.Name = "numericUpDownDesiredHFov";
            this.numericUpDownDesiredHFov.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDesiredHFov.TabIndex = 10;
            // 
            // labelDesiredHFov
            // 
            this.labelDesiredHFov.AutoSize = true;
            this.labelDesiredHFov.Location = new System.Drawing.Point(93, 125);
            this.labelDesiredHFov.Name = "labelDesiredHFov";
            this.labelDesiredHFov.Size = new System.Drawing.Size(75, 13);
            this.labelDesiredHFov.TabIndex = 11;
            this.labelDesiredHFov.Text = "Desired HFov:";
            // 
            // labelCurrentVFov
            // 
            this.labelCurrentVFov.AutoSize = true;
            this.labelCurrentVFov.Location = new System.Drawing.Point(230, 97);
            this.labelCurrentVFov.Name = "labelCurrentVFov";
            this.labelCurrentVFov.Size = new System.Drawing.Size(72, 13);
            this.labelCurrentVFov.TabIndex = 12;
            this.labelCurrentVFov.Text = "Current VFov:";
            this.labelCurrentVFov.Visible = false;
            // 
            // labelDesiredVFov
            // 
            this.labelDesiredVFov.AutoSize = true;
            this.labelDesiredVFov.Location = new System.Drawing.Point(230, 125);
            this.labelDesiredVFov.Name = "labelDesiredVFov";
            this.labelDesiredVFov.Size = new System.Drawing.Size(74, 13);
            this.labelDesiredVFov.TabIndex = 13;
            this.labelDesiredVFov.Text = "Desired VFov:";
            this.labelDesiredVFov.Visible = false;
            // 
            // numericUpDownDesiredVFov
            // 
            this.numericUpDownDesiredVFov.Location = new System.Drawing.Point(310, 123);
            this.numericUpDownDesiredVFov.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownDesiredVFov.Name = "numericUpDownDesiredVFov";
            this.numericUpDownDesiredVFov.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDesiredVFov.TabIndex = 15;
            this.numericUpDownDesiredVFov.Visible = false;
            // 
            // textBoxCurrentVFov
            // 
            this.textBoxCurrentVFov.Location = new System.Drawing.Point(310, 94);
            this.textBoxCurrentVFov.Name = "textBoxCurrentVFov";
            this.textBoxCurrentVFov.ReadOnly = true;
            this.textBoxCurrentVFov.Size = new System.Drawing.Size(50, 20);
            this.textBoxCurrentVFov.TabIndex = 14;
            this.textBoxCurrentVFov.Visible = false;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(12, 175);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(25, 13);
            this.labelLog.TabIndex = 16;
            this.labelLog.Text = "Info";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 191);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(348, 100);
            this.textBoxLog.TabIndex = 17;
            // 
            // folderBrowserDialogBin
            // 
            this.folderBrowserDialogBin.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogBin.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 302);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.numericUpDownDesiredVFov);
            this.Controls.Add(this.textBoxCurrentVFov);
            this.Controls.Add(this.labelDesiredVFov);
            this.Controls.Add(this.labelCurrentVFov);
            this.Controls.Add(this.labelDesiredHFov);
            this.Controls.Add(this.numericUpDownDesiredHFov);
            this.Controls.Add(this.textBoxCurrentHFov);
            this.Controls.Add(this.labelCurrentHFov);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.comboBoxVersion);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxBin);
            this.Controls.Add(this.labelBin);
            this.Name = "MainForm";
            this.Text = "ST Fov Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredHFov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredVFov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBin;
        private System.Windows.Forms.TextBox textBoxBin;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonPatch;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Label labelCurrentHFov;
        private System.Windows.Forms.TextBox textBoxCurrentHFov;
        private System.Windows.Forms.NumericUpDown numericUpDownDesiredHFov;
        private System.Windows.Forms.Label labelDesiredHFov;
        private System.Windows.Forms.Label labelCurrentVFov;
        private System.Windows.Forms.Label labelDesiredVFov;
        private System.Windows.Forms.NumericUpDown numericUpDownDesiredVFov;
        private System.Windows.Forms.TextBox textBoxCurrentVFov;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBin;
    }
}
