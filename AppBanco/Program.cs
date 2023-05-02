using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Saldo, Valor;
            int Controle;
            bool App = true;


            Console.WriteLine("Coloque o seu saldo atual");
            Saldo = double.Parse(Console.ReadLine());

            while(App == true)
            {
                Console.Clear();
                Console.WriteLine($"Seu saldo atual é de: {Saldo.ToString("C")}\n" +
                    "Você deseja fazer um deposito uo um saque?\n" +
                    "1-Deposito\n" +
                    "2-Saque\n" +
                    "0-Fechar Programa");
                Controle = int.Parse(Console.ReadLine());
                Controle = opicoes(Controle, Saldo);

                Console.Clear();

                switch (Controle)
                {
                    case 1:
                        Console.WriteLine($"Você tem um total de: R${Saldo.ToString("C")} na sua conta, qual o valor do deposito você deseja fazer?");
                        Valor = double.Parse(Console.ReadLine());
                        Valor = positivo(Valor);

                        Saldo = Saldo + Valor;

                        Console.WriteLine($"Seu deposito foi efetuado, o seu saldo total é de:{Saldo.ToString("C")}");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine($"Você tem um total de: R${Saldo.ToString("C")} na sua conta, qual o valor do saque você deseja fazer?");
                        Valor = double.Parse(Console.ReadLine());
                        Valor = positivo(Valor);

                        if (Valor <= Saldo)
                        {
                            Saldo = Saldo - Valor;
                            Console.WriteLine($"Seu saque foi efetuado, o seu saldo total é de:{Saldo.ToString("C")}");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Seu saldo não e suficiente para esse saque.");
                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        App = false;
                        break;
                }
            }

            Console.WriteLine("Volte sempre!");
            Console.ReadKey();
        }

        static double positivo(double valor)
        {
            while(valor < 0)
            {
                Console.WriteLine("O valor não pode ser menor que 0, coloque outro.");
                valor = double.Parse(Console.ReadLine());
            }
            return(valor);
        }
        static int opicoes(int controle, double Saldo)
        {
            Console.Clear();
            while (controle != 1 && controle != 2 && controle != 0)
            {
                Console.WriteLine("Escolha invalida, coloque uma escolha valida:");
                Console.WriteLine($"Seu saldo atual é de: {Saldo.ToString("C")}\n" +
                    "Você deseja fazer um deposito uo um saque?\n" +
                    "1-Deposito\n" +
                    "2-Saque\n" +
                    "0-Fechar Programa");
                controle = int.Parse(Console.ReadLine());
            }
            return controle;
        }
    }
}
