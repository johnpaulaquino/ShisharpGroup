using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    partial class BlotterResidentModalCotntrol {
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
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.cboStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtStatements = new Krypton.Toolkit.KryptonTextBox();
            this.cboRespondentName = new Krypton.Toolkit.KryptonComboBox();
            this.cboComplainantName = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnUpdateBlotter = new Krypton.Toolkit.KryptonButton();
            this.btnSubmitBlotter = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).BeginInit();
            this.pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRespondentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboComplainantName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(this.pnlMainContentHolder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(317, 464);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pnlMainContentHolder
            // 
            this.pnlMainContentHolder.AutoScroll = true;
            this.pnlMainContentHolder.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentHolder.Controls.Add(this.cboStatus);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel4);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel5);
            this.pnlMainContentHolder.Controls.Add(this.txtStatements);
            this.pnlMainContentHolder.Controls.Add(this.cboRespondentName);
            this.pnlMainContentHolder.Controls.Add(this.cboComplainantName);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel3);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel2);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel1);
            this.pnlMainContentHolder.Controls.Add(this.btnSubmitBlotter);
            this.pnlMainContentHolder.Controls.Add(this.btnUpdateBlotter);
            this.pnlMainContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContentHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContentHolder.Name = "pnlMainContentHolder";
            this.pnlMainContentHolder.Size = new System.Drawing.Size(317, 464);
            this.pnlMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentHolder.TabIndex = 12;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Location = new System.Drawing.Point(105, 597);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(86, 9);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 49;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.DropDownWidth = 428;
            this.cboStatus.Enabled = false;
            this.cboStatus.Items.AddRange(new object[] {
            "Unsettled",
            "Settled",
            "Dismissed"});
            this.cboStatus.Location = new System.Drawing.Point(3, 257);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(299, 25);
            this.cboStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboStatus.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.TabIndex = 46;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 224);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(85, 33);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 45;
            this.kryptonLabel4.Values.Text = "Status";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 304);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(140, 33);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 44;
            this.kryptonLabel5.Values.Text = "Statements";
            // 
            // txtStatements
            // 
            this.txtStatements.Location = new System.Drawing.Point(3, 338);
            this.txtStatements.Multiline = true;
            this.txtStatements.Name = "txtStatements";
            this.txtStatements.Size = new System.Drawing.Size(299, 183);
            this.txtStatements.TabIndex = 43;
            // 
            // cboRespondentName
            // 
            this.cboRespondentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboRespondentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRespondentName.DropDownWidth = 428;
            this.cboRespondentName.Location = new System.Drawing.Point(3, 185);
            this.cboRespondentName.Name = "cboRespondentName";
            this.cboRespondentName.Size = new System.Drawing.Size(299, 25);
            this.cboRespondentName.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboRespondentName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboRespondentName.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboRespondentName.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboRespondentName.TabIndex = 40;
            // 
            // cboComplainantName
            // 
            this.cboComplainantName.DropDownWidth = 428;
            this.cboComplainantName.Location = new System.Drawing.Point(3, 110);
            this.cboComplainantName.Name = "cboComplainantName";
            this.cboComplainantName.Size = new System.Drawing.Size(299, 25);
            this.cboComplainantName.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboComplainantName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboComplainantName.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboComplainantName.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboComplainantName.TabIndex = 19;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(226, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Complainant Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(120, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(86, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Blotter ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 152);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(220, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Respondent Name";
            // 
            // btnUpdateBlotter
            // 
            this.btnUpdateBlotter.Location = new System.Drawing.Point(69, 545);
            this.btnUpdateBlotter.Name = "btnUpdateBlotter";
            this.btnUpdateBlotter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUpdateBlotter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateBlotter.OverrideDefault.Border.Rounding = 5F;
            this.btnUpdateBlotter.OverrideDefault.Border.Width = 1;
            this.btnUpdateBlotter.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateBlotter.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateBlotter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUpdateBlotter.Size = new System.Drawing.Size(160, 47);
            this.btnUpdateBlotter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdateBlotter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateBlotter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateBlotter.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdateBlotter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateBlotter.StateCommon.Border.Rounding = 5F;
            this.btnUpdateBlotter.StateCommon.Border.Width = 1;
            this.btnUpdateBlotter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateBlotter.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateBlotter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBlotter.StateDisabled.Border.Rounding = 5F;
            this.btnUpdateBlotter.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateNormal.Border.Rounding = 5F;
            this.btnUpdateBlotter.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateBlotter.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateBlotter.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnUpdateBlotter.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnUpdateBlotter.StatePressed.Back.ColorAngle = 130F;
            this.btnUpdateBlotter.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnUpdateBlotter.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnUpdateBlotter.StatePressed.Border.ColorAngle = 130F;
            this.btnUpdateBlotter.StatePressed.Border.Rounding = 5F;
            this.btnUpdateBlotter.StatePressed.Border.Width = 1;
            this.btnUpdateBlotter.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateBlotter.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateBlotter.StateTracking.Back.ColorAngle = 45F;
            this.btnUpdateBlotter.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateBlotter.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateTracking.Border.ColorAngle = 45F;
            this.btnUpdateBlotter.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateBlotter.StateTracking.Border.Rounding = 5F;
            this.btnUpdateBlotter.StateTracking.Border.Width = 1;
            this.btnUpdateBlotter.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateBlotter.TabIndex = 48;
            this.btnUpdateBlotter.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdateBlotter.Values.Text = "Update";
            this.btnUpdateBlotter.Click += new System.EventHandler(this.btnUpdateBlotter_Click_1);
            // 
            // btnSubmitBlotter
            // 
            this.btnSubmitBlotter.Location = new System.Drawing.Point(69, 545);
            this.btnSubmitBlotter.Name = "btnSubmitBlotter";
            this.btnSubmitBlotter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSubmitBlotter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitBlotter.OverrideDefault.Border.Rounding = 5F;
            this.btnSubmitBlotter.OverrideDefault.Border.Width = 1;
            this.btnSubmitBlotter.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitBlotter.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitBlotter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmitBlotter.Size = new System.Drawing.Size(160, 47);
            this.btnSubmitBlotter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmitBlotter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitBlotter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitBlotter.StateCommon.Border.ColorAngle = 45F;
            this.btnSubmitBlotter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitBlotter.StateCommon.Border.Rounding = 5F;
            this.btnSubmitBlotter.StateCommon.Border.Width = 1;
            this.btnSubmitBlotter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitBlotter.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitBlotter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitBlotter.StateDisabled.Border.Rounding = 5F;
            this.btnSubmitBlotter.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateNormal.Border.Rounding = 5F;
            this.btnSubmitBlotter.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitBlotter.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitBlotter.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSubmitBlotter.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSubmitBlotter.StatePressed.Back.ColorAngle = 130F;
            this.btnSubmitBlotter.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSubmitBlotter.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSubmitBlotter.StatePressed.Border.ColorAngle = 130F;
            this.btnSubmitBlotter.StatePressed.Border.Rounding = 5F;
            this.btnSubmitBlotter.StatePressed.Border.Width = 1;
            this.btnSubmitBlotter.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitBlotter.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitBlotter.StateTracking.Back.ColorAngle = 45F;
            this.btnSubmitBlotter.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitBlotter.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateTracking.Border.ColorAngle = 45F;
            this.btnSubmitBlotter.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitBlotter.StateTracking.Border.Rounding = 5F;
            this.btnSubmitBlotter.StateTracking.Border.Width = 1;
            this.btnSubmitBlotter.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitBlotter.TabIndex = 38;
            this.btnSubmitBlotter.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSubmitBlotter.Values.Text = "Submit";
            this.btnSubmitBlotter.Click += new System.EventHandler(this.btnSubmitBlotter_Click);
            // 
            // BlotterResidentModalCotntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "BlotterResidentModalCotntrol";
            this.Size = new System.Drawing.Size(317, 464);
            this.Load += new System.EventHandler(this.BlotterResidentModalCotntrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).EndInit();
            this.pnlMainContentHolder.ResumeLayout(false);
            this.pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRespondentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboComplainantName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        protected internal Krypton.Toolkit.KryptonButton btnSubmitBlotter;
        protected internal Krypton.Toolkit.KryptonButton btnUpdateBlotter;
        protected internal Krypton.Toolkit.KryptonComboBox cboStatus;
        protected internal Krypton.Toolkit.KryptonComboBox cboComplainantName;
        protected internal Krypton.Toolkit.KryptonComboBox cboRespondentName;
        protected internal Krypton.Toolkit.KryptonTextBox txtStatements;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}
