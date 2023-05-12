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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_createFreight = new System.Windows.Forms.Button();
            this.tb_totalValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_destinationCity = new System.Windows.Forms.ComboBox();
            this.cb_startingPointCity = new System.Windows.Forms.ComboBox();
            this.cb_startingPointStates = new System.Windows.Forms.ComboBox();
            this.cb_destinationStates = new System.Windows.Forms.ComboBox();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_track = new System.Windows.Forms.ComboBox();
            this.tb_load = new System.Windows.Forms.TextBox();
            this.tb_valuePerKm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.maskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskedTextBox1.Location = new System.Drawing.Point(330, 170);
            this.maskedTextBox1.Mask = "$0,00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(158, 23);
            this.maskedTextBox1.TabIndex = 68;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Location = new System.Drawing.Point(438, 478);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 54);
            this.btn_cancel.TabIndex = 67;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_createFreight
            // 
            this.btn_createFreight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_createFreight.Enabled = false;
            this.btn_createFreight.Location = new System.Drawing.Point(568, 478);
            this.btn_createFreight.Name = "btn_createFreight";
            this.btn_createFreight.Size = new System.Drawing.Size(113, 54);
            this.btn_createFreight.TabIndex = 66;
            this.btn_createFreight.Text = "cadastrar";
            this.btn_createFreight.UseVisualStyleBackColor = true;
            // 
            // tb_totalValue
            // 
            this.tb_totalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_totalValue.Location = new System.Drawing.Point(546, 291);
            this.tb_totalValue.Name = "tb_totalValue";
            this.tb_totalValue.ReadOnly = true;
            this.tb_totalValue.Size = new System.Drawing.Size(135, 23);
            this.tb_totalValue.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(466, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 64;
            this.label9.Text = "Valor total:";
            // 
            // cb_destinationCity
            // 
            this.cb_destinationCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_destinationCity.Enabled = false;
            this.cb_destinationCity.ForeColor = System.Drawing.Color.Black;
            this.cb_destinationCity.FormattingEnabled = true;
            this.cb_destinationCity.Location = new System.Drawing.Point(190, 105);
            this.cb_destinationCity.Name = "cb_destinationCity";
            this.cb_destinationCity.Size = new System.Drawing.Size(153, 23);
            this.cb_destinationCity.Sorted = true;
            this.cb_destinationCity.TabIndex = 63;
            this.cb_destinationCity.Text = "--Insira a cidade--";
            // 
            // cb_startingPointCity
            // 
            this.cb_startingPointCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_startingPointCity.Enabled = false;
            this.cb_startingPointCity.ForeColor = System.Drawing.Color.Black;
            this.cb_startingPointCity.FormattingEnabled = true;
            this.cb_startingPointCity.Items.AddRange(new object[] {
            "fg"});
            this.cb_startingPointCity.Location = new System.Drawing.Point(190, 70);
            this.cb_startingPointCity.Name = "cb_startingPointCity";
            this.cb_startingPointCity.Size = new System.Drawing.Size(153, 23);
            this.cb_startingPointCity.Sorted = true;
            this.cb_startingPointCity.TabIndex = 62;
            this.cb_startingPointCity.Text = "--Insira a cidade--";
            // 
            // cb_startingPointStates
            // 
            this.cb_startingPointStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_startingPointStates.FormattingEnabled = true;
            this.cb_startingPointStates.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cb_startingPointStates.Location = new System.Drawing.Point(122, 70);
            this.cb_startingPointStates.Name = "cb_startingPointStates";
            this.cb_startingPointStates.Size = new System.Drawing.Size(49, 23);
            this.cb_startingPointStates.Sorted = true;
            this.cb_startingPointStates.TabIndex = 47;
            // 
            // cb_destinationStates
            // 
            this.cb_destinationStates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_destinationStates.FormattingEnabled = true;
            this.cb_destinationStates.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cb_destinationStates.Location = new System.Drawing.Point(122, 105);
            this.cb_destinationStates.Name = "cb_destinationStates";
            this.cb_destinationStates.Size = new System.Drawing.Size(49, 23);
            this.cb_destinationStates.TabIndex = 61;
            // 
            // tb_distance
            // 
            this.tb_distance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_distance.Location = new System.Drawing.Point(122, 138);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.ReadOnly = true;
            this.tb_distance.Size = new System.Drawing.Size(161, 23);
            this.tb_distance.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 59;
            this.label8.Text = "Distancia:";
            // 
            // tb_obs
            // 
            this.tb_obs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_obs.Location = new System.Drawing.Point(192, 288);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(221, 167);
            this.tb_obs.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(109, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 57;
            this.label7.Text = "Observacao:";
            // 
            // cb_track
            // 
            this.cb_track.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_track.FormattingEnabled = true;
            this.cb_track.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_track.Location = new System.Drawing.Point(112, 234);
            this.cb_track.Name = "cb_track";
            this.cb_track.Size = new System.Drawing.Size(59, 23);
            this.cb_track.TabIndex = 56;
            // 
            // tb_load
            // 
            this.tb_load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_load.Location = new System.Drawing.Point(96, 200);
            this.tb_load.Name = "tb_load";
            this.tb_load.Size = new System.Drawing.Size(163, 23);
            this.tb_load.TabIndex = 55;
            // 
            // tb_valuePerKm
            // 
            this.tb_valuePerKm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_valuePerKm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_valuePerKm.Location = new System.Drawing.Point(130, 166);
            this.tb_valuePerKm.Name = "tb_valuePerKm";
            this.tb_valuePerKm.PlaceholderText = "R$0,00";
            this.tb_valuePerKm.Size = new System.Drawing.Size(163, 23);
            this.tb_valuePerKm.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(50, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 53;
            this.label6.Text = "Rastreio:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = "Carga:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Valor(p/Km):";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 50;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 49;
            this.label2.Text = "Origem:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(292, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Informaçoes do frete";
            // 
            // frmCreateFreight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 573);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_createFreight);
            this.Controls.Add(this.tb_totalValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_destinationCity);
            this.Controls.Add(this.cb_startingPointCity);
            this.Controls.Add(this.cb_startingPointStates);
            this.Controls.Add(this.cb_destinationStates);
            this.Controls.Add(this.tb_distance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_track);
            this.Controls.Add(this.tb_load);
            this.Controls.Add(this.tb_valuePerKm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateFreight";
            this.Text = "frmCreateFreight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button btn_cancel;
        private Button btn_createFreight;
        private TextBox tb_totalValue;
        private Label label9;
        private ComboBox cb_destinationCity;
        private ComboBox cb_startingPointCity;
        private ComboBox cb_startingPointStates;
        private ComboBox cb_destinationStates;
        private TextBox tb_distance;
        private Label label8;
        private TextBox tb_obs;
        private Label label7;
        private ComboBox cb_track;
        private TextBox tb_load;
        private TextBox tb_valuePerKm;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}