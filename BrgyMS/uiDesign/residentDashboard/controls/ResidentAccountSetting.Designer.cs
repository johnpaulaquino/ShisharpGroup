namespace BrgyMS.uiDesign.residentDashboard.controls {
    partial class ResidentAccountSetting {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pnlAsMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            pnlAsControlHolder = new Krypton.Toolkit.KryptonPanel();
            pnlAsNavigator = new Krypton.Toolkit.KryptonPanel();
            pnlNavAddressInfoHolder = new Krypton.Toolkit.KryptonPanel();
            lblAddressInfo = new Krypton.Toolkit.KryptonLabel();
            pnlNavAdditionalInfoHolder = new Krypton.Toolkit.KryptonPanel();
            lblAdditionalInfo = new Krypton.Toolkit.KryptonLabel();
            pnlNavPersonalInfoHolder = new Krypton.Toolkit.KryptonPanel();
            lbbPersonalInfo = new Krypton.Toolkit.KryptonLabel();
            ctxmenuAccManagement = new ContextMenuStrip(components);
            actionsToolStripMenuItem = new ToolStripMenuItem();
            pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlAsMainContentHolder).BeginInit();
            pnlAsMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlAsControlHolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlAsNavigator).BeginInit();
            pnlAsNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlNavAddressInfoHolder).BeginInit();
            pnlNavAddressInfoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlNavAdditionalInfoHolder).BeginInit();
            pnlNavAdditionalInfoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlNavPersonalInfoHolder).BeginInit();
            pnlNavPersonalInfoHolder.SuspendLayout();
            ctxmenuAccManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).BeginInit();
            pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.Controls.Add(pnlAsMainContentHolder);
            kryptonPanel1.Controls.Add(pnlAsNavigator);
            kryptonPanel1.Location = new Point(0, 83);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1125, 594);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // pnlAsMainContentHolder
            // 
            pnlAsMainContentHolder.Controls.Add(btnLogin);
            pnlAsMainContentHolder.Controls.Add(pnlAsControlHolder);
            pnlAsMainContentHolder.Dock = DockStyle.Bottom;
            pnlAsMainContentHolder.Location = new Point(0, 62);
            pnlAsMainContentHolder.Name = "pnlAsMainContentHolder";
            pnlAsMainContentHolder.Size = new Size(1125, 532);
            pnlAsMainContentHolder.StateCommon.Color1 = Color.White;
            pnlAsMainContentHolder.TabIndex = 4;
            // 
            // pnlAsControlHolder
            // 
            pnlAsControlHolder.AutoScroll = true;
            pnlAsControlHolder.Location = new Point(398, 3);
            pnlAsControlHolder.Name = "pnlAsControlHolder";
            pnlAsControlHolder.Size = new Size(420, 420);
            pnlAsControlHolder.TabIndex = 0;
            pnlAsControlHolder.Paint += pnlAsControlHolder_Paint;
            // 
            // pnlAsNavigator
            // 
            pnlAsNavigator.Controls.Add(pnlNavAddressInfoHolder);
            pnlAsNavigator.Controls.Add(pnlNavAdditionalInfoHolder);
            pnlAsNavigator.Controls.Add(pnlNavPersonalInfoHolder);
            pnlAsNavigator.Location = new Point(3, 6);
            pnlAsNavigator.Name = "pnlAsNavigator";
            pnlAsNavigator.Size = new Size(1119, 50);
            pnlAsNavigator.StateCommon.Color1 = Color.White;
            pnlAsNavigator.TabIndex = 0;
            // 
            // pnlNavAddressInfoHolder
            // 
            pnlNavAddressInfoHolder.Controls.Add(lblAddressInfo);
            pnlNavAddressInfoHolder.Cursor = Cursors.Hand;
            pnlNavAddressInfoHolder.Location = new Point(426, 0);
            pnlNavAddressInfoHolder.Name = "pnlNavAddressInfoHolder";
            pnlNavAddressInfoHolder.Size = new Size(200, 50);
            pnlNavAddressInfoHolder.StateCommon.Color1 = Color.White;
            pnlNavAddressInfoHolder.TabIndex = 4;
            // 
            // lblAddressInfo
            // 
            lblAddressInfo.Cursor = Cursors.Hand;
            lblAddressInfo.Location = new Point(22, 14);
            lblAddressInfo.Name = "lblAddressInfo";
            lblAddressInfo.Size = new Size(159, 23);
            lblAddressInfo.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressInfo.TabIndex = 1;
            lblAddressInfo.Values.Text = "Address Information";
            // 
            // pnlNavAdditionalInfoHolder
            // 
            pnlNavAdditionalInfoHolder.Controls.Add(lblAdditionalInfo);
            pnlNavAdditionalInfoHolder.Cursor = Cursors.Hand;
            pnlNavAdditionalInfoHolder.Location = new Point(220, 0);
            pnlNavAdditionalInfoHolder.Name = "pnlNavAdditionalInfoHolder";
            pnlNavAdditionalInfoHolder.Size = new Size(200, 50);
            pnlNavAdditionalInfoHolder.StateCommon.Color1 = Color.White;
            pnlNavAdditionalInfoHolder.TabIndex = 3;
            // 
            // lblAdditionalInfo
            // 
            lblAdditionalInfo.Cursor = Cursors.Hand;
            lblAdditionalInfo.Location = new Point(14, 14);
            lblAdditionalInfo.Name = "lblAdditionalInfo";
            lblAdditionalInfo.Size = new Size(171, 23);
            lblAdditionalInfo.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdditionalInfo.TabIndex = 1;
            lblAdditionalInfo.Values.Text = "Additional Information";
            // 
            // pnlNavPersonalInfoHolder
            // 
            pnlNavPersonalInfoHolder.Controls.Add(lbbPersonalInfo);
            pnlNavPersonalInfoHolder.Cursor = Cursors.Hand;
            pnlNavPersonalInfoHolder.Location = new Point(15, 0);
            pnlNavPersonalInfoHolder.Name = "pnlNavPersonalInfoHolder";
            pnlNavPersonalInfoHolder.Size = new Size(200, 50);
            pnlNavPersonalInfoHolder.StateCommon.Color1 = Color.FromArgb(8, 142, 254);
            pnlNavPersonalInfoHolder.TabIndex = 2;
            // 
            // lbbPersonalInfo
            // 
            lbbPersonalInfo.Location = new Point(15, 14);
            lbbPersonalInfo.Name = "lbbPersonalInfo";
            lbbPersonalInfo.Size = new Size(164, 23);
            lbbPersonalInfo.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbbPersonalInfo.TabIndex = 1;
            lbbPersonalInfo.Values.Text = "Personal Information";
            // 
            // ctxmenuAccManagement
            // 
            ctxmenuAccManagement.Font = new Font("Segoe UI", 9F);
            ctxmenuAccManagement.ImageScalingSize = new Size(24, 24);
            ctxmenuAccManagement.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            ctxmenuAccManagement.Name = "contextMenuStrip1";
            ctxmenuAccManagement.Size = new Size(161, 26);
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(160, 22);
            actionsToolStripMenuItem.Text = "Update Account";
            // 
            // pnlMainContentControler
            // 
            pnlMainContentControler.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlMainContentControler.Controls.Add(kryptonPanel2);
            pnlMainContentControler.Controls.Add(kryptonPanel1);
            pnlMainContentControler.Location = new Point(0, -35);
            pnlMainContentControler.Name = "pnlMainContentControler";
            pnlMainContentControler.Size = new Size(1125, 677);
            pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            kryptonLabel2.Location = new Point(21, 48);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(176, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Account Settings";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(514, 429);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            btnLogin.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.OverrideDefault.Border.Rounding = 5F;
            btnLogin.OverrideDefault.Border.Width = 1;
            btnLogin.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnLogin.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLogin.Size = new Size(187, 51);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateCommon.Back.ColorAngle = 45F;
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnLogin.StateCommon.Border.ColorAngle = 45F;
            btnLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateCommon.Border.Rounding = 5F;
            btnLogin.StateCommon.Border.Width = 1;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.StateDisabled.Border.Rounding = 5F;
            btnLogin.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Border.Rounding = 5F;
            btnLogin.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Color2 = Color.White;
            btnLogin.StatePressed.Back.Color1 = Color.White;
            btnLogin.StatePressed.Back.Color2 = Color.White;
            btnLogin.StatePressed.Back.ColorAngle = 130F;
            btnLogin.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnLogin.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnLogin.StatePressed.Border.ColorAngle = 130F;
            btnLogin.StatePressed.Border.Rounding = 5F;
            btnLogin.StatePressed.Border.Width = 1;
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnLogin.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnLogin.StateTracking.Back.ColorAngle = 45F;
            btnLogin.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Border.ColorAngle = 45F;
            btnLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateTracking.Border.Rounding = 5F;
            btnLogin.StateTracking.Border.Width = 1;
            btnLogin.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.TabIndex = 38;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "Save Changes";
            // 
            // ResidentAccountSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContentControler);
            Name = "ResidentAccountSetting";
            Size = new Size(1125, 607);
            Load += ResidentAccountSetting_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlAsMainContentHolder).EndInit();
            pnlAsMainContentHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlAsControlHolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlAsNavigator).EndInit();
            pnlAsNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlNavAddressInfoHolder).EndInit();
            pnlNavAddressInfoHolder.ResumeLayout(false);
            pnlNavAddressInfoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlNavAdditionalInfoHolder).EndInit();
            pnlNavAdditionalInfoHolder.ResumeLayout(false);
            pnlNavAdditionalInfoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlNavPersonalInfoHolder).EndInit();
            pnlNavPersonalInfoHolder.ResumeLayout(false);
            pnlNavPersonalInfoHolder.PerformLayout();
            ctxmenuAccManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).EndInit();
            pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ContextMenuStrip ctxmenuAccManagement;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private Krypton.Toolkit.KryptonPanel pnlAsNavigator;
        private Krypton.Toolkit.KryptonPanel pnlNavAdditionalInfoHolder;
        private Krypton.Toolkit.KryptonLabel lblAdditionalInfo;
        private Krypton.Toolkit.KryptonPanel pnlNavPersonalInfoHolder;
        private Krypton.Toolkit.KryptonLabel lbbPersonalInfo;
        private Krypton.Toolkit.KryptonPanel pnlNavAddressInfoHolder;
        private Krypton.Toolkit.KryptonLabel lblAddressInfo;
        private Krypton.Toolkit.KryptonPanel pnlAsMainContentHolder;
        private Krypton.Toolkit.KryptonPanel pnlAsControlHolder;
        private Krypton.Toolkit.KryptonButton btnLogin;
    }
}
