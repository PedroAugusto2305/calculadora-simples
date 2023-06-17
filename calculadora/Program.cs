using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora!");
            Console.WriteLine("------------------------");

            // declarando os números que serão manipulados
            Console.WriteLine("Informe o primeiro número:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------");

            // escolhendo a operação desejada
            Console.WriteLine("Agora escolha uma operação:");

            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair da calculadora.");

            Console.WriteLine("Digite a opção desejada");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (opcao) 
             {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!!");
                    break;
                }

            Console.WriteLine("------------------------");
            Console.WriteLine("Resultado: " + result);

            Console.WriteLine("------------------------");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
