namespace ERPSystem.Models
{
    public class Produto
    {
        public int Id { get; set; }                   // Chave primária
        public string Nome { get; set; }              // Nome do produto
        public string Descricao { get; set; }         // Descrição do produto
        public decimal Preco { get; set; }            // Preço do produto
        public int QuantidadeEmEstoque { get; set; }  // Quantidade em estoque
    }
}
