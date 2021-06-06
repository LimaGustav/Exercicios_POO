using System;
using ProdutoCarrinho.Classes;

namespace ProdutoCarrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de produtos
            Produto p1 = new Produto(1,"Batata frita",30f);
            Produto p2 = new Produto(2,"Coberta", 28.90f);
            Produto p3 = new Produto(3,"Iphone",1900f);


            // Adicionando os produtos ao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);

            // Mostrar produtos do carrinho
            carrinho.MostrarProdutos();
        }
    }
}
