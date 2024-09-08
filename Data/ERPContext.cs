using Microsoft.EntityFrameworkCore;
using ERPSystem.Models;

namespace ERPSystem.Data
{
    public class ERPContext : DbContext
    {
        public ERPContext(DbContextOptions<ERPContext> options) : base(options) { }

        // Definição das tabelas do banco de dados
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
