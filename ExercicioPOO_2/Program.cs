using System;
using ExercicioPOO_2.Classes;

namespace ExercicioPOO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque jogador1= new JogadorAtaque();

            Console.Write("Qual o nome do jogador? ");
            jogador1.Nome = Console.ReadLine().ToUpper();

            Console.Write("Qual o ano de nascimento do jogador? ");
            jogador1.AnoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Qual a altura do jogador? ");
            jogador1.Altura = double.Parse(Console.ReadLine());

            Console.Write("Qual a naturalidade do jogador? ");
            jogador1.Naturalidade = Console.ReadLine().ToUpper();

            Console.Write("Qual o peso do jogador? ");
            jogador1.Peso = double.Parse(Console.ReadLine());

            jogador1.Dados();
            Console.WriteLine(jogador1.Aposentar());
        }
    }
}
