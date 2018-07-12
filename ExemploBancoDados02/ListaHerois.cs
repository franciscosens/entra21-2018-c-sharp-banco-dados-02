using ExemploBancoDados02.Modelo;
using ExemploBancoDados02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDados02
{
    public partial class ListaHerois : Form
    {
        public ListaHerois()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroHeroi().ShowDialog();
        }

        private void AtualizarLista()
        {
            string coluna = "nome";
            if (rbColunaRaca.Checked)
            {
                coluna = "raca";
            }
            else if (rbColunaContaBancaria.Checked)
            {
                coluna = "conta_bancaria";
            }

            string tipoOrdenacao = "ASC";
            if (rbOrdemDESC.Checked)
            {
                tipoOrdenacao = "DESC";
            }
            
            dataGridView1.Rows.Clear();
            List<Heroi> herois = new HeroiRepositorio().ObterTodos(txtPequisa.Text, coluna, tipoOrdenacao);
            foreach (Heroi heroi in herois)
            {
                dataGridView1.Rows.Add(new object[]{
                    heroi.Id,
                    heroi.Nome,
                    heroi.Raca,
                    heroi.ContaBancaria
                });
            }
        }


        private void ListaHerois_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            bool apagado = new HeroiRepositorio().Apagar(codigo);
            if (apagado)
            {
                dataGridView1.Rows.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível apagar");
            }
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            new EstatisticasHerois().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastroHeroi(codigo).ShowDialog();
        }


    }
}
