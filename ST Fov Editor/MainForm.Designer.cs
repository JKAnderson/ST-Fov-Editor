namespace ST_Fov_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelBin = new System.Windows.Forms.Label();
            this.textBoxBin = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.buttonScanFov = new System.Windows.Forms.Button();
            this.buttonPatchFov = new System.Windows.Forms.Button();
            this.buttonRestoreFov = new System.Windows.Forms.Button();
            this.labelCurrentFov = new System.Windows.Forms.Label();
            this.textBoxCurrentFov = new System.Windows.Forms.TextBox();
            this.numericUpDownDesiredFov = new System.Windows.Forms.NumericUpDown();
            this.labelDesiredFov = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogBin = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxFov = new System.Windows.Forms.GroupBox();
            this.buttonDefaultFov = new System.Windows.Forms.Button();
            this.buttonScanHudFov = new System.Windows.Forms.Button();
            this.buttonPatchHudFov = new System.Windows.Forms.Button();
            this.buttonRestoreHudFov = new System.Windows.Forms.Button();
            this.textBoxCurrentHudFov = new System.Windows.Forms.TextBox();
            this.numericUpDownDesiredHudFov = new System.Windows.Forms.NumericUpDown();
            this.labelDesiredHudFov = new System.Windows.Forms.Label();
            this.labelCurrentHudFov = new System.Windows.Forms.Label();
            this.groupBoxHudFov = new System.Windows.Forms.GroupBox();
            this.buttonDefaultHudFov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredFov)).BeginInit();
            this.groupBoxFov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredHudFov)).BeginInit();
            this.groupBoxHudFov.SuspendLayout();
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
            this.textBoxBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBin.Location = new System.Drawing.Point(12, 25);
            this.textBoxBin.Name = "textBoxBin";
            this.textBoxBin.Size = new System.Drawing.Size(279, 20);
            this.textBoxBin.TabIndex = 1;
            this.textBoxBin.TextChanged += new System.EventHandler(this.textBoxBin_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(297, 23);
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
            this.comboBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Items.AddRange(new object[] {
            "Please select a version..."});
            this.comboBoxVersion.Location = new System.Drawing.Point(12, 64);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(360, 21);
            this.comboBoxVersion.TabIndex = 4;
            this.comboBoxVersion.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersion_SelectedIndexChanged);
            // 
            // buttonScanFov
            // 
            this.buttonScanFov.Location = new System.Drawing.Point(6, 19);
            this.buttonScanFov.Name = "buttonScanFov";
            this.buttonScanFov.Size = new System.Drawing.Size(75, 23);
            this.buttonScanFov.TabIndex = 5;
            this.buttonScanFov.Text = "Scan";
            this.buttonScanFov.UseVisualStyleBackColor = true;
            this.buttonScanFov.Click += new System.EventHandler(this.buttonScanFov_Click);
            // 
            // buttonPatchFov
            // 
            this.buttonPatchFov.Enabled = false;
            this.buttonPatchFov.Location = new System.Drawing.Point(6, 48);
            this.buttonPatchFov.Name = "buttonPatchFov";
            this.buttonPatchFov.Size = new System.Drawing.Size(75, 23);
            this.buttonPatchFov.TabIndex = 6;
            this.buttonPatchFov.Text = "Patch";
            this.buttonPatchFov.UseVisualStyleBackColor = true;
            this.buttonPatchFov.Click += new System.EventHandler(this.buttonPatchFov_Click);
            // 
            // buttonRestoreFov
            // 
            this.buttonRestoreFov.Location = new System.Drawing.Point(6, 77);
            this.buttonRestoreFov.Name = "buttonRestoreFov";
            this.buttonRestoreFov.Size = new System.Drawing.Size(100, 23);
            this.buttonRestoreFov.TabIndex = 7;
            this.buttonRestoreFov.Text = "Restore Backup";
            this.buttonRestoreFov.UseVisualStyleBackColor = true;
            this.buttonRestoreFov.Click += new System.EventHandler(this.buttonRestoreFov_Click);
            // 
            // labelCurrentFov
            // 
            this.labelCurrentFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentFov.AutoSize = true;
            this.labelCurrentFov.Location = new System.Drawing.Point(181, 24);
            this.labelCurrentFov.Name = "labelCurrentFov";
            this.labelCurrentFov.Size = new System.Drawing.Size(115, 13);
            this.labelCurrentFov.TabIndex = 8;
            this.labelCurrentFov.Text = "Current Horizontal Fov:";
            // 
            // textBoxCurrentFov
            // 
            this.textBoxCurrentFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentFov.Location = new System.Drawing.Point(304, 21);
            this.textBoxCurrentFov.Name = "textBoxCurrentFov";
            this.textBoxCurrentFov.ReadOnly = true;
            this.textBoxCurrentFov.Size = new System.Drawing.Size(50, 20);
            this.textBoxCurrentFov.TabIndex = 9;
            // 
            // numericUpDownDesiredFov
            // 
            this.numericUpDownDesiredFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDesiredFov.DecimalPlaces = 1;
            this.numericUpDownDesiredFov.Location = new System.Drawing.Point(304, 51);
            this.numericUpDownDesiredFov.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownDesiredFov.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDesiredFov.Name = "numericUpDownDesiredFov";
            this.numericUpDownDesiredFov.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDesiredFov.TabIndex = 10;
            this.numericUpDownDesiredFov.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelDesiredFov
            // 
            this.labelDesiredFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesiredFov.AutoSize = true;
            this.labelDesiredFov.Location = new System.Drawing.Point(181, 53);
            this.labelDesiredFov.Name = "labelDesiredFov";
            this.labelDesiredFov.Size = new System.Drawing.Size(117, 13);
            this.labelDesiredFov.TabIndex = 11;
            this.labelDesiredFov.Text = "Desired Horizontal Fov:";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(12, 312);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(25, 13);
            this.labelLog.TabIndex = 16;
            this.labelLog.Text = "Info";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(12, 328);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(360, 126);
            this.textBoxLog.TabIndex = 17;
            // 
            // folderBrowserDialogBin
            // 
            this.folderBrowserDialogBin.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogBin.ShowNewFolderButton = false;
            // 
            // groupBoxFov
            // 
            this.groupBoxFov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFov.Controls.Add(this.buttonDefaultFov);
            this.groupBoxFov.Controls.Add(this.buttonScanFov);
            this.groupBoxFov.Controls.Add(this.buttonPatchFov);
            this.groupBoxFov.Controls.Add(this.buttonRestoreFov);
            this.groupBoxFov.Controls.Add(this.textBoxCurrentFov);
            this.groupBoxFov.Controls.Add(this.numericUpDownDesiredFov);
            this.groupBoxFov.Controls.Add(this.labelDesiredFov);
            this.groupBoxFov.Controls.Add(this.labelCurrentFov);
            this.groupBoxFov.Location = new System.Drawing.Point(12, 91);
            this.groupBoxFov.Name = "groupBoxFov";
            this.groupBoxFov.Size = new System.Drawing.Size(360, 106);
            this.groupBoxFov.TabIndex = 18;
            this.groupBoxFov.TabStop = false;
            this.groupBoxFov.Text = "Field of View";
            // 
            // buttonDefaultFov
            // 
            this.buttonDefaultFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultFov.Location = new System.Drawing.Point(279, 77);
            this.buttonDefaultFov.Name = "buttonDefaultFov";
            this.buttonDefaultFov.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultFov.TabIndex = 12;
            this.buttonDefaultFov.Text = "Default";
            this.buttonDefaultFov.UseVisualStyleBackColor = true;
            this.buttonDefaultFov.Click += new System.EventHandler(this.buttonDefaultFov_Click);
            // 
            // buttonScanHudFov
            // 
            this.buttonScanHudFov.Location = new System.Drawing.Point(6, 19);
            this.buttonScanHudFov.Name = "buttonScanHudFov";
            this.buttonScanHudFov.Size = new System.Drawing.Size(75, 23);
            this.buttonScanHudFov.TabIndex = 5;
            this.buttonScanHudFov.Text = "Scan";
            this.buttonScanHudFov.UseVisualStyleBackColor = true;
            this.buttonScanHudFov.Click += new System.EventHandler(this.buttonScanHudFov_Click);
            // 
            // buttonPatchHudFov
            // 
            this.buttonPatchHudFov.Enabled = false;
            this.buttonPatchHudFov.Location = new System.Drawing.Point(6, 48);
            this.buttonPatchHudFov.Name = "buttonPatchHudFov";
            this.buttonPatchHudFov.Size = new System.Drawing.Size(75, 23);
            this.buttonPatchHudFov.TabIndex = 6;
            this.buttonPatchHudFov.Text = "Patch";
            this.buttonPatchHudFov.UseVisualStyleBackColor = true;
            this.buttonPatchHudFov.Click += new System.EventHandler(this.buttonPatchHudFov_Click);
            // 
            // buttonRestoreHudFov
            // 
            this.buttonRestoreHudFov.Location = new System.Drawing.Point(6, 77);
            this.buttonRestoreHudFov.Name = "buttonRestoreHudFov";
            this.buttonRestoreHudFov.Size = new System.Drawing.Size(100, 23);
            this.buttonRestoreHudFov.TabIndex = 7;
            this.buttonRestoreHudFov.Text = "Restore Backup";
            this.buttonRestoreHudFov.UseVisualStyleBackColor = true;
            this.buttonRestoreHudFov.Click += new System.EventHandler(this.buttonRestoreHudFov_Click);
            // 
            // textBoxCurrentHudFov
            // 
            this.textBoxCurrentHudFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentHudFov.Location = new System.Drawing.Point(304, 21);
            this.textBoxCurrentHudFov.Name = "textBoxCurrentHudFov";
            this.textBoxCurrentHudFov.ReadOnly = true;
            this.textBoxCurrentHudFov.Size = new System.Drawing.Size(50, 20);
            this.textBoxCurrentHudFov.TabIndex = 9;
            // 
            // numericUpDownDesiredHudFov
            // 
            this.numericUpDownDesiredHudFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDesiredHudFov.DecimalPlaces = 2;
            this.numericUpDownDesiredHudFov.Location = new System.Drawing.Point(304, 51);
            this.numericUpDownDesiredHudFov.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDesiredHudFov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDesiredHudFov.Name = "numericUpDownDesiredHudFov";
            this.numericUpDownDesiredHudFov.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDesiredHudFov.TabIndex = 10;
            this.numericUpDownDesiredHudFov.Value = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            // 
            // labelDesiredHudFov
            // 
            this.labelDesiredHudFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesiredHudFov.AutoSize = true;
            this.labelDesiredHudFov.Location = new System.Drawing.Point(181, 53);
            this.labelDesiredHudFov.Name = "labelDesiredHudFov";
            this.labelDesiredHudFov.Size = new System.Drawing.Size(94, 13);
            this.labelDesiredHudFov.TabIndex = 11;
            this.labelDesiredHudFov.Text = "Desired HUD Fov:";
            // 
            // labelCurrentHudFov
            // 
            this.labelCurrentHudFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentHudFov.AutoSize = true;
            this.labelCurrentHudFov.Location = new System.Drawing.Point(181, 24);
            this.labelCurrentHudFov.Name = "labelCurrentHudFov";
            this.labelCurrentHudFov.Size = new System.Drawing.Size(92, 13);
            this.labelCurrentHudFov.TabIndex = 8;
            this.labelCurrentHudFov.Text = "Current HUD Fov:";
            // 
            // groupBoxHudFov
            // 
            this.groupBoxHudFov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHudFov.Controls.Add(this.buttonDefaultHudFov);
            this.groupBoxHudFov.Controls.Add(this.buttonScanHudFov);
            this.groupBoxHudFov.Controls.Add(this.buttonPatchHudFov);
            this.groupBoxHudFov.Controls.Add(this.buttonRestoreHudFov);
            this.groupBoxHudFov.Controls.Add(this.textBoxCurrentHudFov);
            this.groupBoxHudFov.Controls.Add(this.numericUpDownDesiredHudFov);
            this.groupBoxHudFov.Controls.Add(this.labelDesiredHudFov);
            this.groupBoxHudFov.Controls.Add(this.labelCurrentHudFov);
            this.groupBoxHudFov.Location = new System.Drawing.Point(12, 203);
            this.groupBoxHudFov.Name = "groupBoxHudFov";
            this.groupBoxHudFov.Size = new System.Drawing.Size(360, 106);
            this.groupBoxHudFov.TabIndex = 19;
            this.groupBoxHudFov.TabStop = false;
            this.groupBoxHudFov.Text = "HUD Fov";
            // 
            // buttonDefaultHudFov
            // 
            this.buttonDefaultHudFov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultHudFov.Location = new System.Drawing.Point(279, 77);
            this.buttonDefaultHudFov.Name = "buttonDefaultHudFov";
            this.buttonDefaultHudFov.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultHudFov.TabIndex = 12;
            this.buttonDefaultHudFov.Text = "Default";
            this.buttonDefaultHudFov.UseVisualStyleBackColor = true;
            this.buttonDefaultHudFov.Click += new System.EventHandler(this.buttonDefaultHudFov_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 466);
            this.Controls.Add(this.groupBoxHudFov);
            this.Controls.Add(this.groupBoxFov);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.comboBoxVersion);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxBin);
            this.Controls.Add(this.labelBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "MainForm";
            this.Text = "ST Fov Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredFov)).EndInit();
            this.groupBoxFov.ResumeLayout(false);
            this.groupBoxFov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesiredHudFov)).EndInit();
            this.groupBoxHudFov.ResumeLayout(false);
            this.groupBoxHudFov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBin;
        private System.Windows.Forms.TextBox textBoxBin;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.Button buttonScanFov;
        private System.Windows.Forms.Button buttonPatchFov;
        private System.Windows.Forms.Button buttonRestoreFov;
        private System.Windows.Forms.Label labelCurrentFov;
        private System.Windows.Forms.TextBox textBoxCurrentFov;
        private System.Windows.Forms.NumericUpDown numericUpDownDesiredFov;
        private System.Windows.Forms.Label labelDesiredFov;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBin;
        private System.Windows.Forms.GroupBox groupBoxFov;
        private System.Windows.Forms.Button buttonScanHudFov;
        private System.Windows.Forms.Button buttonPatchHudFov;
        private System.Windows.Forms.Button buttonRestoreHudFov;
        private System.Windows.Forms.TextBox textBoxCurrentHudFov;
        private System.Windows.Forms.NumericUpDown numericUpDownDesiredHudFov;
        private System.Windows.Forms.Label labelDesiredHudFov;
        private System.Windows.Forms.Label labelCurrentHudFov;
        private System.Windows.Forms.GroupBox groupBoxHudFov;
        private System.Windows.Forms.Button buttonDefaultFov;
        private System.Windows.Forms.Button buttonDefaultHudFov;
    }
}

