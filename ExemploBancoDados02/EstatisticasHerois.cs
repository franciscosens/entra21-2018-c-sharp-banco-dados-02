﻿using ExemploBancoDados02.Repositorio;
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
    public partial class EstatisticasHerois : Form
    {
        public EstatisticasHerois()
        {
            InitializeComponent();
        }

        private void EstatisticasHerois_Load(object sender, EventArgs e)
        {
            double totalContas = new HeroiRepositorio().ObterTotalContas();
            lblTotalContasBancarias.Text = Convert.ToString(totalContas);
        }
    }
}
