using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    partial class ResDashboard {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctxmenuAccManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.pnlAannouncementContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.lblDetails = new Krypton.Toolkit.KryptonLabel();
            this.lblDatePost = new Krypton.Toolkit.KryptonLabel();
            this.picAttachements = new Krypton.Toolkit.KryptonPictureBox();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.dataGridResidentDash = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAnnouncementLabel = new Krypton.Toolkit.KryptonPanel();
            this.lblAnnouncement = new Krypton.Toolkit.KryptonLabel();
            this.ctxmenuAccManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAannouncementContent)).BeginInit();
            this.pnlAannouncementContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResidentDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAnnouncementLabel)).BeginInit();
            this.pnlAnnouncementLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxmenuAccManagement
            // 
            this.ctxmenuAccManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxmenuAccManagement.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxmenuAccManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.ctxmenuAccManagement.Name = "contextMenuStrip1";
            this.ctxmenuAccManagement.Size = new System.Drawing.Size(161, 26);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.actionsToolStripMenuItem.Text = "Update Account";
            // 
            // pnlMainContentControler
            // 
            this.pnlMainContentControler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContentControler.AutoScroll = true;
            this.pnlMainContentControler.Controls.Add(this.pnlAannouncementContent);
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentControler.Location = new System.Drawing.Point(0, -30);
            this.pnlMainContentControler.Name = "pnlMainContentControler";
            this.pnlMainContentControler.Size = new System.Drawing.Size(809, 587);
            this.pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.kryptonSeparator1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(812, 69);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 38);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(119, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Dashboard";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparator1.Location = new System.Drawing.Point(0, 65);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(812, 4);
            this.kryptonSeparator1.TabIndex = 4;
            // 
            // pnlAannouncementContent
            // 
            this.pnlAannouncementContent.AutoScroll = true;
            this.pnlAannouncementContent.Controls.Add(this.kryptonPanel4);
            this.pnlAannouncementContent.Location = new System.Drawing.Point(3, 72);
            this.pnlAannouncementContent.Name = "pnlAannouncementContent";
            this.pnlAannouncementContent.Size = new System.Drawing.Size(809, 484);
            this.pnlAannouncementContent.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlAannouncementContent.TabIndex = 8;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel5.Controls.Add(this.lblDetails);
            this.kryptonPanel5.Controls.Add(this.lblDatePost);
            this.kryptonPanel5.Controls.Add(this.picAttachements);
            this.kryptonPanel5.Controls.Add(this.lblTitle);
            this.kryptonPanel5.Location = new System.Drawing.Point(142, 63);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(604, 231);
            this.kryptonPanel5.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            this.kryptonPanel5.TabIndex = 0;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = false;
            this.lblDetails.Location = new System.Drawing.Point(0, 144);
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
            this.lblDatePost.Location = new System.Drawing.Point(427, 182);
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
            this.picAttachements.Location = new System.Drawing.Point(232, 40);
            this.picAttachements.Name = "picAttachements";
            this.picAttachements.Size = new System.Drawing.Size(145, 89);
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
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.pnlAnnouncementLabel);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel4.Location = new System.Drawing.Point(8, 8);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(809, 481);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 7;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(this.dataGridResidentDash);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 300);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 181);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // dataGridResidentDash
            // 
            this.dataGridResidentDash.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridResidentDash.AllowDrop = true;
            this.dataGridResidentDash.AllowUserToAddRows = false;
            this.dataGridResidentDash.AllowUserToDeleteRows = false;
            this.dataGridResidentDash.AllowUserToResizeColumns = false;
            this.dataGridResidentDash.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridResidentDash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridResidentDash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridResidentDash.Location = new System.Drawing.Point(0, 57);
            this.dataGridResidentDash.MultiSelect = false;
            this.dataGridResidentDash.Name = "dataGridResidentDash";
            this.dataGridResidentDash.RowHeadersVisible = false;
            this.dataGridResidentDash.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridResidentDash.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridResidentDash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridResidentDash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResidentDash.Size = new System.Drawing.Size(809, 164);
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
            this.dataGridResidentDash.TabIndex = 22;
            this.dataGridResidentDash.ToolTipShadow = false;
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
            // pnlAnnouncementLabel
            // 
            this.pnlAnnouncementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAnnouncementLabel.Controls.Add(this.lblAnnouncement);
            this.pnlAnnouncementLabel.Location = new System.Drawing.Point(12, 14);
            this.pnlAnnouncementLabel.Name = "pnlAnnouncementLabel";
            this.pnlAnnouncementLabel.Size = new System.Drawing.Size(786, 52);
            this.pnlAnnouncementLabel.TabIndex = 2;
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = false;
            this.lblAnnouncement.Location = new System.Drawing.Point(282, 12);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(226, 31);
            this.lblAnnouncement.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.lblAnnouncement.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncement.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAnnouncement.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAnnouncement.TabIndex = 4;
            this.lblAnnouncement.Values.Text = "Announcements";
            // 
            // ResDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "ResDashboard";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.ResDashboard_Load);
            this.ctxmenuAccManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAannouncementContent)).EndInit();
            this.pnlAannouncementContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResidentDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAnnouncementLabel)).EndInit();
            this.pnlAnnouncementLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ContextMenuStrip ctxmenuAccManagement;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel pnlAannouncementContent;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel lblDetails;
        private Krypton.Toolkit.KryptonLabel lblDatePost;
        private Krypton.Toolkit.KryptonPictureBox picAttachements;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dataGridResidentDash;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colactions;
        private Krypton.Toolkit.KryptonPanel pnlAnnouncementLabel;
        private Krypton.Toolkit.KryptonLabel lblAnnouncement;
    }
}
