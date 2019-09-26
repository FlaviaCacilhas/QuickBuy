using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Domain.Contracts
{
    public interface IUserRepository : BaseRepository<User>
    {
        User Obter(string email, string senha);
        User Obter(string email);
    }
}
