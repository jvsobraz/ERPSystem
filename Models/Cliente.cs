namespace ERPSystem.Models
{
    public class Cliente
    {
        public int Id { get; set; }                   // Chave prim�ria
        public string Nome { get; set; }              // Nome do cliente
        public string Email { get; set; }             // Email do cliente
        public string Telefone { get; set; }          // Telefone do cliente
    }
}
