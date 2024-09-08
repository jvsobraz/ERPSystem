namespace ERPSystem.Models
{
    public class Produto
    {
        public int Id { get; set; }                   // Chave prim�ria
        public string Nome { get; set; }              // Nome do produto
        public string Descricao { get; set; }         // Descri��o do produto
        public decimal Preco { get; set; }            // Pre�o do produto
        public int QuantidadeEmEstoque { get; set; }  // Quantidade em estoque
    }
}
