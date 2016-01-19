using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.Financas.Dominio.Models
{
    public class Conta
    {
        public int IdConta { get; set; }
        public string Nome { get; set; }
        public int Banco { get; set; }
        public int Agencia { get; set; }
        public int ContaComDigito { get; set; }
        public decimal Saldo { get; set; }
    }
}
