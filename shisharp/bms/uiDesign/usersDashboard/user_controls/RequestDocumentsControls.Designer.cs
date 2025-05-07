using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    partial class RequestDocumentsControls {
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
            this.btnLogin = new Krypton.Toolkit.KryptonButton();
            this.dataGridAdminDashboard = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaffectedtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ctxResidentRequestDocs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateRequestDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.ctxResidentRequestDocs.SuspendLayout();
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
            this.kryptonPanel1.Controls.Add(this.btnLogin);
            this.kryptonPanel1.Controls.Add(this.dataGridAdminDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(27, 39);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            this.btnLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.OverrideDefault.Border.Rounding = 5F;
            this.btnLogin.OverrideDefault.Border.Width = 1;
            this.btnLogin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLogin.Size = new System.Drawing.Size(141, 39);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateCommon.Back.ColorAngle = 45F;
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLogin.StateCommon.Border.ColorAngle = 45F;
            this.btnLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.StateCommon.Border.Rounding = 5F;
            this.btnLogin.StateCommon.Border.Width = 1;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateDisabled.Border.Rounding = 5F;
            this.btnLogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateNormal.Border.Rounding = 5F;
            this.btnLogin.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnLogin.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnLogin.StatePressed.Back.ColorAngle = 130F;
            this.btnLogin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnLogin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnLogin.StatePressed.Border.ColorAngle = 130F;
            this.btnLogin.StatePressed.Border.Rounding = 5F;
            this.btnLogin.StatePressed.Border.Width = 1;
            this.btnLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.StateTracking.Back.ColorAngle = 45F;
            this.btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateTracking.Border.ColorAngle = 45F;
            this.btnLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.StateTracking.Border.Rounding = 5F;
            this.btnLogin.StateTracking.Border.Width = 1;
            this.btnLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLogin.Values.Text = "Request";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // dataGridAdminDashboard
            // 
            this.dataGridAdminDashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridAdminDashboard.AllowDrop = true;
            this.dataGridAdminDashboard.AllowUserToAddRows = false;
            this.dataGridAdminDashboard.AllowUserToDeleteRows = false;
            this.dataGridAdminDashboard.AllowUserToResizeColumns = false;
            this.dataGridAdminDashboard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAdminDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAdminDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAdminDashboard.AutoGenerateKryptonColumns = false;
            this.dataGridAdminDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAdminDashboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAdminDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAdminDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colusername,
            this.colrole,
            this.colactions,
            this.colaffectedtable});
            this.dataGridAdminDashboard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAdminDashboard.Location = new System.Drawing.Point(31, 116);
            this.dataGridAdminDashboard.MultiSelect = false;
            this.dataGridAdminDashboard.Name = "dataGridAdminDashboard";
            this.dataGridAdminDashboard.RowHeadersVisible = false;
            this.dataGridAdminDashboard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAdminDashboard.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAdminDashboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAdminDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAdminDashboard.Size = new System.Drawing.Size(765, 368);
            this.dataGridAdminDashboard.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridAdminDashboard.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridAdminDashboard.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAdminDashboard.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAdminDashboard.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAdminDashboard.TabIndex = 18;
            this.dataGridAdminDashboard.ToolTipShadow = false;
            this.dataGridAdminDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridAdminDashboard_MouseDown);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.HeaderText = "Document Type";
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            // 
            // colrole
            // 
            this.colrole.HeaderText = "Status";
            this.colrole.Name = "colrole";
            this.colrole.ReadOnly = true;
            // 
            // colactions
            // 
            this.colactions.HeaderText = "Request Date";
            this.colactions.Name = "colactions";
            this.colactions.ReadOnly = true;
            // 
            // colaffectedtable
            // 
            this.colaffectedtable.HeaderText = "Purpose";
            this.colaffectedtable.Name = "colaffectedtable";
            this.colaffectedtable.ReadOnly = true;
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
            this.kryptonLabel2.Size = new System.Drawing.Size(209, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Request Documents";
            // 
            // ctxResidentRequestDocs
            // 
            this.ctxResidentRequestDocs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxResidentRequestDocs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRequestDocumentToolStripMenuItem});
            this.ctxResidentRequestDocs.Name = "ctxResidentRequestDocs";
            this.ctxResidentRequestDocs.Size = new System.Drawing.Size(217, 26);
            // 
            // updateRequestDocumentToolStripMenuItem
            // 
            this.updateRequestDocumentToolStripMenuItem.Name = "updateRequestDocumentToolStripMenuItem";
            this.updateRequestDocumentToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.updateRequestDocumentToolStripMenuItem.Text = "Update Request Document";
            this.updateRequestDocumentToolStripMenuItem.Click += new System.EventHandler(this.updateRequestDocumentToolStripMenuItem_Click);
            // 
            // RequestDocumentsControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "RequestDocumentsControls";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.RequestDocumentsControls_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ctxResidentRequestDocs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDataGridView dataGridAdminDashboard;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colactions;
        private DataGridViewTextBoxColumn colaffectedtable;
        private ContextMenuStrip ctxResidentRequestDocs;
        private ToolStripMenuItem updateRequestDocumentToolStripMenuItem;
    }
}
