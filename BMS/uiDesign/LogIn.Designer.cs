namespace BMS.uiDesign
{
    partial class Krypton_LogIn
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
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.Rounding = 16F;
            this.kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            this.kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            this.kryptonCustomPaletteBase1.PalettePaint += new System.EventHandler<Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonCustomPaletteBase1_PalettePaint);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(145, 126);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(136, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // Krypton_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 393);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "Krypton_LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay LogIn";
            this.Load += new System.EventHandler(this.Krypton_LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}