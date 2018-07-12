namespace ExemploBancoDados02
{
    partial class ListaHerois
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPequisa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbColunaContaBancaria = new System.Windows.Forms.RadioButton();
            this.rbColunaRaca = new System.Windows.Forms.RadioButton();
            this.rbColunaNome = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOrdemDESC = new System.Windows.Forms.RadioButton();
            this.rbOrdemASC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnRaca,
            this.ColumnBancaria});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // ColumnBancaria
            // 
            this.ColumnBancaria.HeaderText = "Bancária";
            this.ColumnBancaria.Name = "ColumnBancaria";
            this.ColumnBancaria.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(786, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.btnEditar.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(786, 72);
            this.btnEditar.Name = "button2";
            this.btnEditar.Size = new System.Drawing.Size(136, 57);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(786, 134);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(136, 57);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(786, 197);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(136, 57);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstatisticas.Location = new System.Drawing.Point(786, 260);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(136, 57);
            this.btnEstatisticas.TabIndex = 5;
            this.btnEstatisticas.Text = "Estatísticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisa";
            // 
            // txtPequisa
            // 
            this.txtPequisa.Font = new System.Drawing.Font("Magneto", 12F);
            this.txtPequisa.Location = new System.Drawing.Point(12, 31);
            this.txtPequisa.Name = "txtPequisa";
            this.txtPequisa.Size = new System.Drawing.Size(288, 27);
            this.txtPequisa.TabIndex = 7;
            this.txtPequisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbColunaContaBancaria);
            this.groupBox1.Controls.Add(this.rbColunaRaca);
            this.groupBox1.Controls.Add(this.rbColunaNome);
            this.groupBox1.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(306, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coluna";
            // 
            // rbColunaContaBancaria
            // 
            this.rbColunaContaBancaria.AutoSize = true;
            this.rbColunaContaBancaria.Location = new System.Drawing.Point(146, 23);
            this.rbColunaContaBancaria.Name = "rbColunaContaBancaria";
            this.rbColunaContaBancaria.Size = new System.Drawing.Size(143, 22);
            this.rbColunaContaBancaria.TabIndex = 2;
            this.rbColunaContaBancaria.TabStop = true;
            this.rbColunaContaBancaria.Text = "Conta Bancária";
            this.rbColunaContaBancaria.UseVisualStyleBackColor = true;
            // 
            // rbColunaRaca
            // 
            this.rbColunaRaca.AutoSize = true;
            this.rbColunaRaca.Location = new System.Drawing.Point(82, 24);
            this.rbColunaRaca.Name = "rbColunaRaca";
            this.rbColunaRaca.Size = new System.Drawing.Size(64, 22);
            this.rbColunaRaca.TabIndex = 1;
            this.rbColunaRaca.TabStop = true;
            this.rbColunaRaca.Text = "Raça";
            this.rbColunaRaca.UseVisualStyleBackColor = true;
            // 
            // rbColunaNome
            // 
            this.rbColunaNome.AutoSize = true;
            this.rbColunaNome.Location = new System.Drawing.Point(7, 24);
            this.rbColunaNome.Name = "rbColunaNome";
            this.rbColunaNome.Size = new System.Drawing.Size(69, 22);
            this.rbColunaNome.TabIndex = 0;
            this.rbColunaNome.TabStop = true;
            this.rbColunaNome.Text = "Nome";
            this.rbColunaNome.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOrdemDESC);
            this.groupBox2.Controls.Add(this.rbOrdemASC);
            this.groupBox2.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(606, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 48);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem";
            // 
            // rbOrdemDESC
            // 
            this.rbOrdemDESC.AutoSize = true;
            this.rbOrdemDESC.Location = new System.Drawing.Point(82, 24);
            this.rbOrdemDESC.Name = "rbOrdemDESC";
            this.rbOrdemDESC.Size = new System.Drawing.Size(73, 22);
            this.rbOrdemDESC.TabIndex = 1;
            this.rbOrdemDESC.TabStop = true;
            this.rbOrdemDESC.Text = "DESC";
            this.rbOrdemDESC.UseVisualStyleBackColor = true;
            // 
            // rbOrdemASC
            // 
            this.rbOrdemASC.AutoSize = true;
            this.rbOrdemASC.Location = new System.Drawing.Point(7, 24);
            this.rbOrdemASC.Name = "rbOrdemASC";
            this.rbOrdemASC.Size = new System.Drawing.Size(65, 22);
            this.rbOrdemASC.TabIndex = 0;
            this.rbOrdemASC.TabStop = true;
            this.rbOrdemASC.Text = "ASC";
            this.rbOrdemASC.UseVisualStyleBackColor = true;
            // 
            // ListaHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPequisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaHerois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de heróis";
            this.Load += new System.EventHandler(this.ListaHerois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEstatisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPequisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbColunaContaBancaria;
        private System.Windows.Forms.RadioButton rbColunaRaca;
        private System.Windows.Forms.RadioButton rbColunaNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOrdemDESC;
        private System.Windows.Forms.RadioButton rbOrdemASC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBancaria;
    }
}