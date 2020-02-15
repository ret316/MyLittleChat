using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyLittleChatBL.Model;
using MyLittleChatDL.Service;

namespace MyLittleChatBL.Service
{
    public interface IUserRepositoryBL
    {
        Task<UserBL> GetUser(string login);
        Task CreateUser(UserBL userBL);
    }
}
