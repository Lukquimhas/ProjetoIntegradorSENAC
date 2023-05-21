namespace ProjetoIntegradorSENAC.Controls.Freight
{
    partial class UC_CreateFreight
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
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(405, 472);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 54);
            this.btn_cancel.TabIndex = 89;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_createFreight
            // 
            this.btn_createFreight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_createFreight.Enabled = false;
            this.btn_createFreight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createFreight.Location = new System.Drawing.Point(535, 472);
            this.btn_createFreight.Name = "btn_createFreight";
            this.btn_createFreight.Size = new System.Drawing.Size(113, 54);
            this.btn_createFreight.TabIndex = 88;
            this.btn_createFreight.Text = "cadastrar";
            this.btn_createFreight.UseVisualStyleBackColor = true;
            this.btn_createFreight.Click += new System.EventHandler(this.btn_createFreight_Click);
            // 
            // tb_totalValue
            // 
            this.tb_totalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_totalValue.Location = new System.Drawing.Point(513, 285);
            this.tb_totalValue.Name = "tb_totalValue";
            this.tb_totalValue.ReadOnly = true;
            this.tb_totalValue.Size = new System.Drawing.Size(135, 23);
            this.tb_totalValue.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(433, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 14);
            this.label9.TabIndex = 86;
            this.label9.Text = "Valor total:";
            // 
            // cb_destinationCity
            // 
            this.cb_destinationCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_destinationCity.Enabled = false;
            this.cb_destinationCity.ForeColor = System.Drawing.Color.Black;
            this.cb_destinationCity.FormattingEnabled = true;
            this.cb_destinationCity.Location = new System.Drawing.Point(157, 99);
            this.cb_destinationCity.Name = "cb_destinationCity";
            this.cb_destinationCity.Size = new System.Drawing.Size(153, 23);
            this.cb_destinationCity.Sorted = true;
            this.cb_destinationCity.TabIndex = 85;
            this.cb_destinationCity.Text = "--Insira a cidade--";
            this.cb_destinationCity.TextChanged += new System.EventHandler(this.cb_destinationCity_TextChanged);
            // 
            // cb_startingPointCity
            // 
            this.cb_startingPointCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_startingPointCity.Enabled = false;
            this.cb_startingPointCity.ForeColor = System.Drawing.Color.Black;
            this.cb_startingPointCity.FormattingEnabled = true;
            this.cb_startingPointCity.Items.AddRange(new object[] {
            "fg"});
            this.cb_startingPointCity.Location = new System.Drawing.Point(157, 64);
            this.cb_startingPointCity.Name = "cb_startingPointCity";
            this.cb_startingPointCity.Size = new System.Drawing.Size(153, 23);
            this.cb_startingPointCity.Sorted = true;
            this.cb_startingPointCity.TabIndex = 84;
            this.cb_startingPointCity.Text = "--Insira a cidade--";
            this.cb_startingPointCity.TextChanged += new System.EventHandler(this.cb_startingPointCity_TextChanged);
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
            this.cb_startingPointStates.Location = new System.Drawing.Point(89, 64);
            this.cb_startingPointStates.Name = "cb_startingPointStates";
            this.cb_startingPointStates.Size = new System.Drawing.Size(49, 23);
            this.cb_startingPointStates.Sorted = true;
            this.cb_startingPointStates.TabIndex = 69;
            this.cb_startingPointStates.TextChanged += new System.EventHandler(this.cb_startingPointStates_TextChanged);
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
            this.cb_destinationStates.Location = new System.Drawing.Point(89, 99);
            this.cb_destinationStates.Name = "cb_destinationStates";
            this.cb_destinationStates.Size = new System.Drawing.Size(49, 23);
            this.cb_destinationStates.TabIndex = 83;
            this.cb_destinationStates.TextChanged += new System.EventHandler(this.cb_destinationStates_TextChanged);
            // 
            // tb_distance
            // 
            this.tb_distance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_distance.Location = new System.Drawing.Point(89, 132);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.ReadOnly = true;
            this.tb_distance.Size = new System.Drawing.Size(161, 23);
            this.tb_distance.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 81;
            this.label8.Text = "Distancia:";
            // 
            // tb_obs
            // 
            this.tb_obs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_obs.Location = new System.Drawing.Point(159, 282);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(221, 167);
            this.tb_obs.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 14);
            this.label7.TabIndex = 79;
            this.label7.Text = "Observacao:";
            // 
            // cb_track
            // 
            this.cb_track.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_track.FormattingEnabled = true;
            this.cb_track.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_track.Location = new System.Drawing.Point(79, 228);
            this.cb_track.Name = "cb_track";
            this.cb_track.Size = new System.Drawing.Size(59, 23);
            this.cb_track.TabIndex = 78;
            // 
            // tb_load
            // 
            this.tb_load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_load.Location = new System.Drawing.Point(63, 194);
            this.tb_load.Name = "tb_load";
            this.tb_load.Size = new System.Drawing.Size(163, 23);
            this.tb_load.TabIndex = 77;
            // 
            // tb_valuePerKm
            // 
            this.tb_valuePerKm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_valuePerKm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_valuePerKm.Location = new System.Drawing.Point(97, 160);
            this.tb_valuePerKm.Name = "tb_valuePerKm";
            this.tb_valuePerKm.PlaceholderText = "R$0,00";
            this.tb_valuePerKm.Size = new System.Drawing.Size(163, 23);
            this.tb_valuePerKm.TabIndex = 76;
            this.tb_valuePerKm.TextChanged += new System.EventHandler(this.tb_valuePerKm_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 75;
            this.label6.Text = "Rastreio:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 74;
            this.label5.Text = "Carga:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 73;
            this.label4.Text = "Valor(p/Km):";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 72;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 71;
            this.label2.Text = "Origem:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 14);
            this.label1.TabIndex = 70;
            this.label1.Text = "Informaçoes do frete";
            // 
            // UC_CreateFreight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UC_CreateFreight";
            this.Size = new System.Drawing.Size(730, 567);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UC_CreateFreight_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
