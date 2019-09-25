using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities.Enum;

namespace QuickBuy.Domain.Entities.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }


        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamento.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito; }
        }

        public bool EhNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamento.NaoDefinido; }
        }
    }
}
