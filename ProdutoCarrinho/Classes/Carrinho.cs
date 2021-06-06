using System;
using System.Collections.Generic;

namespace ProdutoCarrinho.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto) {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto) {
            carrinho.Remove(produto);
        }

        public void MostrarProdutos() {
            if (carrinho != null) 
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{p.Preco:C2} - {p.Nome}");
                    Console.ResetColor();
                }

            }else {
                Console.WriteLine("Este carrinho está vazio");
            }
        }

        public void MostrarTotal() {
            Console.ForegroundColor = ConsoleColor.Blue;

            if (carrinho != null) {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do carrinho {ValorTotal:C2}");
            } else {
                Console.WriteLine("Este carrinho está vazio");
            }
            Console.ResetColor();
        }

        public void AlterarItem(int _codigo, Produto _novoProduto) {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}