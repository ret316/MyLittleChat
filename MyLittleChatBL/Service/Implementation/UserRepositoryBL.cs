using MyLittleChatBL.Model;
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

        public async Task<UserBL> GetUser()
        {
            var userDto = await this.userRepositoryDL.GetUser();

            return new UserBL
            {
                id = userDto.id,
                login = userDto.login,
                password = userDto.password,
                name = userDto.name
            };
        }
    }
}
