using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDados02.Modelo
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Escuridao { get; set; }
        [DisplayName("Nome")]
        public string NomePessoa { get; set; }
        public string Raca { get; set; }
        public double ContaBancaria { get; set; }
        [DisplayName("DataNascimento")]
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        [Browsable(false)]
        public byte QuantidadeFilmes { get; set; }
        public string Descricao { get; set; }
    }
}
