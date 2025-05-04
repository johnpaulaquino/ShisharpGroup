using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    partial class OfficialsModalControl {
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
            this.components = new System.ComponentModel.Container();
            this.pnlMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            this.cboDateRange = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.cboStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.dtpkEndTerm = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.btnAddAccom = new Krypton.Toolkit.KryptonButton();
            this.cboAcom = new Krypton.Toolkit.KryptonComboBox();
            this.ctxRemoveAccom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtAccom = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            this.cboAchievements = new Krypton.Toolkit.KryptonComboBox();
            this.ctxRemoveAchievements = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpkStartTerm = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtAchievements = new Krypton.Toolkit.KryptonTextBox();
            this.cboPosition = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSubmitOfficials = new Krypton.Toolkit.KryptonButton();
            this.btnOfficialsSaveChanges = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).BeginInit();
            this.pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDateRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAcom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAchievements)).BeginInit();
            this.ctxRemoveAchievements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContentHolder
            // 
            this.pnlMainContentHolder.AutoScroll = true;
            this.pnlMainContentHolder.Controls.Add(this.cboDateRange);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel8);
            this.pnlMainContentHolder.Controls.Add(this.cboStatus);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel7);
            this.pnlMainContentHolder.Controls.Add(this.dtpkEndTerm);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel6);
            this.pnlMainContentHolder.Controls.Add(this.btnAddAccom);
            this.pnlMainContentHolder.Controls.Add(this.cboAcom);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel4);
            this.pnlMainContentHolder.Controls.Add(this.txtAccom);
            this.pnlMainContentHolder.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentHolder.Controls.Add(this.btnAddAchievement);
            this.pnlMainContentHolder.Controls.Add(this.cboAchievements);
            this.pnlMainContentHolder.Controls.Add(this.dtpkStartTerm);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel5);
            this.pnlMainContentHolder.Controls.Add(this.txtAchievements);
            this.pnlMainContentHolder.Controls.Add(this.cboPosition);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel3);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel2);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel1);
            this.pnlMainContentHolder.Controls.Add(this.btnSubmitOfficials);
            this.pnlMainContentHolder.Controls.Add(this.btnOfficialsSaveChanges);
            this.pnlMainContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContentHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContentHolder.Name = "pnlMainContentHolder";
            this.pnlMainContentHolder.Size = new System.Drawing.Size(317, 581);
            this.pnlMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentHolder.TabIndex = 13;
            // 
            // cboDateRange
            // 
            this.cboDateRange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDateRange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateRange.DropDownWidth = 428;
            this.cboDateRange.Enabled = false;
            this.cboDateRange.Location = new System.Drawing.Point(3, 451);
            this.cboDateRange.Name = "cboDateRange";
            this.cboDateRange.Size = new System.Drawing.Size(291, 25);
            this.cboDateRange.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDateRange.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboDateRange.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDateRange.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDateRange.TabIndex = 58;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 417);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(146, 33);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 57;
            this.kryptonLabel8.Values.Text = "Date Range";
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 428;
            this.cboStatus.Enabled = false;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Resigned",
            "Suspended"});
            this.cboStatus.Location = new System.Drawing.Point(3, 374);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(291, 25);
            this.cboStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboStatus.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.TabIndex = 56;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(5, 340);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(85, 33);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 55;
            this.kryptonLabel7.Values.Text = "Status";
            // 
            // dtpkEndTerm
            // 
            this.dtpkEndTerm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEndTerm.Location = new System.Drawing.Point(5, 293);
            this.dtpkEndTerm.Name = "dtpkEndTerm";
            this.dtpkEndTerm.Size = new System.Drawing.Size(291, 29);
            this.dtpkEndTerm.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkEndTerm.TabIndex = 54;
            this.dtpkEndTerm.ValueChanged += new System.EventHandler(this.dtpkEndTerm_ValueChanged_1);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(5, 259);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(123, 33);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 53;
            this.kryptonLabel6.Values.Text = "End Term";
            // 
            // btnAddAccom
            // 
            this.btnAddAccom.Enabled = false;
            this.btnAddAccom.Location = new System.Drawing.Point(179, 692);
            this.btnAddAccom.Name = "btnAddAccom";
            this.btnAddAccom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddAccom.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccom.OverrideDefault.Border.Rounding = 5F;
            this.btnAddAccom.OverrideDefault.Border.Width = 1;
            this.btnAddAccom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAccom.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddAccom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddAccom.Size = new System.Drawing.Size(117, 44);
            this.btnAddAccom.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateCommon.Back.ColorAngle = 45F;
            this.btnAddAccom.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddAccom.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddAccom.StateCommon.Border.ColorAngle = 45F;
            this.btnAddAccom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccom.StateCommon.Border.Rounding = 5F;
            this.btnAddAccom.StateCommon.Border.Width = 1;
            this.btnAddAccom.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAccom.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddAccom.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccom.StateDisabled.Border.Rounding = 5F;
            this.btnAddAccom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateNormal.Border.Rounding = 5F;
            this.btnAddAccom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAccom.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddAccom.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAddAccom.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAddAccom.StatePressed.Back.ColorAngle = 130F;
            this.btnAddAccom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAddAccom.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAddAccom.StatePressed.Border.ColorAngle = 130F;
            this.btnAddAccom.StatePressed.Border.Rounding = 5F;
            this.btnAddAccom.StatePressed.Border.Width = 1;
            this.btnAddAccom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAddAccom.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddAccom.StateTracking.Back.ColorAngle = 45F;
            this.btnAddAccom.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddAccom.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateTracking.Border.ColorAngle = 45F;
            this.btnAddAccom.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccom.StateTracking.Border.Rounding = 5F;
            this.btnAddAccom.StateTracking.Border.Width = 1;
            this.btnAddAccom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAccom.TabIndex = 52;
            this.btnAddAccom.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddAccom.Values.Text = "Add";
            // 
            // cboAcom
            // 
            this.cboAcom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAcom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAcom.ContextMenuStrip = this.ctxRemoveAccom;
            this.cboAcom.DropDownWidth = 428;
            this.cboAcom.Enabled = false;
            this.cboAcom.Location = new System.Drawing.Point(179, 661);
            this.cboAcom.Name = "cboAcom";
            this.cboAcom.Size = new System.Drawing.Size(117, 25);
            this.cboAcom.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAcom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboAcom.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAcom.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAcom.TabIndex = 51;
            // 
            // ctxRemoveAccom
            // 
            this.ctxRemoveAccom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxRemoveAccom.Name = "ctxRemoveAccom";
            this.ctxRemoveAccom.Size = new System.Drawing.Size(61, 4);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 627);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(208, 33);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 50;
            this.kryptonLabel4.Values.Text = "Accomplishments";
            // 
            // txtAccom
            // 
            this.txtAccom.Enabled = false;
            this.txtAccom.Location = new System.Drawing.Point(5, 661);
            this.txtAccom.Multiline = true;
            this.txtAccom.Name = "txtAccom";
            this.txtAccom.ReadOnly = true;
            this.txtAccom.Size = new System.Drawing.Size(169, 75);
            this.txtAccom.TabIndex = 49;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Location = new System.Drawing.Point(122, 807);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(86, 9);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 48;
            // 
            // btnAddAchievement
            // 
            this.btnAddAchievement.Enabled = false;
            this.btnAddAchievement.Location = new System.Drawing.Point(179, 561);
            this.btnAddAchievement.Name = "btnAddAchievement";
            this.btnAddAchievement.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddAchievement.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAchievement.OverrideDefault.Border.Rounding = 5F;
            this.btnAddAchievement.OverrideDefault.Border.Width = 1;
            this.btnAddAchievement.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAchievement.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddAchievement.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddAchievement.Size = new System.Drawing.Size(117, 44);
            this.btnAddAchievement.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateCommon.Back.ColorAngle = 45F;
            this.btnAddAchievement.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddAchievement.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddAchievement.StateCommon.Border.ColorAngle = 45F;
            this.btnAddAchievement.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAchievement.StateCommon.Border.Rounding = 5F;
            this.btnAddAchievement.StateCommon.Border.Width = 1;
            this.btnAddAchievement.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAchievement.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddAchievement.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAchievement.StateDisabled.Border.Rounding = 5F;
            this.btnAddAchievement.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateNormal.Border.Rounding = 5F;
            this.btnAddAchievement.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAchievement.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddAchievement.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAddAchievement.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAddAchievement.StatePressed.Back.ColorAngle = 130F;
            this.btnAddAchievement.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAddAchievement.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAddAchievement.StatePressed.Border.ColorAngle = 130F;
            this.btnAddAchievement.StatePressed.Border.Rounding = 5F;
            this.btnAddAchievement.StatePressed.Border.Width = 1;
            this.btnAddAchievement.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAddAchievement.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddAchievement.StateTracking.Back.ColorAngle = 45F;
            this.btnAddAchievement.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddAchievement.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateTracking.Border.ColorAngle = 45F;
            this.btnAddAchievement.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAchievement.StateTracking.Border.Rounding = 5F;
            this.btnAddAchievement.StateTracking.Border.Width = 1;
            this.btnAddAchievement.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddAchievement.TabIndex = 47;
            this.btnAddAchievement.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddAchievement.Values.Text = "Add";
            this.btnAddAchievement.Click += new System.EventHandler(this.btnAddAchievement_Click_1);
            // 
            // cboAchievements
            // 
            this.cboAchievements.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAchievements.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAchievements.ContextMenuStrip = this.ctxRemoveAchievements;
            this.cboAchievements.DropDownWidth = 428;
            this.cboAchievements.Enabled = false;
            this.cboAchievements.Items.AddRange(new object[] {
            "asdasd",
            "asdasd",
            "asdasd"});
            this.cboAchievements.Location = new System.Drawing.Point(179, 530);
            this.cboAchievements.Name = "cboAchievements";
            this.cboAchievements.Size = new System.Drawing.Size(117, 25);
            this.cboAchievements.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAchievements.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboAchievements.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAchievements.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAchievements.TabIndex = 46;
            this.cboAchievements.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cboAchievements_MouseDown_1);
            // 
            // ctxRemoveAchievements
            // 
            this.ctxRemoveAchievements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxRemoveAchievements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.ctxRemoveAchievements.Name = "ctxRemoveAchievements";
            this.ctxRemoveAchievements.Size = new System.Drawing.Size(118, 26);
            this.ctxRemoveAchievements.Opening += new System.ComponentModel.CancelEventHandler(this.ctxRemoveAchievements_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // dtpkStartTerm
            // 
            this.dtpkStartTerm.Location = new System.Drawing.Point(5, 213);
            this.dtpkStartTerm.Name = "dtpkStartTerm";
            this.dtpkStartTerm.Size = new System.Drawing.Size(291, 29);
            this.dtpkStartTerm.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkStartTerm.TabIndex = 45;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 496);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(170, 33);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 44;
            this.kryptonLabel5.Values.Text = "Achievements";
            // 
            // txtAchievements
            // 
            this.txtAchievements.Enabled = false;
            this.txtAchievements.Location = new System.Drawing.Point(5, 530);
            this.txtAchievements.Multiline = true;
            this.txtAchievements.Name = "txtAchievements";
            this.txtAchievements.ReadOnly = true;
            this.txtAchievements.Size = new System.Drawing.Size(169, 75);
            this.txtAchievements.TabIndex = 43;
            // 
            // cboPosition
            // 
            this.cboPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.DropDownWidth = 428;
            this.cboPosition.Items.AddRange(new object[] {
            "Barangay Captain",
            "Barangay Councilors",
            "Barangay Secretary",
            "Barangay Treasurer",
            "Barangay Health Worker (BHW)",
            "SK Chairperson",
            "SK Kagawads",
            "SK Secretary",
            "SK Treasurer"});
            this.cboPosition.Location = new System.Drawing.Point(5, 130);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(291, 25);
            this.cboPosition.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPosition.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboPosition.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPosition.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPosition.TabIndex = 19;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 96);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Position";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(54, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(215, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Barangay Officials";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 172);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(131, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Start Term";
            // 
            // btnSubmitOfficials
            // 
            this.btnSubmitOfficials.Location = new System.Drawing.Point(76, 757);
            this.btnSubmitOfficials.Name = "btnSubmitOfficials";
            this.btnSubmitOfficials.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSubmitOfficials.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitOfficials.OverrideDefault.Border.Rounding = 5F;
            this.btnSubmitOfficials.OverrideDefault.Border.Width = 1;
            this.btnSubmitOfficials.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitOfficials.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitOfficials.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmitOfficials.Size = new System.Drawing.Size(160, 44);
            this.btnSubmitOfficials.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmitOfficials.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitOfficials.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitOfficials.StateCommon.Border.ColorAngle = 45F;
            this.btnSubmitOfficials.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitOfficials.StateCommon.Border.Rounding = 5F;
            this.btnSubmitOfficials.StateCommon.Border.Width = 1;
            this.btnSubmitOfficials.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitOfficials.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitOfficials.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOfficials.StateDisabled.Border.Rounding = 5F;
            this.btnSubmitOfficials.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateNormal.Border.Rounding = 5F;
            this.btnSubmitOfficials.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitOfficials.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitOfficials.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSubmitOfficials.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSubmitOfficials.StatePressed.Back.ColorAngle = 130F;
            this.btnSubmitOfficials.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSubmitOfficials.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSubmitOfficials.StatePressed.Border.ColorAngle = 130F;
            this.btnSubmitOfficials.StatePressed.Border.Rounding = 5F;
            this.btnSubmitOfficials.StatePressed.Border.Width = 1;
            this.btnSubmitOfficials.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitOfficials.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitOfficials.StateTracking.Back.ColorAngle = 45F;
            this.btnSubmitOfficials.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitOfficials.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateTracking.Border.ColorAngle = 45F;
            this.btnSubmitOfficials.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitOfficials.StateTracking.Border.Rounding = 5F;
            this.btnSubmitOfficials.StateTracking.Border.Width = 1;
            this.btnSubmitOfficials.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitOfficials.TabIndex = 38;
            this.btnSubmitOfficials.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSubmitOfficials.Values.Text = "Submit";
            this.btnSubmitOfficials.Click += new System.EventHandler(this.btnSubmitOfficials_Click_2);
            // 
            // btnOfficialsSaveChanges
            // 
            this.btnOfficialsSaveChanges.Location = new System.Drawing.Point(76, 757);
            this.btnOfficialsSaveChanges.Name = "btnOfficialsSaveChanges";
            this.btnOfficialsSaveChanges.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.OverrideDefault.Back.ColorAngle = 45F;
            this.btnOfficialsSaveChanges.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOfficialsSaveChanges.OverrideDefault.Border.Rounding = 5F;
            this.btnOfficialsSaveChanges.OverrideDefault.Border.Width = 1;
            this.btnOfficialsSaveChanges.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnOfficialsSaveChanges.Size = new System.Drawing.Size(160, 44);
            this.btnOfficialsSaveChanges.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateCommon.Back.ColorAngle = 45F;
            this.btnOfficialsSaveChanges.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOfficialsSaveChanges.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOfficialsSaveChanges.StateCommon.Border.ColorAngle = 45F;
            this.btnOfficialsSaveChanges.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOfficialsSaveChanges.StateCommon.Border.Rounding = 5F;
            this.btnOfficialsSaveChanges.StateCommon.Border.Width = 1;
            this.btnOfficialsSaveChanges.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficialsSaveChanges.StateDisabled.Border.Rounding = 5F;
            this.btnOfficialsSaveChanges.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateNormal.Border.Rounding = 5F;
            this.btnOfficialsSaveChanges.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnOfficialsSaveChanges.StatePressed.Back.ColorAngle = 130F;
            this.btnOfficialsSaveChanges.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnOfficialsSaveChanges.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnOfficialsSaveChanges.StatePressed.Border.ColorAngle = 130F;
            this.btnOfficialsSaveChanges.StatePressed.Border.Rounding = 5F;
            this.btnOfficialsSaveChanges.StatePressed.Border.Width = 1;
            this.btnOfficialsSaveChanges.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnOfficialsSaveChanges.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnOfficialsSaveChanges.StateTracking.Back.ColorAngle = 45F;
            this.btnOfficialsSaveChanges.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOfficialsSaveChanges.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateTracking.Border.ColorAngle = 45F;
            this.btnOfficialsSaveChanges.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOfficialsSaveChanges.StateTracking.Border.Rounding = 5F;
            this.btnOfficialsSaveChanges.StateTracking.Border.Width = 1;
            this.btnOfficialsSaveChanges.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOfficialsSaveChanges.TabIndex = 39;
            this.btnOfficialsSaveChanges.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnOfficialsSaveChanges.Values.Text = "Save Changes";
            // 
            // OfficialsModalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentHolder);
            this.Name = "OfficialsModalControl";
            this.Size = new System.Drawing.Size(317, 581);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).EndInit();
            this.pnlMainContentHolder.ResumeLayout(false);
            this.pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDateRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAcom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAchievements)).EndInit();
            this.ctxRemoveAchievements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        protected internal Krypton.Toolkit.KryptonComboBox cboStatus;
        protected internal Krypton.Toolkit.KryptonDateTimePicker dtpkEndTerm;
        protected internal Krypton.Toolkit.KryptonButton btnAddAccom;
        protected internal Krypton.Toolkit.KryptonComboBox cboAcom;
        protected internal Krypton.Toolkit.KryptonTextBox txtAccom;
        protected internal Krypton.Toolkit.KryptonButton btnAddAchievement;
        protected internal Krypton.Toolkit.KryptonComboBox cboAchievements;
        protected internal Krypton.Toolkit.KryptonDateTimePicker dtpkStartTerm;
        protected internal Krypton.Toolkit.KryptonTextBox txtAchievements;
        protected internal Krypton.Toolkit.KryptonComboBox cboPosition;
        protected internal Krypton.Toolkit.KryptonButton btnSubmitOfficials;
        protected internal Krypton.Toolkit.KryptonButton btnOfficialsSaveChanges;
        protected internal Krypton.Toolkit.KryptonComboBox cboDateRange;
        private ContextMenuStrip ctxRemoveAccom;
        private ContextMenuStrip ctxRemoveAchievements;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}
