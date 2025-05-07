using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    partial class ResidentDashboardControls {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.dataGridResidentDash = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxOFficialsInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewOfficialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel7 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pnlAannouncementContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel8 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.lblDetails = new Krypton.Toolkit.KryptonLabel();
            this.lblDatePost = new Krypton.Toolkit.KryptonLabel();
            this.picAttachements = new Krypton.Toolkit.KryptonPictureBox();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.timerAnnouncementsContent = new System.Windows.Forms.Timer(this.components);
            this.timerAnnouncementLabel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResidentDash)).BeginInit();
            this.ctxOFficialsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAannouncementContent)).BeginInit();
            this.pnlAannouncementContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparator1.Location = new System.Drawing.Point(0, 48);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(809, 10);
            this.kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 587);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.AutoScroll = true;
            this.kryptonPanel6.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel6.Controls.Add(this.pnlAannouncementContent);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel6.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel6.TabIndex = 1;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.dataGridResidentDash);
            this.kryptonPanel5.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 356);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(812, 442);
            this.kryptonPanel5.TabIndex = 6;
            // 
            // dataGridResidentDash
            // 
            this.dataGridResidentDash.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridResidentDash.AllowDrop = true;
            this.dataGridResidentDash.AllowUserToAddRows = false;
            this.dataGridResidentDash.AllowUserToDeleteRows = false;
            this.dataGridResidentDash.AllowUserToResizeColumns = false;
            this.dataGridResidentDash.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridResidentDash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResidentDash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResidentDash.AutoGenerateKryptonColumns = false;
            this.dataGridResidentDash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResidentDash.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridResidentDash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridResidentDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResidentDash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colusername,
            this.colrole,
            this.colactions});
            this.dataGridResidentDash.ContextMenuStrip = this.ctxOFficialsInfo;
            this.dataGridResidentDash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridResidentDash.Location = new System.Drawing.Point(-3, 58);
            this.dataGridResidentDash.MultiSelect = false;
            this.dataGridResidentDash.Name = "dataGridResidentDash";
            this.dataGridResidentDash.RowHeadersVisible = false;
            this.dataGridResidentDash.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridResidentDash.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResidentDash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridResidentDash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResidentDash.Size = new System.Drawing.Size(815, 386);
            this.dataGridResidentDash.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridResidentDash.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridResidentDash.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridResidentDash.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridResidentDash.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridResidentDash.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridResidentDash.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridResidentDash.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridResidentDash.TabIndex = 19;
            this.dataGridResidentDash.ToolTipShadow = false;
            this.dataGridResidentDash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridResidentDash_MouseDown_1);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.HeaderText = "Fullname";
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            // 
            // colrole
            // 
            this.colrole.HeaderText = "Gender";
            this.colrole.Name = "colrole";
            this.colrole.ReadOnly = true;
            // 
            // colactions
            // 
            this.colactions.HeaderText = "Position";
            this.colactions.Name = "colactions";
            this.colactions.ReadOnly = true;
            // 
            // ctxOFficialsInfo
            // 
            this.ctxOFficialsInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxOFficialsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOfficialToolStripMenuItem});
            this.ctxOFficialsInfo.Name = "ctxOFficialsInfo";
            this.ctxOFficialsInfo.Size = new System.Drawing.Size(212, 26);
            this.ctxOFficialsInfo.Text = "Officials Information";
            // 
            // viewOfficialToolStripMenuItem
            // 
            this.viewOfficialToolStripMenuItem.Name = "viewOfficialToolStripMenuItem";
            this.viewOfficialToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.viewOfficialToolStripMenuItem.Text = "View Official Informations";
            this.viewOfficialToolStripMenuItem.Click += new System.EventHandler(this.viewOfficialToolStripMenuItem_Click);
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel7.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 3);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(809, 52);
            this.kryptonPanel7.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(64)))));
            this.kryptonPanel7.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(276, 10);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(226, 31);
            this.kryptonLabel1.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Officials";
            // 
            // pnlAannouncementContent
            // 
            this.pnlAannouncementContent.Controls.Add(this.kryptonPanel8);
            this.pnlAannouncementContent.Controls.Add(this.kryptonPanel4);
            this.pnlAannouncementContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAannouncementContent.Location = new System.Drawing.Point(0, 0);
            this.pnlAannouncementContent.Name = "pnlAannouncementContent";
            this.pnlAannouncementContent.Size = new System.Drawing.Size(812, 347);
            this.pnlAannouncementContent.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlAannouncementContent.TabIndex = 5;
            // 
            // kryptonPanel8
            // 
            this.kryptonPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel8.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel8.Location = new System.Drawing.Point(3, 8);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(809, 52);
            this.kryptonPanel8.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(64)))));
            this.kryptonPanel8.TabIndex = 6;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(276, 15);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(226, 31);
            this.kryptonLabel3.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Officials";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.lblDetails);
            this.kryptonPanel4.Controls.Add(this.lblDatePost);
            this.kryptonPanel4.Controls.Add(this.picAttachements);
            this.kryptonPanel4.Controls.Add(this.lblTitle);
            this.kryptonPanel4.Location = new System.Drawing.Point(95, 63);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(604, 281);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            this.kryptonPanel4.TabIndex = 0;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = false;
            this.lblDetails.Location = new System.Drawing.Point(0, 174);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(424, 96);
            this.lblDetails.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.lblDetails.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Values.Text = "Details";
            // 
            // lblDatePost
            // 
            this.lblDatePost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatePost.Location = new System.Drawing.Point(427, 240);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(47, 16);
            this.lblDatePost.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblDatePost.TabIndex = 2;
            this.lblDatePost.Values.Text = "Posted";
            // 
            // picAttachements
            // 
            this.picAttachements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAttachements.Location = new System.Drawing.Point(184, 40);
            this.picAttachements.Name = "picAttachements";
            this.picAttachements.Size = new System.Drawing.Size(240, 124);
            this.picAttachements.TabIndex = 1;
            this.picAttachements.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Location = new System.Drawing.Point(0, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(601, 31);
            this.lblTitle.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "Title";
            // 
            // pnlMainContentControler
            // 
            this.pnlMainContentControler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContentControler.Controls.Add(this.kryptonSeparator1);
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel1);
            this.pnlMainContentControler.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContentControler.Name = "pnlMainContentControler";
            this.pnlMainContentControler.Size = new System.Drawing.Size(809, 587);
            this.pnlMainContentControler.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(809, 49);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel3.Location = new System.Drawing.Point(3, 48);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(809, 517);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(119, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Dashboard";
            // 
            // timerAnnouncementsContent
            // 
            this.timerAnnouncementsContent.Interval = 3000;
            this.timerAnnouncementsContent.Tick += new System.EventHandler(this.timerAnnouncementsContent_Tick);
            // 
            // timerAnnouncementLabel
            // 
            this.timerAnnouncementLabel.Tick += new System.EventHandler(this.timerAnnouncementLabel_Tick);
            // 
            // ResidentDashboardControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "ResidentDashboardControls";
            this.Size = new System.Drawing.Size(809, 567);
            this.Load += new System.EventHandler(this.ResidentDashboardControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResidentDash)).EndInit();
            this.ctxOFficialsInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAannouncementContent)).EndInit();
            this.pnlAannouncementContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Timer timerAnnouncementsContent;
        private Timer timerAnnouncementLabel;
        private ContextMenuStrip ctxOFficialsInfo;
        private ToolStripMenuItem viewOfficialToolStripMenuItem;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonDataGridView dataGridResidentDash;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colactions;
        private Krypton.Toolkit.KryptonPanel pnlAannouncementContent;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel lblDetails;
        private Krypton.Toolkit.KryptonLabel lblDatePost;
        private Krypton.Toolkit.KryptonPictureBox picAttachements;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}
