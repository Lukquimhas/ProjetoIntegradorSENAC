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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pn_Left = new System.Windows.Forms.Panel();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Freight = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.pn_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Left
            // 
            this.pn_Left.Controls.Add(this.btn_Profile);
            this.pn_Left.Controls.Add(this.button3);
            this.pn_Left.Controls.Add(this.btn_Freight);
            this.pn_Left.Controls.Add(this.btn_Home);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(95, 616);
            this.pn_Left.TabIndex = 0;
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.ImageIndex = 2;
            this.btn_Profile.ImageList = this.imageList1;
            this.btn_Profile.Location = new System.Drawing.Point(0, 528);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(95, 67);
            this.btn_Profile.TabIndex = 3;
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Home.png");
            this.imageList1.Images.SetKeyName(1, "HomeSelect.png");
            this.imageList1.Images.SetKeyName(2, "Profile.png");
            this.imageList1.Images.SetKeyName(3, "ProfileSelect.png");
            this.imageList1.Images.SetKeyName(4, "Truck.png");
            this.imageList1.Images.SetKeyName(5, "TruckSelect.png");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_Freight
            // 
            this.btn_Freight.BackColor = System.Drawing.Color.Transparent;
            this.btn_Freight.FlatAppearance.BorderSize = 0;
            this.btn_Freight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Freight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Freight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Freight.ImageKey = "Truck.png";
            this.btn_Freight.ImageList = this.imageList1;
            this.btn_Freight.Location = new System.Drawing.Point(0, 107);
            this.btn_Freight.Name = "btn_Freight";
            this.btn_Freight.Size = new System.Drawing.Size(95, 67);
            this.btn_Freight.TabIndex = 1;
            this.btn_Freight.UseVisualStyleBackColor = false;
            this.btn_Freight.Click += new System.EventHandler(this.btn_Freight_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.ImageIndex = 1;
            this.btn_Home.ImageList = this.imageList1;
            this.btn_Home.Location = new System.Drawing.Point(0, 22);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(95, 67);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
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
            this.pn_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_Left;
        private Panel pn_Main;
        private Button btn_Profile;
        private ImageList imageList1;
        private Button button3;
        private Button btn_Freight;
        private Button btn_Home;
    }
}