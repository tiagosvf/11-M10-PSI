namespace GestClubBest
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lsb_pessoas = new System.Windows.Forms.ListBox();
            this.mns_program = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_ftipo = new System.Windows.Forms.Label();
            this.lbl_fnome = new System.Windows.Forms.Label();
            this.lbl_frua = new System.Windows.Forms.Label();
            this.lbl_flocalidade = new System.Windows.Forms.Label();
            this.lbl_fcodigopostal = new System.Windows.Forms.Label();
            this.lbl_fpeso_e_nsocio = new System.Windows.Forms.Label();
            this.lbl_fidade = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_localidade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_peso_e_nsocio = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.mns_program.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_pessoas
            // 
            this.lsb_pessoas.FormattingEnabled = true;
            this.lsb_pessoas.Location = new System.Drawing.Point(446, 48);
            this.lsb_pessoas.Name = "lsb_pessoas";
            this.lsb_pessoas.Size = new System.Drawing.Size(154, 186);
            this.lsb_pessoas.TabIndex = 0;
            this.lsb_pessoas.SelectedIndexChanged += new System.EventHandler(this.lsb_pessoas_SelectedIndexChanged_1);
            // 
            // mns_program
            // 
            this.mns_program.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mns_program.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mns_program.Location = new System.Drawing.Point(0, 0);
            this.mns_program.Name = "mns_program";
            this.mns_program.Size = new System.Drawing.Size(611, 24);
            this.mns_program.TabIndex = 1;
            this.mns_program.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txt_procurar
            // 
            this.txt_procurar.Location = new System.Drawing.Point(446, 243);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(154, 20);
            this.txt_procurar.TabIndex = 2;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_procurar.Image")));
            this.btn_procurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procurar.Location = new System.Drawing.Point(446, 274);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(154, 38);
            this.btn_procurar.TabIndex = 3;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_adicionar.Location = new System.Drawing.Point(12, 39);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(101, 38);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_editar.Location = new System.Drawing.Point(12, 111);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(101, 38);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_remover.Location = new System.Drawing.Point(12, 190);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(101, 38);
            this.btn_remover.TabIndex = 7;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_guardar.Location = new System.Drawing.Point(12, 268);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(101, 38);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // lbl_ftipo
            // 
            this.lbl_ftipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ftipo.Location = new System.Drawing.Point(213, 49);
            this.lbl_ftipo.Name = "lbl_ftipo";
            this.lbl_ftipo.Size = new System.Drawing.Size(46, 31);
            this.lbl_ftipo.TabIndex = 11;
            this.lbl_ftipo.Text = "Tipo:";
            // 
            // lbl_fnome
            // 
            this.lbl_fnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fnome.Location = new System.Drawing.Point(204, 80);
            this.lbl_fnome.Name = "lbl_fnome";
            this.lbl_fnome.Size = new System.Drawing.Size(49, 31);
            this.lbl_fnome.TabIndex = 12;
            this.lbl_fnome.Text = "Nome:";
            // 
            // lbl_frua
            // 
            this.lbl_frua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frua.Location = new System.Drawing.Point(215, 113);
            this.lbl_frua.Name = "lbl_frua";
            this.lbl_frua.Size = new System.Drawing.Size(44, 31);
            this.lbl_frua.TabIndex = 13;
            this.lbl_frua.Text = "Rua:";
            // 
            // lbl_flocalidade
            // 
            this.lbl_flocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flocalidade.Location = new System.Drawing.Point(173, 148);
            this.lbl_flocalidade.Name = "lbl_flocalidade";
            this.lbl_flocalidade.Size = new System.Drawing.Size(90, 31);
            this.lbl_flocalidade.TabIndex = 14;
            this.lbl_flocalidade.Text = "Localidade:";
            // 
            // lbl_fcodigopostal
            // 
            this.lbl_fcodigopostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fcodigopostal.Location = new System.Drawing.Point(156, 182);
            this.lbl_fcodigopostal.Name = "lbl_fcodigopostal";
            this.lbl_fcodigopostal.Size = new System.Drawing.Size(103, 31);
            this.lbl_fcodigopostal.TabIndex = 15;
            this.lbl_fcodigopostal.Text = "Codigo Postal:";
            // 
            // lbl_fpeso_e_nsocio
            // 
            this.lbl_fpeso_e_nsocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fpeso_e_nsocio.Location = new System.Drawing.Point(209, 212);
            this.lbl_fpeso_e_nsocio.Name = "lbl_fpeso_e_nsocio";
            this.lbl_fpeso_e_nsocio.Size = new System.Drawing.Size(49, 31);
            this.lbl_fpeso_e_nsocio.TabIndex = 16;
            this.lbl_fpeso_e_nsocio.Text = "Peso:";
            // 
            // lbl_fidade
            // 
            this.lbl_fidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fidade.Location = new System.Drawing.Point(206, 245);
            this.lbl_fidade.Name = "lbl_fidade";
            this.lbl_fidade.Size = new System.Drawing.Size(50, 31);
            this.lbl_fidade.TabIndex = 17;
            this.lbl_fidade.Text = "Idade:";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(251, 49);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(175, 20);
            this.txt_tipo.TabIndex = 18;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(251, 80);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(175, 20);
            this.txt_nome.TabIndex = 19;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(251, 112);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(175, 20);
            this.txt_rua.TabIndex = 20;
            // 
            // txt_localidade
            // 
            this.txt_localidade.Location = new System.Drawing.Point(251, 147);
            this.txt_localidade.Name = "txt_localidade";
            this.txt_localidade.Size = new System.Drawing.Size(175, 20);
            this.txt_localidade.TabIndex = 21;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(251, 181);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(175, 20);
            this.txt_codigo.TabIndex = 22;
            // 
            // txt_peso_e_nsocio
            // 
            this.txt_peso_e_nsocio.Location = new System.Drawing.Point(251, 212);
            this.txt_peso_e_nsocio.Name = "txt_peso_e_nsocio";
            this.txt_peso_e_nsocio.Size = new System.Drawing.Size(175, 20);
            this.txt_peso_e_nsocio.TabIndex = 23;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(251, 244);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(175, 20);
            this.txt_idade.TabIndex = 24;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(343, 283);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(83, 29);
            this.btn_confirmar.TabIndex = 25;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Visible = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(251, 283);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_voltar.Size = new System.Drawing.Size(83, 29);
            this.btn_voltar.TabIndex = 26;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Visible = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(611, 322);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_peso_e_nsocio);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_localidade);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.lbl_fidade);
            this.Controls.Add(this.lbl_fpeso_e_nsocio);
            this.Controls.Add(this.lbl_fcodigopostal);
            this.Controls.Add(this.lbl_flocalidade);
            this.Controls.Add(this.lbl_frua);
            this.Controls.Add(this.lbl_fnome);
            this.Controls.Add(this.lbl_ftipo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.txt_procurar);
            this.Controls.Add(this.lsb_pessoas);
            this.Controls.Add(this.mns_program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns_program;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "GestClub Hola";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.mns_program.ResumeLayout(false);
            this.mns_program.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_pessoas;
        private System.Windows.Forms.MenuStrip mns_program;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label lbl_ftipo;
        private System.Windows.Forms.Label lbl_fnome;
        private System.Windows.Forms.Label lbl_frua;
        private System.Windows.Forms.Label lbl_flocalidade;
        private System.Windows.Forms.Label lbl_fcodigopostal;
        private System.Windows.Forms.Label lbl_fpeso_e_nsocio;
        private System.Windows.Forms.Label lbl_fidade;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_localidade;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_peso_e_nsocio;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

