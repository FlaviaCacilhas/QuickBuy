using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Repositories
{
    public class Client
    {
        public Client()
        {
            var userRepository = new UserRepository();
            var product = new Product();
            var user = new User();

            userRepository.Adicionar(user);
        }
    }
}
