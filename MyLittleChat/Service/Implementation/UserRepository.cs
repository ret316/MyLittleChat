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
                id = user.id, 
                login = user.login, 
                name = user.name, 
                password = new MD5Hash().GetHash(user.password) 
            });
        }

        public async Task<User> GetUser(string login)
        {
            var userDto = await this.userRepositoryBL.GetUser(login);

            return new User
            {
                id = userDto.id,
                login = userDto.login,
                password = userDto.password,
                name = userDto.name
            };
        }
    }
}
