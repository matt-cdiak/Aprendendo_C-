using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Systems.Aprendendo.ConsoleApplication
{
    public class Pessoa
    {
        //propriedades
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String NumeroContaCorrente { get; set; }

        //métodos (ações)
        public double EfetuarDeposito(double valorDeposito)
        {
            double saldo = 100.0;
            return saldo = saldo + valorDeposito;
        }
    }
}
