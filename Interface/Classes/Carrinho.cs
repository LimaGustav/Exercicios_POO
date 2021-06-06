using System;
using System.Collections.Generic;
using Interfaces;

namespace Interface.Classes
{
    public class Carrinho : ICarrinho
    {   

        float ValorTotal;

        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine ($"{item.Nome} - {item.Preco}");
            }
        }
    }
}