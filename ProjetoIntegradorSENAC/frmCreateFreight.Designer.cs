namespace ProjetoIntegradorSENAC
{
    partial class frmCreateFreight
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(756, 573);
            this.pn_main.TabIndex = 0;
            this.pn_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_main_Paint);
            // 
            // frmCreateFreight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 573);
            this.Controls.Add(this.pn_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateFreight";
            this.Text = "frmCreateFreight";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_main;
    }
}