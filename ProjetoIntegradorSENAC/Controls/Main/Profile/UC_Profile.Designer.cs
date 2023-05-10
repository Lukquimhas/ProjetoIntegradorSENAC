namespace ProjetoIntegradorSENAC.Controls.Main.Profile
{
    partial class UC_Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.pn_Password = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_confirmedPassword = new System.Windows.Forms.TextBox();
            this.tb_newPassword = new System.Windows.Forms.TextBox();
            this.tb_currentPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pn_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 180);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Username.Location = new System.Drawing.Point(184, 69);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(54, 21);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "label5";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(464, 17);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(54, 21);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "label4";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(184, 17);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 21);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "label1";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangePassword.Location = new System.Drawing.Point(82, 237);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(149, 59);
            this.btn_ChangePassword.TabIndex = 1;
            this.btn_ChangePassword.Text = "Trocar Senha";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // pn_Password
            // 
            this.pn_Password.Controls.Add(this.label3);
            this.pn_Password.Controls.Add(this.label2);
            this.pn_Password.Controls.Add(this.label1);
            this.pn_Password.Controls.Add(this.tb_confirmedPassword);
            this.pn_Password.Controls.Add(this.tb_newPassword);
            this.pn_Password.Controls.Add(this.tb_currentPassword);
            this.pn_Password.Controls.Add(this.btn_ChangePassword);
            this.pn_Password.Location = new System.Drawing.Point(7, 189);
            this.pn_Password.Name = "pn_Password";
            this.pn_Password.Size = new System.Drawing.Size(314, 334);
            this.pn_Password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nova senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senha atual";
            // 
            // tb_confirmedPassword
            // 
            this.tb_confirmedPassword.Location = new System.Drawing.Point(49, 163);
            this.tb_confirmedPassword.Name = "tb_confirmedPassword";
            this.tb_confirmedPassword.Size = new System.Drawing.Size(212, 23);
            this.tb_confirmedPassword.TabIndex = 4;
            this.tb_confirmedPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_confirmedPassword_Validating);
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.Location = new System.Drawing.Point(49, 116);
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.Size = new System.Drawing.Size(212, 23);
            this.tb_newPassword.TabIndex = 3;
            this.tb_newPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_newPassword_Validating);
            // 
            // tb_currentPassword
            // 
            this.tb_currentPassword.Location = new System.Drawing.Point(49, 66);
            this.tb_currentPassword.Name = "tb_currentPassword";
            this.tb_currentPassword.Size = new System.Drawing.Size(212, 23);
            this.tb_currentPassword.TabIndex = 2;
            this.tb_currentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_currentPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Password);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Profile";
            this.Size = new System.Drawing.Size(937, 535);
            this.Load += new System.EventHandler(this.UC_Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_Password.ResumeLayout(false);
            this.pn_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_Name;
        private Label lbl_Username;
        private Label lbl_Email;
        private Button btn_ChangePassword;
        private Panel pn_Password;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_confirmedPassword;
        private TextBox tb_newPassword;
        private TextBox tb_currentPassword;
        private ErrorProvider errorProvider1;
    }
}
