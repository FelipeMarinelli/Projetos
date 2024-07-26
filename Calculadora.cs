using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace calcul
{

    class Program
    {


        static void Main(string[] args)
        {
            int num1;
            int num2;
            int inv = 0;

            string resposta;

            Console.WriteLine("Bem vindo a calculadora");
            Console.WriteLine("Primeiro digito:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo digito");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual vai ser sua operacao?");

            Console.WriteLine("(a) para adicao " +
                "(s) para subtracao " +
                "(m) para multiplicacao " +
                "(d) para divisao");

            resposta = Console.ReadLine();

            if (resposta == "a")
            {
                Console.WriteLine(num1 + num2);
            }
            if (resposta == "s")
            {
                Console.WriteLine(num1 - num2);
            }
            if (resposta == "m")
            {
                Console.WriteLine(num1 * num2);
            }
            if (resposta == "d")
            {
                Console.WriteLine(num1 / num2);
            }
            if (resposta != "a")
            
            {
                inv += 1;
            };
            if (resposta != "s")

            {
                inv += 1;
            };
            if (resposta != "m")

            {
                inv += 1;
            };
            if (resposta != "d")

            {
                inv += 1;
            };
            if (inv >= 4)
            {
                Console.WriteLine("Valor invalido");
            }






            Console.ReadKey();
        }
    }
}
