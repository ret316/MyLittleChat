using MyLittleChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleChat.Service
{
    public interface IUserRepository
    {
        Task<User> GetUser(string login);
        Task CreateUser(User user);
    }
}
