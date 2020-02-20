using MyLittleChatDL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MyLittleChatDL.Service.Implementation
{
    public class UserRepositoryDL : BaseRepository, IUserRepositoryDL 
    {
        public UserRepositoryDL(IOptions<Settings> options) : base(options)
        {

        }

        public async Task CreateUser(UserDL userDL)
        {
            using (ApplicationContext db = GetApplicationContext())
            {
                await db.Users.AddAsync(userDL);
                await db.SaveChangesAsync();
            }
        }

        public async Task<UserDL> GetUser(string login)
        {
            using (ApplicationContext db = GetApplicationContext())
            {
                var userDto = db.Users.Where(user => user.login == login).FirstOrDefaultAsync();
                return await userDto;
            }
        }
    }
}
