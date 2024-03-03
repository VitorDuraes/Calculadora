using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Operação deseja fazer?");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão\n");

            decimal operacao = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal resultado = 0;

            //switch case vai chamar os metodos quando tiverem prontos
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
                    Console.WriteLine("Numero invalido, digite outro numero");
                    break;
            }

            Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, resultado);
            Console.ReadLine();


        }





        //Metodos para fazer as operação
        //Metodos auxiliares para realizar o calculo
        public static decimal Adicao(decimal numero1, decimal numero2)
            {
            decimal result = numero1 + numero2;
            return result;
            }
        public static decimal Subtracao(decimal numero1, decimal numero2)
        {
            decimal result = numero1 - numero2;
            return result;
        }
        public static decimal Multiplicacao(decimal numero1, decimal numero2)
        {
            decimal result = numero1 * numero2;
            return result;
        }
        public static decimal Divisao(decimal numero1, decimal numero2)
        {
            decimal result = numero1 / numero2;
            return result;
        }
   
    }
}
