using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Systems.Aprendendo.ConsoleApplication
{
    class Program
    {
        //enum DiasUteisDaSemana
        //{
        //    SegundaFeira,
        //    TerçaFeira,
        //    QuartaFeira,
        //    QuintaFeira,
        //    SextaFeira
        //};

        //enum DiasDaSemana
        //{
        //    Domingo = 0,
        //    SegundaFeira = 1,
        //    TerçaFeira = 2,
        //    QuartaFeira = 3,
        //    QuintaFeira = 4,
        //    SextaFeira = 5,
        //    Sábado = 6
        //};
        static void Main(string[] args)
        {
            //var diaDaSemana = (int)DiasDaSemana.QuartaFeira;
            //Console.Write("Hoje é dia: " + diaDaSemana);
            //Console.Read();

            //var diaDaSemana = DiasUteisDaSemana.QuartaFeira;
            //Console.Write("Hoje é dia: " + diaDaSemana);
            //Console.Read();

            //var nomeCorrentista = "";
            //nomeCorrentista = Console.ReadLine();
            //Console.Write("Nome da variável: " + nomeCorrentista);
            //Console.ReadLine();

            //int xpto = 10;

            //int xpto = Convert.ToInt32("10");

            //var dataAniversario = Convert.ToDateTime("17/07/2001");

            //double saldo = 100.0;
            //saldo = saldo - 10.0;
            //Console.Write("O saldo atual é: " + saldo);
            //Console.ReadLine();

            //String[] nomes = new String[2];
            //nomes[0] = "Thiago Crivelari";
            //nomes[1] = "Priscila Crivelari";
            //Console.Write("nome = " + nomes[0] + "\n");
            //Console.Write("nome = " + nomes[1]);
            //Console.ReadLine();

            //String[] nomes = new String[] { "Thiago Crivelari", "Priscila Crivelari", "Eugenio Junior" };
            //Console.Write("nome = " + nomes[0] + "\n");
            //Console.Write("nome = " + nomes[1] + "\n");
            //Console.Write("nome = " + nomes[2]);
            //Console.ReadLine();

            //const Double Pi = 3.14159;
            //Double radius = 5.3;
            //Double area = Pi * (radius * radius);
            //Console.Write("O valor da área é: " + area);
            //Console.ReadLine();  

            //var pessoas = new List<string> { "Thiago Crivelari", "Priscila Crivelari", "Eugenio Junior" };

            //List<String> pessoas = new List<string>();
            //pessoas.Add("Matheus Crivelari");
            //pessoas.Add("Thiago Crivelari");
            //pessoas.Add("Priscila Crivelari");
            //pessoas.Add("Eugenio Junior");
            //Console.Write("Pessoa: " + pessoas[0] + ", com o tamanho da lista: " + pessoas.Count());
            //Console.ReadLine();

            //var familia = new List<string>();
            //familia.Add("Matheus Crivelari");
            //familia.Add("Thiago Crivelari");
            //familia.Add("Priscila Crivelari");
            //familia.Add("Eugenio Junior");
            //bool existeNaLista = familia.Contains("Matheus Crivelari");
            //Console.Write("existe na lista: " + existeNaLista);
            //Console.ReadLine();

            //int tamanho = 10;
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write("O valor da variável é: " + i + "\n");
            //    Console.ReadKey();
            //}

            //Double saldoConta = 100.0;
            //Console.Write("Digite um valor para debitar da sua conta: ");
            //var debitar = Convert.ToDouble(Console.ReadLine());
            //saldoConta = saldoConta - debitar;
            //if (saldoConta > 0)
            //{
            //    Console.Write("Seu saldo é positivo. Ainda restam {0} em conta", saldoConta);
            //}
            //else
            //{
            //    Console.Write("Seu saldo é negativo. O valor é {0}", saldoConta);
            //}
            //Console.ReadKey();

            //var carros = new List<String> { "Jetta", "Fusca", "Santana", "Passat", "Fox" };
            //foreach (var carro in carros)
            //{
            //    Console.Write("O nome do carro é: " + carro + "\n");
            //    Console.ReadKey();
            //}

            //Double saldoConta = 100.0;
            //Console.Write("Digite um valor para debitar da sua conta: ");
            //var debitar = Convert.ToDouble(Console.ReadLine());
            //saldoConta = saldoConta - debitar;
            //switch (saldoConta)
            //{
            //    case 50.0:
            //        Console.Write("Você debitou 50.0 da sua conta");
            //        break;
            //    case 10.0:
            //        Console.Write("Você debitou 90.0 da sua conta");
            //        break;
            //    default:
            //        Console.Write("Você debitou {0} da sua conta", debitar);
            //        break;
            //}
            //Console.ReadKey();

            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.Nome = "Matheus Crivelari";
            //pessoa1.CPF = "495.763.388-67";
            //pessoa1.NumeroContaCorrente = "010203";
            //Pessoa pessoa2 = new Pessoa()
            //{
            //    Nome = "Eugenio Junior",
            //    CPF = "182.935.948.70",
            //    NumeroContaCorrente = "030201"
            //};
            //var listaDePessoas = new List<Pessoa>{ pessoa1, pessoa2 };
            //foreach (var pessoa in listaDePessoas)
            //{
            //    Console.Write("Nome da pessoas: " + pessoa.Nome + "\n");
            //    Console.Write("CPF da pessoas: " + pessoa.CPF + "\n");
            //    Console.Write("Número da conta corrente da pessoas: " + pessoa.NumeroContaCorrente + "\n");
            //    Console.ReadKey();
            //}

            Pessoa pessoa1 = new Pessoa()
            {
                Nome = "Eugenio Junior",
                CPF = "182.935.948.70",
                NumeroContaCorrente = "030201"
            };
            Console.Write("Quanto deseja depositas: ");
            string value = Console.ReadLine();
            var valueDouble = Convert.ToDouble(value);
            Console.Write("Nome da pessoas: " + pessoa1.Nome + "\n");
            Console.Write("CPF da pessoas: " + pessoa1.CPF + "\n");
            Console.Write("Número da conta corrente da pessoas: " + pessoa1.NumeroContaCorrente + "\n");
            Console.Write("O saldo da conta é de: " + pessoa1.EfetuarDeposito(valueDouble));
            Console.ReadKey();
        }
    }
}