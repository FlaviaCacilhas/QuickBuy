using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Name { get; set; }
        public string SobreNome { get; set; }

        // Um usuario pode ter nem um ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
