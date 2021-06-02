using System;
using ExercicioPOO_3.Classes;

namespace ExercicioPOO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe CafeteiraTabajarasPlus = new MaquinaCafe();
            bool isDouble = false;
            double acucarMaq;
            bool check = false;
            do
            {
                Console.Write("Há quantas gramas de açucar disponível na cafeteira? ");
                string acucarStr = Console.ReadLine();
                isDouble = double.TryParse(acucarStr, out acucarMaq);

                if (isDouble)
                {
                    acucarMaq = double.Parse(acucarStr);
                } else {
                    Console.WriteLine("Digite apenas números");
                }
            } while (!isDouble);
            
            CafeteiraTabajarasPlus.AcucarDisponivel = acucarMaq;

            Console.WriteLine("\n\t\tCafeteiraTabajaras Plus++");
            Console.WriteLine("Experimente o melhor Café, de qualidade incomensurável");

            string maisCafe;
            bool opcaoValida = true;
            while (!check) {
                Console.WriteLine($"\nTemos {CafeteiraTabajarasPlus.AcucarDisponivel} gramas de açucar disponivel\n\n");
                do
                {
                    Console.Write("\t\tVocê deseja\n\nCafé padrão [1]\nEscolher a quantidade de açucar no seu café [2]\nCafé sem açucar [3]\nDesligar a maquina [4]-> ");
                    string opcao = Console.ReadLine();
                    
                    switch (opcao)
                    {
                        case "1":
                            CafeteiraTabajarasPlus.FazerCafe();
                            break;
                        case "2":
                            if (CafeteiraTabajarasPlus.AcucarDisponivel == 0) {
                                Console.WriteLine("O açucar acabou");
                            } else {Console.Write("Você deseja quantas gramas de açucar? ");}
                            double acucar = double.Parse(Console.ReadLine());
                            CafeteiraTabajarasPlus.FazerCafe(acucar);
                            break;
                        case "3":
                            Console.WriteLine("\nO seu café sem açucar está pronto.");
                            break;
                        case "4":
                            check = true; // Sai do programa
                            break;
                        default:
                            Console.WriteLine("\t\tOpção invalida\n");
                            opcaoValida = false;
                            break;
                    }
                } while (!opcaoValida);
                
                bool opcMaisCafe = true;
                do
                {
                    Console.Write("Deseja fazer mais café? (S/N) ");
                    maisCafe = Console.ReadLine().ToLower().Substring(0,1);
                    if (maisCafe == "n" || maisCafe == "s") opcMaisCafe = false;
                    else Console.WriteLine("Opção invalida. Tente novamente.");
                } while (opcMaisCafe);
                if (maisCafe == "n") {
                    check = true;
                }
            }
            Console.WriteLine("Obrigado por usar a CafeteiraTabajaras Plus++");
        }
    }
}
