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
    public partial class formteste : Form
    {
        public formteste()
        {
            InitializeComponent();
            this.Load += formteste_Load;
        }

        void formteste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new HeroiRepositorio().ObterTodos();
        }
    }
}
