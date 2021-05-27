using System;

namespace Exercicios_POO.Classes
{
    public abstract class Elevador
    {
        protected int AndarAtual;

        protected int TotalAndares;

        protected int Capacidade;

        protected int PessoasPresentes;

        public void Inicializar() {
            AndarAtual = 0;
            PessoasPresentes = 0;

            bool isInt;
            do
            {
                Console.Write("Quantas pessoas cabem no elevador? ");
                string capacidade = Console.ReadLine();
                isInt = int.TryParse(capacidade, out Capacidade);
                if (isInt) {
                    Capacidade = int.Parse(capacidade);
                } else {
                    Console.WriteLine("Digite apenas números");
                }
            } while (!isInt);

            do
            {
                Console.Write("\nO prédio possui quantos andares? ");
                string AndaresStr = Console.ReadLine();
                isInt = int.TryParse(AndaresStr, out TotalAndares);
                if (isInt) {
                    TotalAndares = int.Parse(AndaresStr);
                } else {
                    Console.WriteLine("Digite apenas números");
                }
            } while (!isInt);

            Console.WriteLine($"\nO elevador está no {AndarAtual}º andar e com {PessoasPresentes} pessoas\n");
        }

        public void Entrar(){
            if (PessoasPresentes < Capacidade) 
            {
                PessoasPresentes++;
                int sobra = Capacidade - PessoasPresentes;
                if (sobra > 0)
                {
                    Console.WriteLine($"\nUma pessoa entrou no elevador no {AndarAtual}º andar, ainda cabem {sobra} pessoas\n");

                } else {Console.WriteLine("\nO elevador atingiu a capacidade máxima");}
            } else {
                Console.WriteLine("\nO elevador já atingiu a capacidade máxima.");
            }
        }

        public void Sair(){
            if (PessoasPresentes > 0) {
                PessoasPresentes--;
                if (PessoasPresentes > 0) {
                    Console.WriteLine($"\nUma pessoa saiu do elevador no {AndarAtual}º andar, ainda restam {PessoasPresentes} prensentes\n");
                }
            } else {Console.WriteLine("\nO elevador já está vazio");}
        }

        public void Subir(){
            if (AndarAtual < TotalAndares) 
            {
                AndarAtual++;
                Console.WriteLine($"\nO elevador subiu para o {AndarAtual}º andar");
            } else {
                Console.WriteLine("\nO elevador já está no ultimo andar, só é possivel descer");
            }
        }

        public void Descer() {
            if (AndarAtual > 0) {
                AndarAtual--;
                Console.WriteLine($"\nO elevador desceu para o {AndarAtual}º andar");
            } else {
                Console.WriteLine("\nO elevador já está no té rreo");
            }
        }
    }
}