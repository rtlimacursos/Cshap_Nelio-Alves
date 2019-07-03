using System.Globalization;
namespace Aula042
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        
        public Produto()
        {
            _quantidade = 0;
        }
        public Produto (string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade):this(nome,preco)
        {
            _quantidade = quantidade;
        }
        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }
            public double ValorTotalEmEstoque()
        {
            return _quantidade *_preco;

        }
        public void  AdicionaProdutos(int quantidade) { 
            _quantidade += quantidade;

        }
        public void RemoveProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                +", $"
                +_preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                +_quantidade
                +" unidades. Total: $"
                +ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
