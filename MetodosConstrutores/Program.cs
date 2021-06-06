using System;
using MetodosConstrutores.Classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de Métodos Construtores");

            Produto p = new Produto();
            Console.WriteLine("Método construtor sem argumentos");
            Console.WriteLine($"Código: {p.Codigo}\nNome: {p.Nome}\nDescrição: {p.Descricao}\nItens no estoque: {p.Estoque}");

            Console.WriteLine("\n");

            Produto o = new Produto(435,"Iphone 12", "Muito Bom", 8);
            Console.WriteLine($"Código: {o.Codigo}\nNome: {o.Nome}\nDescrição: {o.Descricao}\nItens no estoque: {o.Estoque}");
        }
    }
}