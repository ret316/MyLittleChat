using MyLittleChatDL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyLittleChatDL.Service.Implementation
{
    public class UserRepositoryDL : IUserRepositoryDL
    {
        public async Task CreateUser(UserDL userDL)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                await db.Users.AddAsync(userDL);
                await db.SaveChangesAsync();
            }
        }

        public async Task<UserDL> GetUser(string login)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var userDto = db.Users.Where(user => user.login == login).FirstOrDefaultAsync();
                //return new UserDL
                //{
                //    id = userDto.id,
                //    login = userDto.login,
                //    password = userDto.password,
                //    name = userDto.name
                //};
                return await userDto;
            }
        }
    }
}
