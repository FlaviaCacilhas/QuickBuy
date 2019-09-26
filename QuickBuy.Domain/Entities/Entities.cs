using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entities
    {
        public List<string> _mensagensValidacao { get; set; }
        protected List<string> MensagenValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao()
        {
            MensagenValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagenValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagenValidacao.Any(); }
        }


    }
}
