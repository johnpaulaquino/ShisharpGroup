using System.Drawing;
using System.Windows.Forms;

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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.pnlMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtOtherPurpose = new Krypton.Toolkit.KryptonTextBox();
            this.cbFirstTimeJobSeeker = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.cboPurposes = new Krypton.Toolkit.KryptonComboBox();
            this.cboDocsType = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSaveChanges = new Krypton.Toolkit.KryptonButton();
            this.btnSubmitRequest = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).BeginInit();
            this.pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPurposes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDocsType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(this.pnlMainContentHolder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(317, 581);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pnlMainContentHolder
            // 
            this.pnlMainContentHolder.AutoScroll = true;
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel5);
            this.pnlMainContentHolder.Controls.Add(this.txtOtherPurpose);
            this.pnlMainContentHolder.Controls.Add(this.cbFirstTimeJobSeeker);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel4);
            this.pnlMainContentHolder.Controls.Add(this.cboPurposes);
            this.pnlMainContentHolder.Controls.Add(this.cboDocsType);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel3);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel2);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel1);
            this.pnlMainContentHolder.Controls.Add(this.btnSubmitRequest);
            this.pnlMainContentHolder.Controls.Add(this.btnSaveChanges);
            this.pnlMainContentHolder.Location = new System.Drawing.Point(3, 0);
            this.pnlMainContentHolder.Name = "pnlMainContentHolder";
            this.pnlMainContentHolder.Size = new System.Drawing.Size(315, 581);
            this.pnlMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentHolder.TabIndex = 12;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 258);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(175, 33);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 44;
            this.kryptonLabel5.Values.Text = "Other Purpose";
            // 
            // txtOtherPurpose
            // 
            this.txtOtherPurpose.Location = new System.Drawing.Point(5, 292);
            this.txtOtherPurpose.Multiline = true;
            this.txtOtherPurpose.Name = "txtOtherPurpose";
            this.txtOtherPurpose.ReadOnly = true;
            this.txtOtherPurpose.Size = new System.Drawing.Size(299, 119);
            this.txtOtherPurpose.TabIndex = 43;
            // 
            // cbFirstTimeJobSeeker
            // 
            this.cbFirstTimeJobSeeker.AutoSize = false;
            this.cbFirstTimeJobSeeker.Enabled = false;
            this.cbFirstTimeJobSeeker.Location = new System.Drawing.Point(0, 469);
            this.cbFirstTimeJobSeeker.Name = "cbFirstTimeJobSeeker";
            this.cbFirstTimeJobSeeker.Size = new System.Drawing.Size(299, 33);
            this.cbFirstTimeJobSeeker.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFirstTimeJobSeeker.TabIndex = 42;
            this.cbFirstTimeJobSeeker.Values.Text = "Yes";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(0, 425);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(256, 33);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 41;
            this.kryptonLabel4.Values.Text = "First Time Job Seeker";
            // 
            // cboPurposes
            // 
            this.cboPurposes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPurposes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPurposes.DropDownWidth = 428;
            this.cboPurposes.Enabled = false;
            this.cboPurposes.Items.AddRange(new object[] {
            "--Select--"});
            this.cboPurposes.Location = new System.Drawing.Point(5, 217);
            this.cboPurposes.Name = "cboPurposes";
            this.cboPurposes.Size = new System.Drawing.Size(299, 25);
            this.cboPurposes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPurposes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboPurposes.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPurposes.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPurposes.TabIndex = 40;
            this.cboPurposes.SelectedValueChanged += new System.EventHandler(this.cboPurposes_SelectedValueChanged);
            // 
            // cboDocsType
            // 
            this.cboDocsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDocsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDocsType.DropDownWidth = 428;
            this.cboDocsType.Items.AddRange(new object[] {
            "Barangay Certificate of Indigency",
            "Barangay Clearance"});
            this.cboDocsType.Location = new System.Drawing.Point(5, 130);
            this.cboDocsType.Name = "cboDocsType";
            this.cboDocsType.Size = new System.Drawing.Size(299, 25);
            this.cboDocsType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDocsType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboDocsType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDocsType.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDocsType.TabIndex = 19;
            this.cboDocsType.SelectedValueChanged += new System.EventHandler(this.cboDocsType_SelectedValueChanged_1);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 96);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(189, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Document Type";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(54, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(238, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Request Documents";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 172);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Purpose";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(76, 534);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSaveChanges.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveChanges.OverrideDefault.Border.Rounding = 5F;
            this.btnSaveChanges.OverrideDefault.Border.Width = 1;
            this.btnSaveChanges.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveChanges.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveChanges.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSaveChanges.Size = new System.Drawing.Size(160, 44);
            this.btnSaveChanges.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateCommon.Back.ColorAngle = 45F;
            this.btnSaveChanges.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveChanges.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveChanges.StateCommon.Border.ColorAngle = 45F;
            this.btnSaveChanges.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveChanges.StateCommon.Border.Rounding = 5F;
            this.btnSaveChanges.StateCommon.Border.Width = 1;
            this.btnSaveChanges.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveChanges.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveChanges.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.StateDisabled.Border.Rounding = 5F;
            this.btnSaveChanges.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateNormal.Border.Rounding = 5F;
            this.btnSaveChanges.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSaveChanges.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSaveChanges.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSaveChanges.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSaveChanges.StatePressed.Back.ColorAngle = 130F;
            this.btnSaveChanges.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSaveChanges.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSaveChanges.StatePressed.Border.ColorAngle = 130F;
            this.btnSaveChanges.StatePressed.Border.Rounding = 5F;
            this.btnSaveChanges.StatePressed.Border.Width = 1;
            this.btnSaveChanges.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnSaveChanges.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSaveChanges.StateTracking.Back.ColorAngle = 45F;
            this.btnSaveChanges.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSaveChanges.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateTracking.Border.ColorAngle = 45F;
            this.btnSaveChanges.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSaveChanges.StateTracking.Border.Rounding = 5F;
            this.btnSaveChanges.StateTracking.Border.Width = 1;
            this.btnSaveChanges.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSaveChanges.TabIndex = 39;
            this.btnSaveChanges.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveChanges.Values.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(76, 534);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSubmitRequest.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitRequest.OverrideDefault.Border.Rounding = 5F;
            this.btnSubmitRequest.OverrideDefault.Border.Width = 1;
            this.btnSubmitRequest.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitRequest.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitRequest.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmitRequest.Size = new System.Drawing.Size(160, 44);
            this.btnSubmitRequest.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmitRequest.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitRequest.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitRequest.StateCommon.Border.ColorAngle = 45F;
            this.btnSubmitRequest.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitRequest.StateCommon.Border.Rounding = 5F;
            this.btnSubmitRequest.StateCommon.Border.Width = 1;
            this.btnSubmitRequest.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitRequest.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitRequest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.StateDisabled.Border.Rounding = 5F;
            this.btnSubmitRequest.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateNormal.Border.Rounding = 5F;
            this.btnSubmitRequest.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitRequest.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitRequest.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSubmitRequest.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSubmitRequest.StatePressed.Back.ColorAngle = 130F;
            this.btnSubmitRequest.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSubmitRequest.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSubmitRequest.StatePressed.Border.ColorAngle = 130F;
            this.btnSubmitRequest.StatePressed.Border.Rounding = 5F;
            this.btnSubmitRequest.StatePressed.Border.Width = 1;
            this.btnSubmitRequest.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitRequest.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitRequest.StateTracking.Back.ColorAngle = 45F;
            this.btnSubmitRequest.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitRequest.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateTracking.Border.ColorAngle = 45F;
            this.btnSubmitRequest.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitRequest.StateTracking.Border.Rounding = 5F;
            this.btnSubmitRequest.StateTracking.Border.Width = 1;
            this.btnSubmitRequest.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitRequest.TabIndex = 38;
            this.btnSubmitRequest.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSubmitRequest.Values.Text = "Submit";
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click_1);
            // 
            // RequestDocumentsModalCotntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RequestDocumentsModalCotntrol";
            this.Size = new System.Drawing.Size(317, 581);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).EndInit();
            this.pnlMainContentHolder.ResumeLayout(false);
            this.pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPurposes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDocsType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        protected internal Krypton.Toolkit.KryptonComboBox cboDocsType;
        protected internal Krypton.Toolkit.KryptonButton btnSubmitRequest;
        protected internal Krypton.Toolkit.KryptonButton btnSaveChanges;
        protected internal Krypton.Toolkit.KryptonComboBox cboPurposes;
        protected internal Krypton.Toolkit.KryptonCheckBox cbFirstTimeJobSeeker;
        protected internal Krypton.Toolkit.KryptonTextBox txtOtherPurpose;
    }
}
