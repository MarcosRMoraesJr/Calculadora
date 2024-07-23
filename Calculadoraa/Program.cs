using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoraa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            int resultado = 0;

            int operacao = 0;

            do
            {
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair \n");

                operacao = int.Parse(Console.ReadLine()); //Conversor para transformar um número digitado de string para int e armazena

                if (operacao >= 1 && operacao <= 5)
                {
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                }

                else
                {
                    Console.WriteLine("Escolha inválida. Digite um número válido.");
                }
            }
            while (operacao >=1 || operacao <= 5);

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
                    Console.WriteLine("Número inválido, digite outro número");
                    break;
            }
            if (operacao >= 1 && operacao <= 4)
            {
                Console.WriteLine("O resultado do calculo com os números {0} e {1} é: {2}",num1,num2,resultado);
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
                return;
            }
        }

        public static int Adicao (int numero1, int numero2) 
            {
            int resultado = numero1 + numero2;
            return resultado;
            }

        public static int Subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }

    }
}
