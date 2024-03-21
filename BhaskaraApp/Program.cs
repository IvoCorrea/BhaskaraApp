using System;
using System.Drawing;

namespace BhaskaraApp {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite A: ");
           int valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite B: ");
           int valorB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite C: ");
           int valorC = Convert.ToInt32(Console.ReadLine());

           double x1 = Bhaskara(valorA, valorB, valorC, "soma");
           double x2 = Bhaskara(valorA, valorB, valorC, "subt");

           Console.Clear();
           Console.WriteLine("As raizes da sua operação é " + x1 + " e " + x2);
           Console.WriteLine();
        }

        static int Delta(int a, int b, int c)
        {
            return (b * b) - (4 * a * c);
        }
        
        static double Bhaskara(int a, int b, int c, string operacao)
        {
            if (operacao == "soma")
            {
                double soma = (-b + Math.Sqrt(Delta(a, b, c))) /2;
                return soma;
            }

            else if (operacao == "subt")
            {
                double subt = (-b - Math.Sqrt(Delta(a, b, c))) /2;
                return subt;
            }
            else 
            { 
                return 1.0; 
            }
        }
    }
}




