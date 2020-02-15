using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyLittleChatDL.Model;

namespace MyLittleChatDL.Service
{
    public interface IUserRepositoryDL
    {
        Task<UserDL> GetUser(string login);
        Task CreateUser(UserDL userDL);
    }
}
