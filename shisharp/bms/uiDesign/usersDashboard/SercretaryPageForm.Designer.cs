using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard {
    partial class SercretaryPageForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SercretaryPageForm));
            this.pnlMainContainer = new Krypton.Toolkit.KryptonPanel();
            this.pnlFilterValueHolder = new Krypton.Toolkit.KryptonPanel();
            this.pnlMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.pnlRighSeperator = new Krypton.Toolkit.KryptonPanel();
            this.pnlRightSeperator = new Krypton.Toolkit.KryptonPanel();
            this.pnlSidebar = new Krypton.Toolkit.KryptonPanel();
            this.pnlUserSidebar = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.picOfficials = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.picApprovalDocs = new Krypton.Toolkit.KryptonPictureBox();
            this.pnlUserLogsIcon = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.picUserLogs = new Krypton.Toolkit.KryptonPictureBox();
            this.pnlUserRequestocsIcon = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.picUserRequestDocs = new Krypton.Toolkit.KryptonPictureBox();
            this.pnlUserDashboardIcon = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.picUserDashboardIcon = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.pnlTopSeperator = new Krypton.Toolkit.KryptonPanel();
            this.lblRole = new Krypton.Toolkit.KryptonLabel();
            this.picProfilePic = new Krypton.Toolkit.KryptonPictureBox();
            this.lblUsername = new Krypton.Toolkit.KryptonLabel();
            this.picMenuButton = new Krypton.Toolkit.KryptonPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContainer)).BeginInit();
            this.pnlMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterValueHolder)).BeginInit();
            this.pnlFilterValueHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRighSeperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightSeperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSidebar)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserSidebar)).BeginInit();
            this.pnlUserSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOfficials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApprovalDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserLogsIcon)).BeginInit();
            this.pnlUserLogsIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserRequestocsIcon)).BeginInit();
            this.pnlUserRequestocsIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserRequestDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserDashboardIcon)).BeginInit();
            this.pnlUserDashboardIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserDashboardIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTopSeperator)).BeginInit();
            this.pnlTopSeperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainContainer.CausesValidation = false;
            this.pnlMainContainer.Controls.Add(this.pnlFilterValueHolder);
            this.pnlMainContainer.Controls.Add(this.pnlSidebar);
            this.pnlMainContainer.Controls.Add(this.kryptonPanel2);
            this.pnlMainContainer.Controls.Add(this.pnlTopSeperator);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1049, 590);
            this.pnlMainContainer.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMainContainer.TabIndex = 0;
            // 
            // pnlFilterValueHolder
            // 
            this.pnlFilterValueHolder.Controls.Add(this.pnlMainContentHolder);
            this.pnlFilterValueHolder.Controls.Add(this.kryptonPanel1);
            this.pnlFilterValueHolder.Controls.Add(this.pnlRighSeperator);
            this.pnlFilterValueHolder.Controls.Add(this.pnlRightSeperator);
            this.pnlFilterValueHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterValueHolder.Location = new System.Drawing.Point(40, 42);
            this.pnlFilterValueHolder.Name = "pnlFilterValueHolder";
            this.pnlFilterValueHolder.Size = new System.Drawing.Size(1009, 548);
            this.pnlFilterValueHolder.TabIndex = 0;
            // 
            // pnlMainContentHolder
            // 
            this.pnlMainContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContentHolder.Location = new System.Drawing.Point(21, 22);
            this.pnlMainContentHolder.Name = "pnlMainContentHolder";
            this.pnlMainContentHolder.Size = new System.Drawing.Size(967, 526);
            this.pnlMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentHolder.TabIndex = 13;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(21, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(967, 22);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPanel1.TabIndex = 14;
            // 
            // pnlRighSeperator
            // 
            this.pnlRighSeperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRighSeperator.Location = new System.Drawing.Point(0, 0);
            this.pnlRighSeperator.Name = "pnlRighSeperator";
            this.pnlRighSeperator.Size = new System.Drawing.Size(21, 548);
            this.pnlRighSeperator.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(224)))));
            this.pnlRighSeperator.TabIndex = 15;
            // 
            // pnlRightSeperator
            // 
            this.pnlRightSeperator.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightSeperator.Location = new System.Drawing.Point(988, 0);
            this.pnlRightSeperator.Name = "pnlRightSeperator";
            this.pnlRightSeperator.Size = new System.Drawing.Size(21, 548);
            this.pnlRightSeperator.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(224)))));
            this.pnlRightSeperator.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pnlRightSeperator.TabIndex = 12;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.pnlUserSidebar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 42);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(197, 548);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(40, 548);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlSidebar.Size = new System.Drawing.Size(40, 548);
            this.pnlSidebar.StateCommon.Color1 = System.Drawing.Color.IndianRed;
            this.pnlSidebar.StateCommon.Color2 = System.Drawing.Color.IndianRed;
            this.pnlSidebar.StateCommon.ColorAngle = 100F;
            this.pnlSidebar.StateNormal.Color1 = System.Drawing.Color.White;
            this.pnlSidebar.StateNormal.Color2 = System.Drawing.Color.DimGray;
            this.pnlSidebar.StateNormal.ColorAngle = 100F;
            this.pnlSidebar.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pnlSidebar.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlUserSidebar
            // 
            this.pnlUserSidebar.Controls.Add(this.kryptonPanel4);
            this.pnlUserSidebar.Controls.Add(this.kryptonPanel3);
            this.pnlUserSidebar.Controls.Add(this.pnlUserLogsIcon);
            this.pnlUserSidebar.Controls.Add(this.pnlUserRequestocsIcon);
            this.pnlUserSidebar.Controls.Add(this.pnlUserDashboardIcon);
            this.pnlUserSidebar.Controls.Add(this.kryptonPictureBox1);
            this.pnlUserSidebar.Controls.Add(this.kryptonPanel6);
            this.pnlUserSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlUserSidebar.MaximumSize = new System.Drawing.Size(197, 548);
            this.pnlUserSidebar.Name = "pnlUserSidebar";
            this.pnlUserSidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlUserSidebar.Size = new System.Drawing.Size(40, 548);
            this.pnlUserSidebar.StateCommon.Color1 = System.Drawing.Color.IndianRed;
            this.pnlUserSidebar.StateCommon.Color2 = System.Drawing.Color.IndianRed;
            this.pnlUserSidebar.StateCommon.ColorAngle = 100F;
            this.pnlUserSidebar.StateNormal.Color1 = System.Drawing.Color.White;
            this.pnlUserSidebar.StateNormal.Color2 = System.Drawing.Color.DimGray;
            this.pnlUserSidebar.StateNormal.ColorAngle = 100F;
            this.pnlUserSidebar.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pnlUserSidebar.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.pnlUserSidebar.TabIndex = 9;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel4.Controls.Add(this.picOfficials);
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 148);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(197, 35);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 14;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(44, 8);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(146, 23);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 8;
            this.kryptonLabel6.Values.Text = "Barangay Officials";
            // 
            // picOfficials
            // 
            this.picOfficials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOfficials.Image = ((System.Drawing.Image)(resources.GetObject("picOfficials.Image")));
            this.picOfficials.Location = new System.Drawing.Point(8, 8);
            this.picOfficials.Name = "picOfficials";
            this.picOfficials.Size = new System.Drawing.Size(21, 22);
            this.picOfficials.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOfficials.TabIndex = 9;
            this.picOfficials.TabStop = false;
            this.picOfficials.Click += new System.EventHandler(this.picOfficials_Click_1);
            this.picOfficials.MouseLeave += new System.EventHandler(this.picOfficials_MouseLeave);
            this.picOfficials.MouseHover += new System.EventHandler(this.picOfficials_MouseHover);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel3.Controls.Add(this.picApprovalDocs);
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 111);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(197, 35);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 13;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(44, 8);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(60, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Blotter";
            // 
            // picApprovalDocs
            // 
            this.picApprovalDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picApprovalDocs.Image = ((System.Drawing.Image)(resources.GetObject("picApprovalDocs.Image")));
            this.picApprovalDocs.Location = new System.Drawing.Point(8, 8);
            this.picApprovalDocs.Name = "picApprovalDocs";
            this.picApprovalDocs.Size = new System.Drawing.Size(21, 22);
            this.picApprovalDocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picApprovalDocs.TabIndex = 9;
            this.picApprovalDocs.TabStop = false;
            this.picApprovalDocs.Click += new System.EventHandler(this.picApprovalDocs_Click_1);
            this.picApprovalDocs.DragLeave += new System.EventHandler(this.picApprovalDocs_DragLeave);
            this.picApprovalDocs.MouseLeave += new System.EventHandler(this.picApprovalDocs_MouseLeave);
            this.picApprovalDocs.MouseHover += new System.EventHandler(this.picApprovalDocs_MouseHover);
            // 
            // pnlUserLogsIcon
            // 
            this.pnlUserLogsIcon.Controls.Add(this.kryptonLabel3);
            this.pnlUserLogsIcon.Controls.Add(this.picUserLogs);
            this.pnlUserLogsIcon.Location = new System.Drawing.Point(0, 37);
            this.pnlUserLogsIcon.Name = "pnlUserLogsIcon";
            this.pnlUserLogsIcon.Size = new System.Drawing.Size(197, 35);
            this.pnlUserLogsIcon.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlUserLogsIcon.TabIndex = 13;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(44, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(48, 23);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Logs";
            // 
            // picUserLogs
            // 
            this.picUserLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserLogs.Image = ((System.Drawing.Image)(resources.GetObject("picUserLogs.Image")));
            this.picUserLogs.Location = new System.Drawing.Point(8, 8);
            this.picUserLogs.Name = "picUserLogs";
            this.picUserLogs.Size = new System.Drawing.Size(21, 22);
            this.picUserLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserLogs.TabIndex = 5;
            this.picUserLogs.TabStop = false;
            this.picUserLogs.Click += new System.EventHandler(this.picUserLogs_Click_1);
            this.picUserLogs.MouseLeave += new System.EventHandler(this.picUserLogs_MouseLeave_1);
            this.picUserLogs.MouseHover += new System.EventHandler(this.picUserLogs_MouseHover_1);
            // 
            // pnlUserRequestocsIcon
            // 
            this.pnlUserRequestocsIcon.Controls.Add(this.kryptonLabel4);
            this.pnlUserRequestocsIcon.Controls.Add(this.picUserRequestDocs);
            this.pnlUserRequestocsIcon.Location = new System.Drawing.Point(0, 74);
            this.pnlUserRequestocsIcon.Name = "pnlUserRequestocsIcon";
            this.pnlUserRequestocsIcon.Size = new System.Drawing.Size(197, 35);
            this.pnlUserRequestocsIcon.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlUserRequestocsIcon.TabIndex = 12;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(44, 7);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(161, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Approve Documents";
            // 
            // picUserRequestDocs
            // 
            this.picUserRequestDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserRequestDocs.Image = ((System.Drawing.Image)(resources.GetObject("picUserRequestDocs.Image")));
            this.picUserRequestDocs.Location = new System.Drawing.Point(8, 8);
            this.picUserRequestDocs.Name = "picUserRequestDocs";
            this.picUserRequestDocs.Size = new System.Drawing.Size(21, 22);
            this.picUserRequestDocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserRequestDocs.TabIndex = 9;
            this.picUserRequestDocs.TabStop = false;
            this.picUserRequestDocs.Click += new System.EventHandler(this.picUserRequestDocs_Click_1);
            this.picUserRequestDocs.MouseLeave += new System.EventHandler(this.picUserRequestDocs_MouseLeave_1);
            this.picUserRequestDocs.MouseHover += new System.EventHandler(this.picUserRequestDocs_MouseHover_1);
            // 
            // pnlUserDashboardIcon
            // 
            this.pnlUserDashboardIcon.Controls.Add(this.kryptonLabel1);
            this.pnlUserDashboardIcon.Controls.Add(this.picUserDashboardIcon);
            this.pnlUserDashboardIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlUserDashboardIcon.Name = "pnlUserDashboardIcon";
            this.pnlUserDashboardIcon.Size = new System.Drawing.Size(197, 35);
            this.pnlUserDashboardIcon.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlUserDashboardIcon.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(44, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(92, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Dashboard";
            // 
            // picUserDashboardIcon
            // 
            this.picUserDashboardIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserDashboardIcon.Image = ((System.Drawing.Image)(resources.GetObject("picUserDashboardIcon.Image")));
            this.picUserDashboardIcon.Location = new System.Drawing.Point(8, 8);
            this.picUserDashboardIcon.Name = "picUserDashboardIcon";
            this.picUserDashboardIcon.Size = new System.Drawing.Size(21, 22);
            this.picUserDashboardIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserDashboardIcon.TabIndex = 4;
            this.picUserDashboardIcon.TabStop = false;
            this.picUserDashboardIcon.Click += new System.EventHandler(this.picUserDashboardIcon_Click_1);
            this.picUserDashboardIcon.MouseLeave += new System.EventHandler(this.picUserDashboardIcon_MouseLeave_1);
            this.picUserDashboardIcon.MouseHover += new System.EventHandler(this.picUserDashboardIcon_MouseHover_1);
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(10, 560);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(21, 22);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 8;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel6.Location = new System.Drawing.Point(39, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(1, 548);
            this.kryptonPanel6.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(224)))));
            this.kryptonPanel6.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 42);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1049, 548);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 6;
            // 
            // pnlTopSeperator
            // 
            this.pnlTopSeperator.Controls.Add(this.lblRole);
            this.pnlTopSeperator.Controls.Add(this.picProfilePic);
            this.pnlTopSeperator.Controls.Add(this.lblUsername);
            this.pnlTopSeperator.Controls.Add(this.picMenuButton);
            this.pnlTopSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSeperator.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSeperator.Name = "pnlTopSeperator";
            this.pnlTopSeperator.Size = new System.Drawing.Size(1049, 42);
            this.pnlTopSeperator.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlTopSeperator.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pnlTopSeperator.TabIndex = 4;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRole.Location = new System.Drawing.Point(63, 7);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(85, 23);
            this.lblRole.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.TabIndex = 2;
            this.lblRole.Values.Text = "Secretary";
            // 
            // picProfilePic
            // 
            this.picProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("picProfilePic.Image")));
            this.picProfilePic.Location = new System.Drawing.Point(988, 0);
            this.picProfilePic.Name = "picProfilePic";
            this.picProfilePic.Size = new System.Drawing.Size(43, 37);
            this.picProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfilePic.TabIndex = 1;
            this.picProfilePic.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Location = new System.Drawing.Point(866, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 23);
            this.lblUsername.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Values.Text = "Hi, Username";
            // 
            // picMenuButton
            // 
            this.picMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("picMenuButton.Image")));
            this.picMenuButton.InitialImage = null;
            this.picMenuButton.Location = new System.Drawing.Point(8, 8);
            this.picMenuButton.Name = "picMenuButton";
            this.picMenuButton.Size = new System.Drawing.Size(21, 22);
            this.picMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenuButton.TabIndex = 1;
            this.picMenuButton.TabStop = false;
            this.picMenuButton.Click += new System.EventHandler(this.picMenuButton_Click);
            this.picMenuButton.MouseLeave += new System.EventHandler(this.picMenuButton_MouseLeave);
            this.picMenuButton.MouseHover += new System.EventHandler(this.picMenuButton_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SercretaryPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 590);
            this.Controls.Add(this.pnlMainContainer);
            this.Name = "SercretaryPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SercretaryPageForm_FormClosing);
            this.Load += new System.EventHandler(this.SercretaryPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContainer)).EndInit();
            this.pnlMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterValueHolder)).EndInit();
            this.pnlFilterValueHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRighSeperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightSeperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSidebar)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserSidebar)).EndInit();
            this.pnlUserSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOfficials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApprovalDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserLogsIcon)).EndInit();
            this.pnlUserLogsIcon.ResumeLayout(false);
            this.pnlUserLogsIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserRequestocsIcon)).EndInit();
            this.pnlUserRequestocsIcon.ResumeLayout(false);
            this.pnlUserRequestocsIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserRequestDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserDashboardIcon)).EndInit();
            this.pnlUserDashboardIcon.ResumeLayout(false);
            this.pnlUserDashboardIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserDashboardIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTopSeperator)).EndInit();
            this.pnlTopSeperator.ResumeLayout(false);
            this.pnlTopSeperator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlMainContainer;
        private Krypton.Toolkit.KryptonPictureBox picMenuButton;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Column1;
        private Krypton.Toolkit.KryptonPanel pnlTopSeperator;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel lblUsername;
        private Krypton.Toolkit.KryptonPictureBox picProfilePic;
        private Krypton.Toolkit.KryptonLabel lblRole;
        private Krypton.Toolkit.KryptonPictureBox picAnnouncements;
        private Krypton.Toolkit.KryptonPictureBox picAccountVerification;
        private Krypton.Toolkit.KryptonPanel pnlFilterValueHolder;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlRighSeperator;
        private Krypton.Toolkit.KryptonPanel pnlRightSeperator;
        protected internal Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        protected internal Krypton.Toolkit.KryptonPanel pnlSidebar;
        private Krypton.Toolkit.KryptonPanel pnlUserSidebar;
        private Krypton.Toolkit.KryptonPanel pnlUserLogsIcon;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonPictureBox picUserLogs;
        private Krypton.Toolkit.KryptonPanel pnlUserRequestocsIcon;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonPictureBox picUserRequestDocs;
        private Krypton.Toolkit.KryptonPanel pnlUserDashboardIcon;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPictureBox picUserDashboardIcon;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonPictureBox picOfficials;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPictureBox picApprovalDocs;
        private Timer timer1;
    }
}