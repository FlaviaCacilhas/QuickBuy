using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickBuy.Domain.Entities.ObjetoDeValor;


namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entities
    {
        public int Id { get; set; }
        public DateTime DatePedido { get; set; }
        public int UserId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecpCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        //Deve haver pelo menos um item de pedido ou muitos
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (ItensPedidos.Any())
            {
                AdicionarCritica("Crítica - Pedido não pode ficar sem Item");
            }
                
                

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("O CEP deve ser informado");
            }
        }
    }
}
