using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appExemploAula15.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento{ get; set; }


        public int idade
        {
            get
            {
                int dias = DateTime.Now.Subtract(DataNascimento).Days;
                return dias / 365;
            }
        }
    }
}
