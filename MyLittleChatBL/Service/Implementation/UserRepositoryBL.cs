using MyLittleChatBL.Model;
using MyLittleChatDL.Model;
using MyLittleChatDL.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleChatBL.Service.Implementation
{
    public class UserRepositoryBL : IUserRepositoryBL
    {
        private readonly IUserRepositoryDL userRepositoryDL;

        public UserRepositoryBL(IUserRepositoryDL userRepositoryDL)
        {
            this.userRepositoryDL = userRepositoryDL;
        }

        public async Task CreateUser(UserBL userBL)
        {
            await this.userRepositoryDL.CreateUser
                (new UserDL 
                { 
                    Id = userBL.Id,
                    Login = userBL.Login,
                    Password = userBL.Password,
                    Name = userBL.Name
                });
        }

        public async Task<UserBL> GetUser(string login)
        {
            var userDto = await this.userRepositoryDL.GetUser(login);

            return new UserBL
            {
                Id = userDto.Id,
                Login = userDto.Login,
                Password = userDto.Password,
                Name = userDto.Name
            };
        }
    }
}
