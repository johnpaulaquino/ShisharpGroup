namespace BrgyMS.uiDesign.adminDashboard.controls {
    partial class AdminAccountVerification {
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nudAvLimit = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            dataGridAmTable = new Krypton.Toolkit.KryptonDataGridView();
            id = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            colfullname = new DataGridViewTextBoxColumn();
            colgender = new DataGridViewTextBoxColumn();
            colcaddress = new DataGridViewTextBoxColumn();
            ctxAccountVerification = new ContextMenuStrip(components);
            atsVerfiyAccount = new ToolStripMenuItem();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAmTable).BeginInit();
            ctxAccountVerification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).BeginInit();
            pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // nudAvLimit
            // 
            nudAvLimit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudAvLimit.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudAvLimit.Location = new Point(86, 33);
            nudAvLimit.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudAvLimit.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAvLimit.Name = "nudAvLimit";
            nudAvLimit.Size = new Size(55, 22);
            nudAvLimit.TabIndex = 13;
            nudAvLimit.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudAvLimit.ValueChanged += nudLimit_ValueChanged;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel3.Location = new Point(36, 35);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(44, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel3.TabIndex = 12;
            kryptonLabel3.Values.Text = "Show";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel4.Location = new Point(147, 35);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(53, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel4.TabIndex = 14;
            kryptonLabel4.Values.Text = "Entries";
            // 
            // kryptonSeparator1
            // 
            kryptonSeparator1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonSeparator1.Location = new Point(-3, 78);
            kryptonSeparator1.Name = "kryptonSeparator1";
            kryptonSeparator1.Size = new Size(1125, 5);
            kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(dataGridAmTable);
            kryptonPanel1.Controls.Add(txtSearch);
            kryptonPanel1.Controls.Add(nudAvLimit);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Location = new Point(0, 83);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1125, 594);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // dataGridAmTable
            // 
            dataGridAmTable.AccessibleRole = AccessibleRole.None;
            dataGridAmTable.AllowDrop = true;
            dataGridAmTable.AllowUserToAddRows = false;
            dataGridAmTable.AllowUserToDeleteRows = false;
            dataGridAmTable.AllowUserToResizeColumns = false;
            dataGridAmTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridAmTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAmTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAmTable.AutoGenerateKryptonColumns = false;
            dataGridAmTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAmTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridAmTable.BorderStyle = BorderStyle.None;
            dataGridAmTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAmTable.Columns.AddRange(new DataGridViewColumn[] { id, colemail, colfullname, colgender, colcaddress });
            dataGridAmTable.ContextMenuStrip = ctxAccountVerification;
            dataGridAmTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridAmTable.Location = new Point(26, 98);
            dataGridAmTable.MultiSelect = false;
            dataGridAmTable.Name = "dataGridAmTable";
            dataGridAmTable.RowHeadersVisible = false;
            dataGridAmTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridAmTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridAmTable.ScrollBars = ScrollBars.Vertical;
            dataGridAmTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAmTable.Size = new Size(1073, 480);
            dataGridAmTable.StateCommon.Background.Color1 = Color.White;
            dataGridAmTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dataGridAmTable.StateCommon.DataCell.Border.Color1 = Color.DimGray;
            dataGridAmTable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridAmTable.StateCommon.DataCell.Content.Padding = new Padding(10);
            dataGridAmTable.StateCommon.HeaderColumn.Back.Color1 = Color.White;
            dataGridAmTable.StateCommon.HeaderColumn.Back.Color2 = Color.White;
            dataGridAmTable.StateCommon.HeaderColumn.Border.Color1 = Color.DimGray;
            dataGridAmTable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridAmTable.StateCommon.HeaderColumn.Border.Width = 2;
            dataGridAmTable.StateCommon.HeaderColumn.Content.Color1 = Color.DimGray;
            dataGridAmTable.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridAmTable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridAmTable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridAmTable.TabIndex = 18;
            dataGridAmTable.ToolTipShadow = false;
            dataGridAmTable.VirtualMode = true;
            dataGridAmTable.MouseDown += dataGridAdminDashboard_MouseDown;
            // 
            // id
            // 
            id.FillWeight = 50F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.HeaderText = "Email";
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // colfullname
            // 
            colfullname.HeaderText = "Fullname";
            colfullname.Name = "colfullname";
            colfullname.ReadOnly = true;
            // 
            // colgender
            // 
            colgender.HeaderText = "Gender";
            colgender.Name = "colgender";
            colgender.ReadOnly = true;
            // 
            // colcaddress
            // 
            colcaddress.FillWeight = 200F;
            colcaddress.HeaderText = "Address";
            colcaddress.Name = "colcaddress";
            colcaddress.ReadOnly = true;
            // 
            // ctxAccountVerification
            // 
            ctxAccountVerification.Font = new Font("Segoe UI", 9F);
            ctxAccountVerification.Items.AddRange(new ToolStripItem[] { atsVerfiyAccount });
            ctxAccountVerification.Name = "ctxAccountVerification";
            ctxAccountVerification.Size = new Size(202, 34);
            // 
            // atsVerfiyAccount
            // 
            atsVerfiyAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atsVerfiyAccount.Name = "atsVerfiyAccount";
            atsVerfiyAccount.Size = new Size(201, 30);
            atsVerfiyAccount.Text = "Verify Account";
            atsVerfiyAccount.Click += atsVerfiyAccount_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(688, 20);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(411, 40);
            txtSearch.StateCommon.Content.Color1 = Color.Gray;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.StateCommon.Content.Padding = new Padding(5, -1, 5, 15);
            txtSearch.TabIndex = 17;
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlMainContentControler
            // 
            pnlMainContentControler.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlMainContentControler.Controls.Add(kryptonPanel2);
            pnlMainContentControler.Controls.Add(kryptonPanel1);
            pnlMainContentControler.Location = new Point(0, 0);
            pnlMainContentControler.Name = "pnlMainContentControler";
            pnlMainContentControler.Size = new Size(1125, 677);
            pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel2.Controls.Add(kryptonSeparator1);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1125, 80);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel2.Location = new Point(36, 30);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(224, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Account Management";
            // 
            // AdminAccountVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContentControler);
            Name = "AdminAccountVerification";
            Size = new Size(1125, 677);
            Load += AdminAccountVerification_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAmTable).EndInit();
            ctxAccountVerification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).EndInit();
            pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn colfullname;
        private DataGridViewTextBoxColumn colgender;
        private DataGridViewTextBoxColumn colcaddress;
        private ContextMenuStrip ctxAccountVerification;
        private ToolStripMenuItem atsVerfiyAccount;
        protected internal Krypton.Toolkit.KryptonDataGridView dataGridAmTable;
        protected internal Krypton.Toolkit.KryptonNumericUpDown nudAvLimit;
    }
}
