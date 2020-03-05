using MyLittleChat.Model;
using MyLittleChatBL.Model;
using MyLittleChatBL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleChat.Service.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserRepositoryBL userRepositoryBL;
        public UserRepository(IUserRepositoryBL userRepositoryBL)
        {
            this.userRepositoryBL = userRepositoryBL;
        }

        public async Task CreateUser(User user)
        {
            await this.userRepositoryBL.CreateUser(new UserBL 
            { 
                Id = user.Id, 
                Login = user.Login, 
                Name = user.Name, 
                Password = user.Password
            });
        }

        public async Task<User> GetUser(string login)
        {
            var userDto = await this.userRepositoryBL.GetUser(login);

            return new User
            {
                Id = userDto.Id,
                Login = userDto.Login,
                Password = userDto.Password,
                Name = userDto.Name
            };
        }
    }
}
