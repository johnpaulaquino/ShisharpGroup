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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pnlMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            cboStatus = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtStatements = new Krypton.Toolkit.KryptonTextBox();
            cboRespondentName = new Krypton.Toolkit.KryptonComboBox();
            cboComplainantName = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnUpdateBlotter = new Krypton.Toolkit.KryptonButton();
            btnSubmitBlotter = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentHolder).BeginInit();
            pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboRespondentName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboComplainantName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.Controls.Add(pnlMainContentHolder);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(370, 535);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // pnlMainContentHolder
            // 
            pnlMainContentHolder.AutoScroll = true;
            pnlMainContentHolder.Controls.Add(kryptonPanel2);
            pnlMainContentHolder.Controls.Add(cboStatus);
            pnlMainContentHolder.Controls.Add(kryptonLabel4);
            pnlMainContentHolder.Controls.Add(kryptonLabel5);
            pnlMainContentHolder.Controls.Add(txtStatements);
            pnlMainContentHolder.Controls.Add(cboRespondentName);
            pnlMainContentHolder.Controls.Add(cboComplainantName);
            pnlMainContentHolder.Controls.Add(kryptonLabel3);
            pnlMainContentHolder.Controls.Add(kryptonLabel2);
            pnlMainContentHolder.Controls.Add(kryptonLabel1);
            pnlMainContentHolder.Controls.Add(btnUpdateBlotter);
            pnlMainContentHolder.Controls.Add(btnSubmitBlotter);
            pnlMainContentHolder.Dock = DockStyle.Fill;
            pnlMainContentHolder.Location = new Point(0, 0);
            pnlMainContentHolder.Name = "pnlMainContentHolder";
            pnlMainContentHolder.Size = new Size(370, 535);
            pnlMainContentHolder.StateCommon.Color1 = Color.White;
            pnlMainContentHolder.TabIndex = 12;
            // 
            // cboStatus
            // 
            cboStatus.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStatus.DropDownWidth = 428;
            cboStatus.Enabled = false;
            cboStatus.Items.AddRange(new object[] { "Unsettled", "Settled", "Dismissed" });
            cboStatus.Location = new Point(3, 297);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(349, 25);
            cboStatus.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F);
            cboStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboStatus.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboStatus.StateNormal.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboStatus.TabIndex = 46;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(3, 258);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(85, 33);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 45;
            kryptonLabel4.Values.Text = "Status";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(3, 351);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(140, 33);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 44;
            kryptonLabel5.Values.Text = "Statements";
            // 
            // txtStatements
            // 
            txtStatements.Location = new Point(3, 390);
            txtStatements.Multiline = true;
            txtStatements.Name = "txtStatements";
            txtStatements.Size = new Size(349, 211);
            txtStatements.TabIndex = 43;
            // 
            // cboRespondentName
            // 
            cboRespondentName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboRespondentName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboRespondentName.DropDownWidth = 428;
            cboRespondentName.Location = new Point(3, 214);
            cboRespondentName.Name = "cboRespondentName";
            cboRespondentName.Size = new Size(349, 25);
            cboRespondentName.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F);
            cboRespondentName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboRespondentName.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboRespondentName.StateNormal.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboRespondentName.TabIndex = 40;
            // 
            // cboComplainantName
            // 
            cboComplainantName.DropDownWidth = 428;
            cboComplainantName.Location = new Point(3, 127);
            cboComplainantName.Name = "cboComplainantName";
            cboComplainantName.Size = new Size(349, 25);
            cboComplainantName.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F);
            cboComplainantName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboComplainantName.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboComplainantName.StateNormal.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F);
            cboComplainantName.TabIndex = 19;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(3, 88);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(226, 33);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 18;
            kryptonLabel3.Values.Text = "Complainant Name";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(140, 3);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(86, 33);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Blotter ";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 175);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(220, 33);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 17;
            kryptonLabel1.Values.Text = "Respondent Name";
            // 
            // btnUpdateBlotter
            // 
            btnUpdateBlotter.Location = new Point(80, 629);
            btnUpdateBlotter.Margin = new Padding(4, 3, 4, 3);
            btnUpdateBlotter.Name = "btnUpdateBlotter";
            btnUpdateBlotter.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.OverrideDefault.Back.ColorAngle = 45F;
            btnUpdateBlotter.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdateBlotter.OverrideDefault.Border.Rounding = 5F;
            btnUpdateBlotter.OverrideDefault.Border.Width = 1;
            btnUpdateBlotter.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnUpdateBlotter.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnUpdateBlotter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnUpdateBlotter.Size = new Size(187, 54);
            btnUpdateBlotter.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateCommon.Back.ColorAngle = 45F;
            btnUpdateBlotter.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnUpdateBlotter.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnUpdateBlotter.StateCommon.Border.ColorAngle = 45F;
            btnUpdateBlotter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdateBlotter.StateCommon.Border.Rounding = 5F;
            btnUpdateBlotter.StateCommon.Border.Width = 1;
            btnUpdateBlotter.StateCommon.Content.ShortText.Color1 = Color.White;
            btnUpdateBlotter.StateCommon.Content.ShortText.Color2 = Color.White;
            btnUpdateBlotter.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBlotter.StateDisabled.Border.Rounding = 5F;
            btnUpdateBlotter.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateNormal.Border.Rounding = 5F;
            btnUpdateBlotter.StateNormal.Content.ShortText.Color1 = Color.White;
            btnUpdateBlotter.StateNormal.Content.ShortText.Color2 = Color.White;
            btnUpdateBlotter.StatePressed.Back.Color1 = Color.White;
            btnUpdateBlotter.StatePressed.Back.Color2 = Color.White;
            btnUpdateBlotter.StatePressed.Back.ColorAngle = 130F;
            btnUpdateBlotter.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnUpdateBlotter.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnUpdateBlotter.StatePressed.Border.ColorAngle = 130F;
            btnUpdateBlotter.StatePressed.Border.Rounding = 5F;
            btnUpdateBlotter.StatePressed.Border.Width = 1;
            btnUpdateBlotter.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnUpdateBlotter.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnUpdateBlotter.StateTracking.Back.ColorAngle = 45F;
            btnUpdateBlotter.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnUpdateBlotter.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateTracking.Border.ColorAngle = 45F;
            btnUpdateBlotter.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdateBlotter.StateTracking.Border.Rounding = 5F;
            btnUpdateBlotter.StateTracking.Border.Width = 1;
            btnUpdateBlotter.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnUpdateBlotter.TabIndex = 48;
            btnUpdateBlotter.Values.DropDownArrowColor = Color.Empty;
            btnUpdateBlotter.Values.Text = "Update";
            btnUpdateBlotter.Click += btnUpdateBlotter_Click;
            btnUpdateBlotter.MouseClick += btnUpdateBlotter_MouseClick;
            // 
            // btnSubmitBlotter
            // 
            btnSubmitBlotter.Location = new Point(80, 629);
            btnSubmitBlotter.Margin = new Padding(4, 3, 4, 3);
            btnSubmitBlotter.Name = "btnSubmitBlotter";
            btnSubmitBlotter.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.OverrideDefault.Back.ColorAngle = 45F;
            btnSubmitBlotter.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSubmitBlotter.OverrideDefault.Border.Rounding = 5F;
            btnSubmitBlotter.OverrideDefault.Border.Width = 1;
            btnSubmitBlotter.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnSubmitBlotter.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnSubmitBlotter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSubmitBlotter.Size = new Size(187, 54);
            btnSubmitBlotter.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateCommon.Back.ColorAngle = 45F;
            btnSubmitBlotter.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSubmitBlotter.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnSubmitBlotter.StateCommon.Border.ColorAngle = 45F;
            btnSubmitBlotter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSubmitBlotter.StateCommon.Border.Rounding = 5F;
            btnSubmitBlotter.StateCommon.Border.Width = 1;
            btnSubmitBlotter.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSubmitBlotter.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSubmitBlotter.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitBlotter.StateDisabled.Border.Rounding = 5F;
            btnSubmitBlotter.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateNormal.Border.Rounding = 5F;
            btnSubmitBlotter.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSubmitBlotter.StateNormal.Content.ShortText.Color2 = Color.White;
            btnSubmitBlotter.StatePressed.Back.Color1 = Color.White;
            btnSubmitBlotter.StatePressed.Back.Color2 = Color.White;
            btnSubmitBlotter.StatePressed.Back.ColorAngle = 130F;
            btnSubmitBlotter.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnSubmitBlotter.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnSubmitBlotter.StatePressed.Border.ColorAngle = 130F;
            btnSubmitBlotter.StatePressed.Border.Rounding = 5F;
            btnSubmitBlotter.StatePressed.Border.Width = 1;
            btnSubmitBlotter.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnSubmitBlotter.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnSubmitBlotter.StateTracking.Back.ColorAngle = 45F;
            btnSubmitBlotter.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSubmitBlotter.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateTracking.Border.ColorAngle = 45F;
            btnSubmitBlotter.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSubmitBlotter.StateTracking.Border.Rounding = 5F;
            btnSubmitBlotter.StateTracking.Border.Width = 1;
            btnSubmitBlotter.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSubmitBlotter.TabIndex = 38;
            btnSubmitBlotter.Values.DropDownArrowColor = Color.Empty;
            btnSubmitBlotter.Values.Text = "Submit";
            btnSubmitBlotter.Click += btnSubmitBlotter_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Location = new Point(123, 689);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(100, 10);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 49;
            // 
            // BlotterResidentModalCotntrol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "BlotterResidentModalCotntrol";
            Size = new Size(370, 535);
            Load += BlotterResidentModalCotntrol_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlMainContentHolder).EndInit();
            pnlMainContentHolder.ResumeLayout(false);
            pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboRespondentName).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboComplainantName).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ResumeLayout(false);
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
