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
            this.dataGridView1.Location = new System.Drawing.Point(16, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 636);
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
            this.button1.Location = new System.Drawing.Point(1048, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1048, 89);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(181, 70);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(1048, 165);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(181, 70);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(1048, 242);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(181, 70);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstatisticas.Location = new System.Drawing.Point(1048, 320);
            this.btnEstatisticas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(181, 70);
            this.btnEstatisticas.TabIndex = 5;
            this.btnEstatisticas.Text = "Estatísticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisa";
            // 
            // txtPequisa
            // 
            this.txtPequisa.Font = new System.Drawing.Font("Magneto", 12F);
            this.txtPequisa.Location = new System.Drawing.Point(16, 38);
            this.txtPequisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPequisa.Name = "txtPequisa";
            this.txtPequisa.Size = new System.Drawing.Size(383, 32);
            this.txtPequisa.TabIndex = 7;
            this.txtPequisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPequisa.Leave += new System.EventHandler(this.txtPequisa_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbColunaContaBancaria);
            this.groupBox1.Controls.Add(this.rbColunaRaca);
            this.groupBox1.Controls.Add(this.rbColunaNome);
            this.groupBox1.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(408, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(392, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coluna";
            // 
            // rbColunaContaBancaria
            // 
            this.rbColunaContaBancaria.AutoSize = true;
            this.rbColunaContaBancaria.Location = new System.Drawing.Point(195, 28);
            this.rbColunaContaBancaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbColunaContaBancaria.Name = "rbColunaContaBancaria";
            this.rbColunaContaBancaria.Size = new System.Drawing.Size(173, 25);
            this.rbColunaContaBancaria.TabIndex = 2;
            this.rbColunaContaBancaria.TabStop = true;
            this.rbColunaContaBancaria.Text = "Conta Bancária";
            this.rbColunaContaBancaria.UseVisualStyleBackColor = true;
            this.rbColunaContaBancaria.CheckedChanged += new System.EventHandler(this.rbColunaRaca_CheckedChanged);
            // 
            // rbColunaRaca
            // 
            this.rbColunaRaca.AutoSize = true;
            this.rbColunaRaca.Location = new System.Drawing.Point(109, 30);
            this.rbColunaRaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbColunaRaca.Name = "rbColunaRaca";
            this.rbColunaRaca.Size = new System.Drawing.Size(78, 25);
            this.rbColunaRaca.TabIndex = 1;
            this.rbColunaRaca.TabStop = true;
            this.rbColunaRaca.Text = "Raça";
            this.rbColunaRaca.UseVisualStyleBackColor = true;
            this.rbColunaRaca.CheckedChanged += new System.EventHandler(this.rbColunaRaca_CheckedChanged);
            // 
            // rbColunaNome
            // 
            this.rbColunaNome.AutoSize = true;
            this.rbColunaNome.Location = new System.Drawing.Point(9, 30);
            this.rbColunaNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbColunaNome.Name = "rbColunaNome";
            this.rbColunaNome.Size = new System.Drawing.Size(83, 25);
            this.rbColunaNome.TabIndex = 0;
            this.rbColunaNome.TabStop = true;
            this.rbColunaNome.Text = "Nome";
            this.rbColunaNome.UseVisualStyleBackColor = true;
            this.rbColunaNome.CheckedChanged += new System.EventHandler(this.rbColunaNome_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOrdemDESC);
            this.groupBox2.Controls.Add(this.rbOrdemASC);
            this.groupBox2.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(808, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(232, 59);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem";
            // 
            // rbOrdemDESC
            // 
            this.rbOrdemDESC.AutoSize = true;
            this.rbOrdemDESC.Location = new System.Drawing.Point(109, 30);
            this.rbOrdemDESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOrdemDESC.Name = "rbOrdemDESC";
            this.rbOrdemDESC.Size = new System.Drawing.Size(88, 25);
            this.rbOrdemDESC.TabIndex = 1;
            this.rbOrdemDESC.TabStop = true;
            this.rbOrdemDESC.Text = "DESC";
            this.rbOrdemDESC.UseVisualStyleBackColor = true;
            this.rbOrdemDESC.CheckedChanged += new System.EventHandler(this.rbColunaRaca_CheckedChanged);
            // 
            // rbOrdemASC
            // 
            this.rbOrdemASC.AutoSize = true;
            this.rbOrdemASC.Location = new System.Drawing.Point(9, 30);
            this.rbOrdemASC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOrdemASC.Name = "rbOrdemASC";
            this.rbOrdemASC.Size = new System.Drawing.Size(79, 25);
            this.rbOrdemASC.TabIndex = 0;
            this.rbOrdemASC.TabStop = true;
            this.rbOrdemASC.Text = "ASC";
            this.rbOrdemASC.UseVisualStyleBackColor = true;
            this.rbOrdemASC.CheckedChanged += new System.EventHandler(this.rbColunaRaca_CheckedChanged);
            // 
            // ListaHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 742);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListaHerois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de heróis";
            this.Activated += new System.EventHandler(this.ListaHerois_Activated);
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