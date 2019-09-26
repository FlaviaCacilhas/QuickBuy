using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Product : Entities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AdicionarCritica("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Description))
                AdicionarCritica("Descrição não foi informado");
        }
    }
}
