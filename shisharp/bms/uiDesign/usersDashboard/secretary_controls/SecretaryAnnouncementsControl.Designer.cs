using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    partial class SecretaryAnnouncementsControl{
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
            this.btnPostAnnouncement = new Krypton.Toolkit.KryptonButton();
            this.dataGridBlotterTable = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxBlotter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateBlotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBlotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlotterTable)).BeginInit();
            this.ctxBlotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparator1.Location = new System.Drawing.Point(-3, 68);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(809, 4);
            this.kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.btnPostAnnouncement);
            this.kryptonPanel1.Controls.Add(this.dataGridBlotterTable);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnPostAnnouncement
            // 
            this.btnPostAnnouncement.Location = new System.Drawing.Point(31, 56);
            this.btnPostAnnouncement.Name = "btnPostAnnouncement";
            this.btnPostAnnouncement.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.OverrideDefault.Back.ColorAngle = 45F;
            this.btnPostAnnouncement.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPostAnnouncement.OverrideDefault.Border.Rounding = 5F;
            this.btnPostAnnouncement.OverrideDefault.Border.Width = 1;
            this.btnPostAnnouncement.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPostAnnouncement.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPostAnnouncement.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPostAnnouncement.Size = new System.Drawing.Size(194, 43);
            this.btnPostAnnouncement.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateCommon.Back.ColorAngle = 45F;
            this.btnPostAnnouncement.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPostAnnouncement.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPostAnnouncement.StateCommon.Border.ColorAngle = 45F;
            this.btnPostAnnouncement.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPostAnnouncement.StateCommon.Border.Rounding = 5F;
            this.btnPostAnnouncement.StateCommon.Border.Width = 1;
            this.btnPostAnnouncement.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPostAnnouncement.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPostAnnouncement.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostAnnouncement.StateDisabled.Border.Rounding = 5F;
            this.btnPostAnnouncement.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateNormal.Border.Rounding = 5F;
            this.btnPostAnnouncement.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPostAnnouncement.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPostAnnouncement.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnPostAnnouncement.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnPostAnnouncement.StatePressed.Back.ColorAngle = 130F;
            this.btnPostAnnouncement.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnPostAnnouncement.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnPostAnnouncement.StatePressed.Border.ColorAngle = 130F;
            this.btnPostAnnouncement.StatePressed.Border.Rounding = 5F;
            this.btnPostAnnouncement.StatePressed.Border.Width = 1;
            this.btnPostAnnouncement.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnPostAnnouncement.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnPostAnnouncement.StateTracking.Back.ColorAngle = 45F;
            this.btnPostAnnouncement.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPostAnnouncement.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateTracking.Border.ColorAngle = 45F;
            this.btnPostAnnouncement.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPostAnnouncement.StateTracking.Border.Rounding = 5F;
            this.btnPostAnnouncement.StateTracking.Border.Width = 1;
            this.btnPostAnnouncement.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPostAnnouncement.TabIndex = 38;
            this.btnPostAnnouncement.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPostAnnouncement.Values.Text = "Post Announcement";
            this.btnPostAnnouncement.Click += new System.EventHandler(this.btnPostAnnouncement_Click);
            // 
            // dataGridBlotterTable
            // 
            this.dataGridBlotterTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridBlotterTable.AllowDrop = true;
            this.dataGridBlotterTable.AllowUserToAddRows = false;
            this.dataGridBlotterTable.AllowUserToDeleteRows = false;
            this.dataGridBlotterTable.AllowUserToResizeColumns = false;
            this.dataGridBlotterTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridBlotterTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBlotterTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBlotterTable.AutoGenerateKryptonColumns = false;
            this.dataGridBlotterTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBlotterTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBlotterTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBlotterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBlotterTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dataGridBlotterTable.ContextMenuStrip = this.ctxBlotter;
            this.dataGridBlotterTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridBlotterTable.Location = new System.Drawing.Point(31, 120);
            this.dataGridBlotterTable.MultiSelect = false;
            this.dataGridBlotterTable.Name = "dataGridBlotterTable";
            this.dataGridBlotterTable.RowHeadersVisible = false;
            this.dataGridBlotterTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridBlotterTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBlotterTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBlotterTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBlotterTable.Size = new System.Drawing.Size(765, 364);
            this.dataGridBlotterTable.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridBlotterTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridBlotterTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridBlotterTable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridBlotterTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridBlotterTable.TabIndex = 18;
            this.dataGridBlotterTable.ToolTipShadow = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.HeaderText = "Complainant ID";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Respondent ID";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "Status";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.HeaderText = "Statements";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // col5
            // 
            this.col5.HeaderText = "Date Filed";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            // 
            // ctxBlotter
            // 
            this.ctxBlotter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxBlotter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBlotterToolStripMenuItem,
            this.deleteBlotterToolStripMenuItem});
            this.ctxBlotter.Name = "ctxBlotter";
            this.ctxBlotter.Size = new System.Drawing.Size(151, 48);
            // 
            // updateBlotterToolStripMenuItem
            // 
            this.updateBlotterToolStripMenuItem.Name = "updateBlotterToolStripMenuItem";
            this.updateBlotterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.updateBlotterToolStripMenuItem.Text = "Update Blotter";
            // 
            // deleteBlotterToolStripMenuItem
            // 
            this.deleteBlotterToolStripMenuItem.Name = "deleteBlotterToolStripMenuItem";
            this.deleteBlotterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteBlotterToolStripMenuItem.Text = "Delete Blotter";
            // 
            // pnlMainContentControler
            // 
            this.pnlMainContentControler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel1);
            this.pnlMainContentControler.Location = new System.Drawing.Point(0, -30);
            this.pnlMainContentControler.Name = "pnlMainContentControler";
            this.pnlMainContentControler.Size = new System.Drawing.Size(809, 587);
            this.pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.kryptonSeparator1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(809, 69);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel2.Location = new System.Drawing.Point(31, 38);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(302, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Announcements Management";
            // 
            // SecretaryAnnouncementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "SecretaryAnnouncementsControl";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.SecretaryAnnouncementsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlotterTable)).EndInit();
            this.ctxBlotter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnPostAnnouncement;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col5;
        protected internal Krypton.Toolkit.KryptonDataGridView dataGridBlotterTable;
        private ContextMenuStrip ctxBlotter;
        private ToolStripMenuItem updateBlotterToolStripMenuItem;
        private ToolStripMenuItem deleteBlotterToolStripMenuItem;
    }
}
