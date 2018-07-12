namespace ExemploBancoDados02
{
    partial class CadastroHeroi
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEscuridaoNao = new System.Windows.Forms.RadioButton();
            this.rbEscuridaoSim = new System.Windows.Forms.RadioButton();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMulher = new System.Windows.Forms.CheckBox();
            this.txtQuantidadeFilmes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContaBancaria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(418, 391);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 37);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 68);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEscuridaoNao);
            this.groupBox1.Controls.Add(this.rbEscuridaoSim);
            this.groupBox1.Location = new System.Drawing.Point(11, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escuridão";
            // 
            // rbEscuridaoNao
            // 
            this.rbEscuridaoNao.AutoSize = true;
            this.rbEscuridaoNao.Location = new System.Drawing.Point(60, 30);
            this.rbEscuridaoNao.Margin = new System.Windows.Forms.Padding(2);
            this.rbEscuridaoNao.Name = "rbEscuridaoNao";
            this.rbEscuridaoNao.Size = new System.Drawing.Size(45, 17);
            this.rbEscuridaoNao.TabIndex = 1;
            this.rbEscuridaoNao.TabStop = true;
            this.rbEscuridaoNao.Text = "Não";
            this.rbEscuridaoNao.UseVisualStyleBackColor = true;
            // 
            // rbEscuridaoSim
            // 
            this.rbEscuridaoSim.AutoSize = true;
            this.rbEscuridaoSim.Location = new System.Drawing.Point(4, 30);
            this.rbEscuridaoSim.Margin = new System.Windows.Forms.Padding(2);
            this.rbEscuridaoSim.Name = "rbEscuridaoSim";
            this.rbEscuridaoSim.Size = new System.Drawing.Size(42, 17);
            this.rbEscuridaoSim.TabIndex = 0;
            this.rbEscuridaoSim.TabStop = true;
            this.rbEscuridaoSim.Text = "Sim";
            this.rbEscuridaoSim.UseVisualStyleBackColor = true;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(16, 175);
            this.txtNomePessoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(201, 20);
            this.txtNomePessoa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Pessoa";
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Humano",
            "Orc",
            "Fada",
            "Nórdico",
            "Avatar",
            "Alien",
            "Sayajin"});
            this.cbRaca.Location = new System.Drawing.Point(16, 222);
            this.cbRaca.Margin = new System.Windows.Forms.Padding(2);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(201, 21);
            this.cbRaca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raça";
            // 
            // cbMulher
            // 
            this.cbMulher.AutoSize = true;
            this.cbMulher.Location = new System.Drawing.Point(16, 256);
            this.cbMulher.Margin = new System.Windows.Forms.Padding(2);
            this.cbMulher.Name = "cbMulher";
            this.cbMulher.Size = new System.Drawing.Size(58, 17);
            this.cbMulher.TabIndex = 8;
            this.cbMulher.Text = "Mulher";
            this.cbMulher.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadeFilmes
            // 
            this.txtQuantidadeFilmes.Location = new System.Drawing.Point(16, 293);
            this.txtQuantidadeFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidadeFilmes.Name = "txtQuantidadeFilmes";
            this.txtQuantidadeFilmes.Size = new System.Drawing.Size(201, 20);
            this.txtQuantidadeFilmes.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade Filmes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Conta Bancária";
            // 
            // txtContaBancaria
            // 
            this.txtContaBancaria.Location = new System.Drawing.Point(16, 330);
            this.txtContaBancaria.Margin = new System.Windows.Forms.Padding(2);
            this.txtContaBancaria.Name = "txtContaBancaria";
            this.txtContaBancaria.Size = new System.Drawing.Size(201, 20);
            this.txtContaBancaria.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(229, 29);
            this.rtbDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(259, 358);
            this.rtbDescricao.TabIndex = 15;
            this.rtbDescricao.Text = "";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(16, 367);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(201, 20);
            this.dtpDataNascimento.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(201, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Código";
            // 
            // CadastroHeroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 434);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContaBancaria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantidadeFilmes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMulher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroHeroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEscuridaoNao;
        private System.Windows.Forms.RadioButton rbEscuridaoSim;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbMulher;
        private System.Windows.Forms.TextBox txtQuantidadeFilmes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContaBancaria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
    }
}

