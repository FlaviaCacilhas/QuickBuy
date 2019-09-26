using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Repositories
{
    class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public void Adicionar(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Product ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
