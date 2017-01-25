namespace GestClubBest
{
    partial class FormAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_anome = new System.Windows.Forms.Label();
            this.lbl_arua = new System.Windows.Forms.Label();
            this.lbl_alocalidade = new System.Windows.Forms.Label();
            this.lbl_acodigo = new System.Windows.Forms.Label();
            this.lbl_apeso = new System.Windows.Forms.Label();
            this.lbl_adatadenascimento = new System.Windows.Forms.Label();
            this.txt_anome = new System.Windows.Forms.TextBox();
            this.txt_arua = new System.Windows.Forms.TextBox();
            this.txt_alocalidade = new System.Windows.Forms.TextBox();
            this.txt_apeso = new System.Windows.Forms.TextBox();
            this.msk_codigo = new System.Windows.Forms.MaskedTextBox();
            this.msk_data = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_aadicionar = new System.Windows.Forms.Button();
            this.btn_avoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-74, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(561, 5);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Items.AddRange(new object[] {
            "Socios",
            "Atletas"});
            this.cbo_tipo.Location = new System.Drawing.Point(171, 8);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(195, 21);
            this.cbo_tipo.TabIndex = 2;
            this.cbo_tipo.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_SelectedIndexChanged_1);
            // 
            // lbl_anome
            // 
            this.lbl_anome.AutoSize = true;
            this.lbl_anome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anome.Location = new System.Drawing.Point(110, 61);
            this.lbl_anome.Name = "lbl_anome";
            this.lbl_anome.Size = new System.Drawing.Size(55, 20);
            this.lbl_anome.TabIndex = 3;
            this.lbl_anome.Text = "Nome:";
            // 
            // lbl_arua
            // 
            this.lbl_arua.AutoSize = true;
            this.lbl_arua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arua.Location = new System.Drawing.Point(122, 99);
            this.lbl_arua.Name = "lbl_arua";
            this.lbl_arua.Size = new System.Drawing.Size(43, 20);
            this.lbl_arua.TabIndex = 4;
            this.lbl_arua.Text = "Rua:";
            // 
            // lbl_alocalidade
            // 
            this.lbl_alocalidade.AutoSize = true;
            this.lbl_alocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alocalidade.Location = new System.Drawing.Point(75, 133);
            this.lbl_alocalidade.Name = "lbl_alocalidade";
            this.lbl_alocalidade.Size = new System.Drawing.Size(90, 20);
            this.lbl_alocalidade.TabIndex = 5;
            this.lbl_alocalidade.Text = "Localidade:";
            // 
            // lbl_acodigo
            // 
            this.lbl_acodigo.AutoSize = true;
            this.lbl_acodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acodigo.Location = new System.Drawing.Point(54, 169);
            this.lbl_acodigo.Name = "lbl_acodigo";
            this.lbl_acodigo.Size = new System.Drawing.Size(111, 20);
            this.lbl_acodigo.TabIndex = 6;
            this.lbl_acodigo.Text = "Codigo Postal:";
            // 
            // lbl_apeso
            // 
            this.lbl_apeso.AutoSize = true;
            this.lbl_apeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apeso.Location = new System.Drawing.Point(116, 207);
            this.lbl_apeso.Name = "lbl_apeso";
            this.lbl_apeso.Size = new System.Drawing.Size(49, 20);
            this.lbl_apeso.TabIndex = 7;
            this.lbl_apeso.Text = "Peso:";
            // 
            // lbl_adatadenascimento
            // 
            this.lbl_adatadenascimento.AutoSize = true;
            this.lbl_adatadenascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adatadenascimento.Location = new System.Drawing.Point(7, 241);
            this.lbl_adatadenascimento.Name = "lbl_adatadenascimento";
            this.lbl_adatadenascimento.Size = new System.Drawing.Size(158, 20);
            this.lbl_adatadenascimento.TabIndex = 8;
            this.lbl_adatadenascimento.Text = "Data de Nascimento:";
            // 
            // txt_anome
            // 
            this.txt_anome.Location = new System.Drawing.Point(171, 62);
            this.txt_anome.Name = "txt_anome";
            this.txt_anome.Size = new System.Drawing.Size(195, 20);
            this.txt_anome.TabIndex = 9;
            // 
            // txt_arua
            // 
            this.txt_arua.Location = new System.Drawing.Point(171, 99);
            this.txt_arua.Name = "txt_arua";
            this.txt_arua.Size = new System.Drawing.Size(195, 20);
            this.txt_arua.TabIndex = 10;
            // 
            // txt_alocalidade
            // 
            this.txt_alocalidade.Location = new System.Drawing.Point(171, 135);
            this.txt_alocalidade.Name = "txt_alocalidade";
            this.txt_alocalidade.Size = new System.Drawing.Size(195, 20);
            this.txt_alocalidade.TabIndex = 11;
            // 
            // txt_apeso
            // 
            this.txt_apeso.Location = new System.Drawing.Point(171, 207);
            this.txt_apeso.Name = "txt_apeso";
            this.txt_apeso.Size = new System.Drawing.Size(195, 20);
            this.txt_apeso.TabIndex = 13;
            // 
            // msk_codigo
            // 
            this.msk_codigo.Location = new System.Drawing.Point(171, 171);
            this.msk_codigo.Mask = "0000-999";
            this.msk_codigo.Name = "msk_codigo";
            this.msk_codigo.Size = new System.Drawing.Size(195, 20);
            this.msk_codigo.TabIndex = 14;
            // 
            // msk_data
            // 
            this.msk_data.Location = new System.Drawing.Point(171, 243);
            this.msk_data.Mask = "00/00/0000";
            this.msk_data.Name = "msk_data";
            this.msk_data.Size = new System.Drawing.Size(195, 20);
            this.msk_data.TabIndex = 15;
            this.msk_data.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(386, 53);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-116, 289);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(561, 5);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // btn_aadicionar
            // 
            this.btn_aadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aadicionar.Location = new System.Drawing.Point(214, 300);
            this.btn_aadicionar.Name = "btn_aadicionar";
            this.btn_aadicionar.Size = new System.Drawing.Size(119, 27);
            this.btn_aadicionar.TabIndex = 18;
            this.btn_aadicionar.Text = "Adicionar";
            this.btn_aadicionar.UseVisualStyleBackColor = true;
            this.btn_aadicionar.Click += new System.EventHandler(this.btn_aadicionar_Click);
            // 
            // btn_avoltar
            // 
            this.btn_avoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avoltar.Location = new System.Drawing.Point(67, 300);
            this.btn_avoltar.Name = "btn_avoltar";
            this.btn_avoltar.Size = new System.Drawing.Size(119, 27);
            this.btn_avoltar.TabIndex = 19;
            this.btn_avoltar.Text = "Voltar";
            this.btn_avoltar.UseVisualStyleBackColor = true;
            this.btn_avoltar.Click += new System.EventHandler(this.btn_avoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tipo:";
            // 
            // FormAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_avoltar);
            this.Controls.Add(this.btn_aadicionar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.msk_data);
            this.Controls.Add(this.msk_codigo);
            this.Controls.Add(this.txt_apeso);
            this.Controls.Add(this.txt_alocalidade);
            this.Controls.Add(this.txt_arua);
            this.Controls.Add(this.txt_anome);
            this.Controls.Add(this.lbl_adatadenascimento);
            this.Controls.Add(this.lbl_apeso);
            this.Controls.Add(this.lbl_acodigo);
            this.Controls.Add(this.lbl_alocalidade);
            this.Controls.Add(this.lbl_arua);
            this.Controls.Add(this.lbl_anome);
            this.Controls.Add(this.cbo_tipo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.Label lbl_anome;
        private System.Windows.Forms.Label lbl_arua;
        private System.Windows.Forms.Label lbl_alocalidade;
        private System.Windows.Forms.Label lbl_acodigo;
        private System.Windows.Forms.Label lbl_apeso;
        private System.Windows.Forms.Label lbl_adatadenascimento;
        private System.Windows.Forms.TextBox txt_arua;
        private System.Windows.Forms.TextBox txt_alocalidade;
        private System.Windows.Forms.TextBox txt_apeso;
        private System.Windows.Forms.MaskedTextBox msk_codigo;
        private System.Windows.Forms.MaskedTextBox msk_data;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_aadicionar;
        private System.Windows.Forms.Button btn_avoltar;
        public System.Windows.Forms.TextBox txt_anome;
        private System.Windows.Forms.Label label1;
    }
}