namespace MetodosConstrutores.Classes
{
    public class Produto
    {

        public Produto()  {

        }

        public Produto(int codigoProduto, string nomeProtudo, string descricaoProtudo, int estoqueProduto) {
            this.Codigo = codigoProduto;
            this.Nome = nomeProtudo;
            this.Descricao = descricaoProtudo;
            this.Estoque = estoqueProduto;
        }
        public int Codigo {get; set;}

        public string Nome { get; set; }
        
        public string Descricao { get; set; }

        public int Estoque { get; set; }
        
    }
}