using System;
using System.Collections.Generic;

namespace ERPSystem.Models
{
    public class Pedido
    {
        public int Id { get; set; }                   // Chave primária
        public DateTime DataPedido { get; set; }      // Data do pedido
        public int ClienteId { get; set; }            // Chave estrangeira para Cliente
        public Cliente Cliente { get; set; }          // Navegação para o Cliente
        public ICollection<Produto> Produtos { get; set; } // Produtos no pedido
    }
}
