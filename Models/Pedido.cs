using System;
using System.Collections.Generic;

namespace ERPSystem.Models
{
    public class Pedido
    {
        public int Id { get; set; }                   // Chave prim�ria
        public DateTime DataPedido { get; set; }      // Data do pedido
        public int ClienteId { get; set; }            // Chave estrangeira para Cliente
        public Cliente Cliente { get; set; }          // Navega��o para o Cliente
        public ICollection<Produto> Produtos { get; set; } // Produtos no pedido
    }
}
