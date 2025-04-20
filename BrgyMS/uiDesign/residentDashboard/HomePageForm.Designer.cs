namespace BrgyMs.uiDesign
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            components = new System.ComponentModel.Container();
            sidebartimer = new System.Windows.Forms.Timer(components);
            pnlHMainPnl = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pnlHMainPnl).BeginInit();
            pnlHMainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // pnlHMainPnl
            // 
            pnlHMainPnl.Controls.Add(kryptonPanel1);
            pnlHMainPnl.Dock = DockStyle.Fill;
            pnlHMainPnl.Location = new Point(0, 0);
            pnlHMainPnl.Margin = new Padding(4, 3, 4, 3);
            pnlHMainPnl.Name = "pnlHMainPnl";
            pnlHMainPnl.Size = new Size(1224, 684);
            pnlHMainPnl.StateCommon.Color1 = Color.White;
            pnlHMainPnl.TabIndex = 0;
            pnlHMainPnl.Paint += pnlHMainPnl_Paint;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(4, 3, 4, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(106, 684);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            kryptonPanel1.TabIndex = 0;
            // 
            // Homepage
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1224, 684);
            Controls.Add(pnlHMainPnl);
            Margin = new Padding(2);
            Name = "Homepage";
            RightToLeft = RightToLeft.No;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pnlHMainPnl).EndInit();
            pnlHMainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebartimer;
        private Krypton.Toolkit.KryptonPanel pnlHMainPnl;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}