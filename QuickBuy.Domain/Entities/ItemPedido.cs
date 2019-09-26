using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class ItemPedido :Entities
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            if (ProductId == 0)
            {
                AdicionarCritica("Não foi identificado qual a referência do produto");
            }

            if (Quantity == 0)
            {
                AdicionarCritica("Quantidade não informada");
            }
        }
    }
}
