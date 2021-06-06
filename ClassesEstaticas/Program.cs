using System;
using ClassesEstaticas.Classes;

namespace ClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa conversor de moeda");

            Console.Write("Digite o valor em reais R$");
            float reais = float.Parse(Console.ReadLine());

            Console.Write("Valor em US: ");
            Console.Write(Conversor.RealParaDolar(reais));

            
        }
    }
}
