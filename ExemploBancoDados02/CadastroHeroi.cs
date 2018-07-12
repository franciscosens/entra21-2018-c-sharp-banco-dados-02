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
    public partial class CadastroHeroi : Form
    {
        private int codigo;

        public CadastroHeroi()
        {
            InitializeComponent();
        }

        public CadastroHeroi(int codigo)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.codigo = codigo;
            Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(codigo);
            txtNome.Text = heroi.Nome;
            txtNomePessoa.Text = heroi.NomePessoa;
            txtCodigo.Text = Convert.ToString(heroi.Id);
            txtContaBancaria.Text = Convert.ToString(heroi.ContaBancaria);
            txtQuantidadeFilmes.Text = Convert.ToString(heroi.QuantidadeFilmes);
            cbMulher.Checked = heroi.Sexo == 'm';
            cbRaca.SelectedItem = heroi.Raca;
            rtbDescricao.Text = heroi.Descricao;
            if (heroi.Escuridao)
            {
                rbEscuridaoSim.Checked = true;
            }
            else
            {
                rbEscuridaoNao.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = txtNomePessoa.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtpDataNascimento.Value;
            heroi.Escuridao = rbEscuridaoSim.Checked;
            heroi.QuantidadeFilmes = Convert.ToByte(txtQuantidadeFilmes.Text);
            heroi.Raca = cbRaca.SelectedItem.ToString();
            heroi.Sexo = cbMulher.Checked ? 'm' : 'h';
            heroi.Descricao = rtbDescricao.Text;
            bool cadastrou = new HeroiRepositorio().Inserir(heroi);
            if (cadastrou)
            {
                MessageBox.Show("Registro cadastrado com sucesso.");
            }
            else
            {
                MessageBox.Show("Deu ruim, chame os prog.");
            }

        }
    }
}
