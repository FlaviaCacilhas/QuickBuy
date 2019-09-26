using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Repositories
{
    class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public void Adicionar(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Pedido ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
