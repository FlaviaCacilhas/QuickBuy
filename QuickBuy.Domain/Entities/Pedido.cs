using System;
using System.Collections.Generic;
using System.Text;


namespace QuickBuy.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DatePedido { get; set; }
        public int UserId { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; }

    }
}
