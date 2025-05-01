namespace BrgyMS.uiDesign.usersDashboard.modals {
    partial class RequestDocumentsModalCotntrol {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pnlMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            cbFirstTimeJobSeeker = new Krypton.Toolkit.KryptonCheckBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            cboPurposes = new Krypton.Toolkit.KryptonComboBox();
            cboDocsType = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnSubmitRequest = new Krypton.Toolkit.KryptonButton();
            btnSaveChanges = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentHolder).BeginInit();
            pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboPurposes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboDocsType).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(pnlMainContentHolder);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(370, 670);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // pnlMainContentHolder
            // 
            pnlMainContentHolder.AutoScroll = true;
            pnlMainContentHolder.Controls.Add(kryptonTextBox1);
            pnlMainContentHolder.Controls.Add(cbFirstTimeJobSeeker);
            pnlMainContentHolder.Controls.Add(kryptonLabel4);
            pnlMainContentHolder.Controls.Add(cboPurposes);
            pnlMainContentHolder.Controls.Add(cboDocsType);
            pnlMainContentHolder.Controls.Add(kryptonLabel3);
            pnlMainContentHolder.Controls.Add(kryptonLabel2);
            pnlMainContentHolder.Controls.Add(kryptonLabel1);
            pnlMainContentHolder.Controls.Add(btnSubmitRequest);
            pnlMainContentHolder.Controls.Add(btnSaveChanges);
            pnlMainContentHolder.Location = new Point(3, 0);
            pnlMainContentHolder.Name = "pnlMainContentHolder";
            pnlMainContentHolder.Size = new Size(367, 670);
            pnlMainContentHolder.StateCommon.Color1 = Color.White;
            pnlMainContentHolder.TabIndex = 12;
            // 
            // cbFirstTimeJobSeeker
            // 
            cbFirstTimeJobSeeker.AutoSize = false;
            cbFirstTimeJobSeeker.Enabled = false;
            cbFirstTimeJobSeeker.Location = new Point(0, 541);
            cbFirstTimeJobSeeker.Name = "cbFirstTimeJobSeeker";
            cbFirstTimeJobSeeker.Size = new Size(349, 38);
            cbFirstTimeJobSeeker.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFirstTimeJobSeeker.TabIndex = 42;
            cbFirstTimeJobSeeker.Values.Text = "Yes";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(0, 490);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(256, 33);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 41;
            kryptonLabel4.Values.Text = "First Time Job Seeker";
            // 
            // cboPurposes
            // 
            cboPurposes.DropDownWidth = 428;
            cboPurposes.Enabled = false;
            cboPurposes.Items.AddRange(new object[] { "--Select--" });
            cboPurposes.Location = new Point(6, 250);
            cboPurposes.Name = "cboPurposes";
            cboPurposes.Size = new Size(349, 25);
            cboPurposes.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F);
            cboPurposes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboPurposes.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboPurposes.StateNormal.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboPurposes.TabIndex = 40;
            cboPurposes.SelectedIndexChanged += cboPurposes_SelectedIndexChanged;
            // 
            // cboDocsType
            // 
            cboDocsType.DropDownWidth = 428;
            cboDocsType.Items.AddRange(new object[] { "Barangay Certificate of Indigency", "Barangay Clearance" });
            cboDocsType.Location = new Point(6, 150);
            cboDocsType.Name = "cboDocsType";
            cboDocsType.Size = new Size(349, 25);
            cboDocsType.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F);
            cboDocsType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboDocsType.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboDocsType.StateNormal.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboDocsType.TabIndex = 19;
            cboDocsType.SelectedValueChanged += cboDocsType_SelectedValueChanged;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(6, 111);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(189, 33);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 18;
            kryptonLabel3.Values.Text = "Document Type";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(63, 3);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(238, 33);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Request Documents";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(6, 198);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(107, 33);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 17;
            kryptonLabel1.Values.Text = "Purpose";
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(89, 616);
            btnSubmitRequest.Margin = new Padding(4, 3, 4, 3);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.OverrideDefault.Back.ColorAngle = 45F;
            btnSubmitRequest.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSubmitRequest.OverrideDefault.Border.Rounding = 5F;
            btnSubmitRequest.OverrideDefault.Border.Width = 1;
            btnSubmitRequest.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnSubmitRequest.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnSubmitRequest.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSubmitRequest.Size = new Size(187, 51);
            btnSubmitRequest.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateCommon.Back.ColorAngle = 45F;
            btnSubmitRequest.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSubmitRequest.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnSubmitRequest.StateCommon.Border.ColorAngle = 45F;
            btnSubmitRequest.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSubmitRequest.StateCommon.Border.Rounding = 5F;
            btnSubmitRequest.StateCommon.Border.Width = 1;
            btnSubmitRequest.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSubmitRequest.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSubmitRequest.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRequest.StateDisabled.Border.Rounding = 5F;
            btnSubmitRequest.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateNormal.Border.Rounding = 5F;
            btnSubmitRequest.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSubmitRequest.StateNormal.Content.ShortText.Color2 = Color.White;
            btnSubmitRequest.StatePressed.Back.Color1 = Color.White;
            btnSubmitRequest.StatePressed.Back.Color2 = Color.White;
            btnSubmitRequest.StatePressed.Back.ColorAngle = 130F;
            btnSubmitRequest.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnSubmitRequest.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnSubmitRequest.StatePressed.Border.ColorAngle = 130F;
            btnSubmitRequest.StatePressed.Border.Rounding = 5F;
            btnSubmitRequest.StatePressed.Border.Width = 1;
            btnSubmitRequest.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnSubmitRequest.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnSubmitRequest.StateTracking.Back.ColorAngle = 45F;
            btnSubmitRequest.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSubmitRequest.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateTracking.Border.ColorAngle = 45F;
            btnSubmitRequest.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSubmitRequest.StateTracking.Border.Rounding = 5F;
            btnSubmitRequest.StateTracking.Border.Width = 1;
            btnSubmitRequest.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitRequest.TabIndex = 38;
            btnSubmitRequest.Values.DropDownArrowColor = Color.Empty;
            btnSubmitRequest.Values.Text = "Submit";
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(89, 616);
            btnSaveChanges.Margin = new Padding(4, 3, 4, 3);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.OverrideDefault.Back.ColorAngle = 45F;
            btnSaveChanges.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSaveChanges.OverrideDefault.Border.Rounding = 5F;
            btnSaveChanges.OverrideDefault.Border.Width = 1;
            btnSaveChanges.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnSaveChanges.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnSaveChanges.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSaveChanges.Size = new Size(187, 51);
            btnSaveChanges.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateCommon.Back.ColorAngle = 45F;
            btnSaveChanges.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSaveChanges.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnSaveChanges.StateCommon.Border.ColorAngle = 45F;
            btnSaveChanges.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSaveChanges.StateCommon.Border.Rounding = 5F;
            btnSaveChanges.StateCommon.Border.Width = 1;
            btnSaveChanges.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSaveChanges.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSaveChanges.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.StateDisabled.Border.Rounding = 5F;
            btnSaveChanges.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateNormal.Border.Rounding = 5F;
            btnSaveChanges.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSaveChanges.StateNormal.Content.ShortText.Color2 = Color.White;
            btnSaveChanges.StatePressed.Back.Color1 = Color.White;
            btnSaveChanges.StatePressed.Back.Color2 = Color.White;
            btnSaveChanges.StatePressed.Back.ColorAngle = 130F;
            btnSaveChanges.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnSaveChanges.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnSaveChanges.StatePressed.Border.ColorAngle = 130F;
            btnSaveChanges.StatePressed.Border.Rounding = 5F;
            btnSaveChanges.StatePressed.Border.Width = 1;
            btnSaveChanges.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnSaveChanges.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnSaveChanges.StateTracking.Back.ColorAngle = 45F;
            btnSaveChanges.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSaveChanges.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateTracking.Border.ColorAngle = 45F;
            btnSaveChanges.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSaveChanges.StateTracking.Border.Rounding = 5F;
            btnSaveChanges.StateTracking.Border.Width = 1;
            btnSaveChanges.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSaveChanges.TabIndex = 39;
            btnSaveChanges.Values.DropDownArrowColor = Color.Empty;
            btnSaveChanges.Values.Text = "Save Changes";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(13, 310);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(100, 23);
            kryptonTextBox1.TabIndex = 43;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // RequestDocumentsModalCotntrol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "RequestDocumentsModalCotntrol";
            Size = new Size(370, 670);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlMainContentHolder).EndInit();
            pnlMainContentHolder.ResumeLayout(false);
            pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboPurposes).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboDocsType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cboDocsType;
        private Krypton.Toolkit.KryptonButton btnSubmitRequest;
        private Krypton.Toolkit.KryptonButton btnSaveChanges;
        private Krypton.Toolkit.KryptonComboBox cboPurposes;
        private Krypton.Toolkit.KryptonCheckBox cbFirstTimeJobSeeker;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}
