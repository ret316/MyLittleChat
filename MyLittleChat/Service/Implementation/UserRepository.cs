using MyLittleChat.Model;
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

        public async Task<User> GetUser()
        {
            var userDto = await this.userRepositoryBL.GetUser();

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
