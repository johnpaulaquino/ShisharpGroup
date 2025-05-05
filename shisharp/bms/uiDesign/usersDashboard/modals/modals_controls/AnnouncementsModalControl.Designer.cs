using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    partial class AnnouncementsModalControl {
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
            this.picAttachment = new Krypton.Toolkit.KryptonPictureBox();
            this.cbHidePost = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtTitle = new Krypton.Toolkit.KryptonTextBox();
            this.btnUplaodAnnouncement = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtStatements = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSubmitAnnouncements = new Krypton.Toolkit.KryptonButton();
            this.btnUpdateAnnouncements = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).BeginInit();
            this.pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
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
            this.pnlMainContentHolder.Controls.Add(this.picAttachment);
            this.pnlMainContentHolder.Controls.Add(this.cbHidePost);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel4);
            this.pnlMainContentHolder.Controls.Add(this.txtTitle);
            this.pnlMainContentHolder.Controls.Add(this.btnUplaodAnnouncement);
            this.pnlMainContentHolder.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel5);
            this.pnlMainContentHolder.Controls.Add(this.txtStatements);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel3);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel2);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel1);
            this.pnlMainContentHolder.Controls.Add(this.btnUpdateAnnouncements);
            this.pnlMainContentHolder.Controls.Add(this.btnSubmitAnnouncements);
            this.pnlMainContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContentHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContentHolder.Name = "pnlMainContentHolder";
            this.pnlMainContentHolder.Size = new System.Drawing.Size(317, 464);
            this.pnlMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentHolder.TabIndex = 12;
            // 
            // picAttachment
            // 
            this.picAttachment.Location = new System.Drawing.Point(3, 199);
            this.picAttachment.Name = "picAttachment";
            this.picAttachment.Size = new System.Drawing.Size(182, 95);
            this.picAttachment.TabIndex = 54;
            this.picAttachment.TabStop = false;
            // 
            // cbHidePost
            // 
            this.cbHidePost.Enabled = false;
            this.cbHidePost.Location = new System.Drawing.Point(3, 537);
            this.cbHidePost.Name = "cbHidePost";
            this.cbHidePost.Size = new System.Drawing.Size(66, 26);
            this.cbHidePost.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHidePost.TabIndex = 53;
            this.cbHidePost.Values.Text = "Hide";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 504);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(238, 33);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 52;
            this.kryptonLabel4.Values.Text = "Hide Announcement";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(3, 103);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(297, 43);
            this.txtTitle.TabIndex = 51;
            // 
            // btnUplaodAnnouncement
            // 
            this.btnUplaodAnnouncement.Location = new System.Drawing.Point(190, 230);
            this.btnUplaodAnnouncement.Name = "btnUplaodAnnouncement";
            this.btnUplaodAnnouncement.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUplaodAnnouncement.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUplaodAnnouncement.OverrideDefault.Border.Rounding = 5F;
            this.btnUplaodAnnouncement.OverrideDefault.Border.Width = 1;
            this.btnUplaodAnnouncement.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUplaodAnnouncement.Size = new System.Drawing.Size(111, 47);
            this.btnUplaodAnnouncement.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateCommon.Back.ColorAngle = 45F;
            this.btnUplaodAnnouncement.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUplaodAnnouncement.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUplaodAnnouncement.StateCommon.Border.ColorAngle = 45F;
            this.btnUplaodAnnouncement.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUplaodAnnouncement.StateCommon.Border.Rounding = 5F;
            this.btnUplaodAnnouncement.StateCommon.Border.Width = 1;
            this.btnUplaodAnnouncement.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUplaodAnnouncement.StateDisabled.Border.Rounding = 5F;
            this.btnUplaodAnnouncement.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateNormal.Border.Rounding = 5F;
            this.btnUplaodAnnouncement.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnUplaodAnnouncement.StatePressed.Back.ColorAngle = 130F;
            this.btnUplaodAnnouncement.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnUplaodAnnouncement.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnUplaodAnnouncement.StatePressed.Border.ColorAngle = 130F;
            this.btnUplaodAnnouncement.StatePressed.Border.Rounding = 5F;
            this.btnUplaodAnnouncement.StatePressed.Border.Width = 1;
            this.btnUplaodAnnouncement.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnUplaodAnnouncement.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUplaodAnnouncement.StateTracking.Back.ColorAngle = 45F;
            this.btnUplaodAnnouncement.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUplaodAnnouncement.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateTracking.Border.ColorAngle = 45F;
            this.btnUplaodAnnouncement.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUplaodAnnouncement.StateTracking.Border.Rounding = 5F;
            this.btnUplaodAnnouncement.StateTracking.Border.Width = 1;
            this.btnUplaodAnnouncement.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUplaodAnnouncement.TabIndex = 50;
            this.btnUplaodAnnouncement.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUplaodAnnouncement.Values.Text = "Upload";
            this.btnUplaodAnnouncement.Click += new System.EventHandler(this.btnUplaodAnnouncement_Click_1);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Location = new System.Drawing.Point(105, 637);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(86, 16);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 47;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 319);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(115, 33);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 44;
            this.kryptonLabel5.Values.Text = "Message";
            // 
            // txtStatements
            // 
            this.txtStatements.Location = new System.Drawing.Point(3, 353);
            this.txtStatements.Multiline = true;
            this.txtStatements.Name = "txtStatements";
            this.txtStatements.Size = new System.Drawing.Size(299, 138);
            this.txtStatements.TabIndex = 43;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(61, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Title";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(87, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(179, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Anouncements";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 169);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(140, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Attachment";
            // 
            // btnSubmitAnnouncements
            // 
            this.btnSubmitAnnouncements.Location = new System.Drawing.Point(69, 585);
            this.btnSubmitAnnouncements.Name = "btnSubmitAnnouncements";
            this.btnSubmitAnnouncements.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSubmitAnnouncements.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitAnnouncements.OverrideDefault.Border.Rounding = 5F;
            this.btnSubmitAnnouncements.OverrideDefault.Border.Width = 1;
            this.btnSubmitAnnouncements.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmitAnnouncements.Size = new System.Drawing.Size(160, 47);
            this.btnSubmitAnnouncements.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmitAnnouncements.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitAnnouncements.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitAnnouncements.StateCommon.Border.ColorAngle = 45F;
            this.btnSubmitAnnouncements.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitAnnouncements.StateCommon.Border.Rounding = 5F;
            this.btnSubmitAnnouncements.StateCommon.Border.Width = 1;
            this.btnSubmitAnnouncements.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnnouncements.StateDisabled.Border.Rounding = 5F;
            this.btnSubmitAnnouncements.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateNormal.Border.Rounding = 5F;
            this.btnSubmitAnnouncements.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSubmitAnnouncements.StatePressed.Back.ColorAngle = 130F;
            this.btnSubmitAnnouncements.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSubmitAnnouncements.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSubmitAnnouncements.StatePressed.Border.ColorAngle = 130F;
            this.btnSubmitAnnouncements.StatePressed.Border.Rounding = 5F;
            this.btnSubmitAnnouncements.StatePressed.Border.Width = 1;
            this.btnSubmitAnnouncements.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitAnnouncements.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitAnnouncements.StateTracking.Back.ColorAngle = 45F;
            this.btnSubmitAnnouncements.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmitAnnouncements.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateTracking.Border.ColorAngle = 45F;
            this.btnSubmitAnnouncements.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmitAnnouncements.StateTracking.Border.Rounding = 5F;
            this.btnSubmitAnnouncements.StateTracking.Border.Width = 1;
            this.btnSubmitAnnouncements.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmitAnnouncements.TabIndex = 38;
            this.btnSubmitAnnouncements.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSubmitAnnouncements.Values.Text = "Submit";
            this.btnSubmitAnnouncements.Click += new System.EventHandler(this.btnSubmitAnnouncements_Click);
            // 
            // btnUpdateAnnouncements
            // 
            this.btnUpdateAnnouncements.Location = new System.Drawing.Point(69, 585);
            this.btnUpdateAnnouncements.Name = "btnUpdateAnnouncements";
            this.btnUpdateAnnouncements.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUpdateAnnouncements.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateAnnouncements.OverrideDefault.Border.Rounding = 5F;
            this.btnUpdateAnnouncements.OverrideDefault.Border.Width = 1;
            this.btnUpdateAnnouncements.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUpdateAnnouncements.Size = new System.Drawing.Size(160, 47);
            this.btnUpdateAnnouncements.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdateAnnouncements.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateAnnouncements.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateAnnouncements.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdateAnnouncements.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateAnnouncements.StateCommon.Border.Rounding = 5F;
            this.btnUpdateAnnouncements.StateCommon.Border.Width = 1;
            this.btnUpdateAnnouncements.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAnnouncements.StateDisabled.Border.Rounding = 5F;
            this.btnUpdateAnnouncements.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateNormal.Border.Rounding = 5F;
            this.btnUpdateAnnouncements.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnUpdateAnnouncements.StatePressed.Back.ColorAngle = 130F;
            this.btnUpdateAnnouncements.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnUpdateAnnouncements.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnUpdateAnnouncements.StatePressed.Border.ColorAngle = 130F;
            this.btnUpdateAnnouncements.StatePressed.Border.Rounding = 5F;
            this.btnUpdateAnnouncements.StatePressed.Border.Width = 1;
            this.btnUpdateAnnouncements.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateAnnouncements.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateAnnouncements.StateTracking.Back.ColorAngle = 45F;
            this.btnUpdateAnnouncements.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnUpdateAnnouncements.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateTracking.Border.ColorAngle = 45F;
            this.btnUpdateAnnouncements.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdateAnnouncements.StateTracking.Border.Rounding = 5F;
            this.btnUpdateAnnouncements.StateTracking.Border.Width = 1;
            this.btnUpdateAnnouncements.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUpdateAnnouncements.TabIndex = 48;
            this.btnUpdateAnnouncements.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdateAnnouncements.Values.Text = "Update";
            this.btnUpdateAnnouncements.Click += new System.EventHandler(this.btnUpdateAnnouncements_Click_1);
            // 
            // AnnouncementsModalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "AnnouncementsModalControl";
            this.Size = new System.Drawing.Size(317, 464);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).EndInit();
            this.pnlMainContentHolder.ResumeLayout(false);
            this.pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        protected internal Krypton.Toolkit.KryptonButton btnSubmitAnnouncements;
        protected internal Krypton.Toolkit.KryptonButton btnUpdateAnnouncements;
        protected internal Krypton.Toolkit.KryptonTextBox txtStatements;
        protected internal Krypton.Toolkit.KryptonButton btnUplaodAnnouncement;
        protected internal Krypton.Toolkit.KryptonTextBox txtTitle;
        protected internal Krypton.Toolkit.KryptonCheckBox cbHidePost;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        protected internal Krypton.Toolkit.KryptonPictureBox picAttachment;
    }
}
