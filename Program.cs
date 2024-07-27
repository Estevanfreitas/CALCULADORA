using System;

namespace CALCULADORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qualoperacao deseja fazer");
            Console.WriteLine("Qualoperacao deseja fazer");
            Console.WriteLine("1- adiçao");
            Console.WriteLine("2- Subtraçao");
            Console.WriteLine("4- Multiuplicaçao ");
            Console.WriteLine("3- Divisao  \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("numero invalido, mostro outro.");
                    break;
            }

            Console.WriteLine("o resultado da operacao com os numeros {0}e {1} e: {2}",num1, num2, resultado);

            Console.ReadLine();

        }

        public static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}
