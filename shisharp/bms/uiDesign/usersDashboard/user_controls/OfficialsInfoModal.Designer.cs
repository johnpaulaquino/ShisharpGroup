namespace shisharp.bms.uiDesign.usersDashboard.user_controls {
    partial class OfficialsInfoModal {
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
            this.pnlMainContainer = new Krypton.Docking.KryptonDockableWorkspace();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.ActivePage = null;
            this.pnlMainContainer.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.pnlMainContainer.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Name = "pnlMainContainer";
            // 
            // 
            // 
            this.pnlMainContainer.Root.UniqueName = "4459c8a4683a43789a734a312809c38e";
            this.pnlMainContainer.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.pnlMainContainer.ShowMaximizeButton = false;
            this.pnlMainContainer.Size = new System.Drawing.Size(484, 486);
            this.pnlMainContainer.SplitterWidth = 5;
            this.pnlMainContainer.TabIndex = 1;
            this.pnlMainContainer.TabStop = true;
            // 
            // OfficialsInfoModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 486);
            this.Controls.Add(this.pnlMainContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OfficialsInfoModal";
            this.Text = "OfficialsInfoModal";
            this.Load += new System.EventHandler(this.OfficialsInfoModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal Krypton.Docking.KryptonDockableWorkspace pnlMainContainer;
    }
}