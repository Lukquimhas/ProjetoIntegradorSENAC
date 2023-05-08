namespace ProjetoIntegradorSENAC
{
    partial class frmMain
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
            this.pn_Left = new System.Windows.Forms.Panel();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_Left
            // 
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(95, 616);
            this.pn_Left.TabIndex = 0;
            // 
            // pn_Main
            // 
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(95, 0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(950, 616);
            this.pn_Main.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 616);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.pn_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_Left;
        private Panel pn_Main;
    }
}