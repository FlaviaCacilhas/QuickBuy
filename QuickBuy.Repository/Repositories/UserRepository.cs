using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Repositories
{
    class UserRepository : BaseRepository<User>, IUserRepository
    {
        public void Adicionar(User entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(User entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User Obter(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public User Obter(string email)
        {
            throw new NotImplementedException();
        }

        public User ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
