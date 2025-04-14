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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.pnlHMainPnl = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHMainPnl)).BeginInit();
            this.pnlHMainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHMainPnl
            // 
            this.pnlHMainPnl.Controls.Add(this.kryptonPanel1);
            this.pnlHMainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHMainPnl.Location = new System.Drawing.Point(0, 0);
            this.pnlHMainPnl.Name = "pnlHMainPnl";
            this.pnlHMainPnl.Size = new System.Drawing.Size(954, 437);
            this.pnlHMainPnl.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlHMainPnl.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(91, 437);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Homepage
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(954, 437);
            this.Controls.Add(this.pnlHMainPnl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHMainPnl)).EndInit();
            this.pnlHMainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebartimer;
        private Krypton.Toolkit.KryptonPanel pnlHMainPnl;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}