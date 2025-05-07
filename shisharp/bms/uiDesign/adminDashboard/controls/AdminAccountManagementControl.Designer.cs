using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.controls {
    partial class AdminAccountManagementControl {
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
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnCreateSec = new Krypton.Toolkit.KryptonButton();
            this.dataGridAmTableAdmin = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxmenuAccManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAsBarangayOfficialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmTableAdmin)).BeginInit();
            this.ctxmenuAccManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparator1.Location = new System.Drawing.Point(-3, 68);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(809, 4);
            this.kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.btnCreateSec);
            this.kryptonPanel1.Controls.Add(this.dataGridAmTableAdmin);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnCreateSec
            // 
            this.btnCreateSec.Location = new System.Drawing.Point(21, 52);
            this.btnCreateSec.Name = "btnCreateSec";
            this.btnCreateSec.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCreateSec.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateSec.OverrideDefault.Border.Rounding = 5F;
            this.btnCreateSec.OverrideDefault.Border.Width = 1;
            this.btnCreateSec.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateSec.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateSec.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCreateSec.Size = new System.Drawing.Size(141, 39);
            this.btnCreateSec.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateCommon.Back.ColorAngle = 45F;
            this.btnCreateSec.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreateSec.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreateSec.StateCommon.Border.ColorAngle = 45F;
            this.btnCreateSec.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateSec.StateCommon.Border.Rounding = 5F;
            this.btnCreateSec.StateCommon.Border.Width = 1;
            this.btnCreateSec.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateSec.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateSec.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSec.StateDisabled.Border.Rounding = 5F;
            this.btnCreateSec.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateNormal.Border.Rounding = 5F;
            this.btnCreateSec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateSec.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateSec.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCreateSec.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCreateSec.StatePressed.Back.ColorAngle = 130F;
            this.btnCreateSec.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnCreateSec.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnCreateSec.StatePressed.Border.ColorAngle = 130F;
            this.btnCreateSec.StatePressed.Border.Rounding = 5F;
            this.btnCreateSec.StatePressed.Border.Width = 1;
            this.btnCreateSec.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnCreateSec.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnCreateSec.StateTracking.Back.ColorAngle = 45F;
            this.btnCreateSec.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreateSec.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateTracking.Border.ColorAngle = 45F;
            this.btnCreateSec.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateSec.StateTracking.Border.Rounding = 5F;
            this.btnCreateSec.StateTracking.Border.Width = 1;
            this.btnCreateSec.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreateSec.TabIndex = 39;
            this.btnCreateSec.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCreateSec.Values.Text = "Create Account";
            this.btnCreateSec.Click += new System.EventHandler(this.btnCreateSec_Click_1);
            // 
            // dataGridAmTableAdmin
            // 
            this.dataGridAmTableAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridAmTableAdmin.AllowDrop = true;
            this.dataGridAmTableAdmin.AllowUserToAddRows = false;
            this.dataGridAmTableAdmin.AllowUserToDeleteRows = false;
            this.dataGridAmTableAdmin.AllowUserToResizeColumns = false;
            this.dataGridAmTableAdmin.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAmTableAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAmTableAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAmTableAdmin.AutoGenerateKryptonColumns = false;
            this.dataGridAmTableAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAmTableAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAmTableAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAmTableAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAmTableAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colemail,
            this.colusername,
            this.colrole,
            this.colfullname,
            this.colgender,
            this.colbday,
            this.colage,
            this.colcontact});
            this.dataGridAmTableAdmin.ContextMenuStrip = this.ctxmenuAccManagement;
            this.dataGridAmTableAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAmTableAdmin.Location = new System.Drawing.Point(21, 122);
            this.dataGridAmTableAdmin.MultiSelect = false;
            this.dataGridAmTableAdmin.Name = "dataGridAmTableAdmin";
            this.dataGridAmTableAdmin.RowHeadersVisible = false;
            this.dataGridAmTableAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAmTableAdmin.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAmTableAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAmTableAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAmTableAdmin.Size = new System.Drawing.Size(765, 363);
            this.dataGridAmTableAdmin.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridAmTableAdmin.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridAmTableAdmin.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAmTableAdmin.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAmTableAdmin.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAmTableAdmin.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAmTableAdmin.TabIndex = 18;
            this.dataGridAmTableAdmin.ToolTipShadow = false;
            this.dataGridAmTableAdmin.VirtualMode = true;
            this.dataGridAmTableAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridAmTableAdmin_MouseDown);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // colemail
            // 
            this.colemail.HeaderText = "Email";
            this.colemail.Name = "colemail";
            this.colemail.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.HeaderText = "Username";
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            // 
            // colrole
            // 
            this.colrole.HeaderText = "Role";
            this.colrole.Name = "colrole";
            this.colrole.ReadOnly = true;
            // 
            // colfullname
            // 
            this.colfullname.HeaderText = "Fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.ReadOnly = true;
            // 
            // colgender
            // 
            this.colgender.HeaderText = "Gender";
            this.colgender.Name = "colgender";
            this.colgender.ReadOnly = true;
            // 
            // colbday
            // 
            this.colbday.HeaderText = "Birthday";
            this.colbday.Name = "colbday";
            this.colbday.ReadOnly = true;
            // 
            // colage
            // 
            this.colage.HeaderText = "Age";
            this.colage.Name = "colage";
            this.colage.ReadOnly = true;
            // 
            // colcontact
            // 
            this.colcontact.HeaderText = "Contact No.";
            this.colcontact.Name = "colcontact";
            this.colcontact.ReadOnly = true;
            // 
            // ctxmenuAccManagement
            // 
            this.ctxmenuAccManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxmenuAccManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.addAsBarangayOfficialsToolStripMenuItem});
            this.ctxmenuAccManagement.Name = "contextMenuStrip1";
            this.ctxmenuAccManagement.Size = new System.Drawing.Size(211, 48);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.actionsToolStripMenuItem.Text = "Update Account";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click_1);
            // 
            // addAsBarangayOfficialsToolStripMenuItem
            // 
            this.addAsBarangayOfficialsToolStripMenuItem.Name = "addAsBarangayOfficialsToolStripMenuItem";
            this.addAsBarangayOfficialsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.addAsBarangayOfficialsToolStripMenuItem.Text = "Add As Barangay Officials";
            this.addAsBarangayOfficialsToolStripMenuItem.Click += new System.EventHandler(this.addAsBarangayOfficialsToolStripMenuItem_Click_1);
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
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.kryptonLabel2.Location = new System.Drawing.Point(31, 33);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(224, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Account Management";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // AdminAccountManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "AdminAccountManagementControl";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.AdminAccountManagementControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmTableAdmin)).EndInit();
            this.ctxmenuAccManagement.ResumeLayout(false);
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
        private ContextMenuStrip ctxmenuAccManagement;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colfullname;
        private DataGridViewTextBoxColumn colgender;
        private DataGridViewTextBoxColumn colbday;
        private DataGridViewTextBoxColumn colage;
        private DataGridViewTextBoxColumn colcontact;
        protected internal Krypton.Toolkit.KryptonDataGridView dataGridAmTableAdmin;
        private Krypton.Toolkit.KryptonButton btnCreateSec;
        private ToolStripMenuItem addAsBarangayOfficialsToolStripMenuItem;
        private Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
    }
}
