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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pn_Left = new Panel();
            btn_Profile = new Button();
            imageList1 = new ImageList(components);
            button3 = new Button();
            btn_Freight = new Button();
            btn_Home = new Button();
            pn_Main = new Panel();
            pn_Left.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Left
            // 
            pn_Left.Controls.Add(btn_Profile);
            pn_Left.Controls.Add(button3);
            pn_Left.Controls.Add(btn_Freight);
            pn_Left.Controls.Add(btn_Home);
            pn_Left.Dock = DockStyle.Left;
            pn_Left.Location = new Point(0, 0);
            pn_Left.Name = "pn_Left";
            pn_Left.Size = new Size(95, 616);
            pn_Left.TabIndex = 0;
            // 
            // btn_Profile
            // 
            btn_Profile.BackColor = Color.Transparent;
            btn_Profile.FlatAppearance.BorderSize = 0;
            btn_Profile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Profile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Profile.FlatStyle = FlatStyle.Flat;
            btn_Profile.ImageIndex = 2;
            btn_Profile.ImageList = imageList1;
            btn_Profile.Location = new Point(0, 528);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(95, 67);
            btn_Profile.TabIndex = 3;
            btn_Profile.UseVisualStyleBackColor = false;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Home.png");
            imageList1.Images.SetKeyName(1, "HomeSelect.png");
            imageList1.Images.SetKeyName(2, "Profile.png");
            imageList1.Images.SetKeyName(3, "ProfileSelect.png");
            imageList1.Images.SetKeyName(4, "Truck.png");
            imageList1.Images.SetKeyName(5, "TruckSelect.png");
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 192);
            button3.Name = "button3";
            button3.Size = new Size(95, 67);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // btn_Freight
            // 
            btn_Freight.BackColor = Color.Transparent;
            btn_Freight.FlatAppearance.BorderSize = 0;
            btn_Freight.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Freight.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Freight.FlatStyle = FlatStyle.Flat;
            btn_Freight.ImageKey = "Truck.png";
            btn_Freight.ImageList = imageList1;
            btn_Freight.Location = new Point(0, 107);
            btn_Freight.Name = "btn_Freight";
            btn_Freight.Size = new Size(95, 67);
            btn_Freight.TabIndex = 1;
            btn_Freight.UseVisualStyleBackColor = false;
            btn_Freight.Click += btn_Freight_Click;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.Transparent;
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Home.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.ImageIndex = 1;
            btn_Home.ImageList = imageList1;
            btn_Home.Location = new Point(0, 22);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(95, 67);
            btn_Home.TabIndex = 0;
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // pn_Main
            // 
            pn_Main.Dock = DockStyle.Fill;
            pn_Main.Location = new Point(95, 0);
            pn_Main.Name = "pn_Main";
            pn_Main.Size = new Size(950, 616);
            pn_Main.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 616);
            Controls.Add(pn_Main);
            Controls.Add(pn_Left);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            pn_Left.ResumeLayout(false);
            ResumeLayout(false);
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