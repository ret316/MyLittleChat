using Microsoft.AspNetCore.SignalR;
using MyLittleChat.Model;
using MyLittleChat.Service;
using MyLittleChat.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleChat
{
    public class ChatHub : Hub
    {
        private Dictionary<string, User> connectedUsers { get; set; } = new Dictionary<string, User>();
        private IUserRepository userRepository { get; set; }
        public ChatHub(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task Send(string message, string userName)
        {
            if (connectedUsers.ContainsKey(Context.ConnectionId))
            {
                await Clients.All.SendAsync("Send", message, userName);
            }
            
        }


        public async Task Login(string userName, string password)
        {
            try
            {
                User user = new User();
                user = await userRepository.GetUser(userName);
                if (user.Login != null)
                {
                    connectedUsers[Context.ConnectionId] = user;
                    await Groups.AddToGroupAsync(Context.ConnectionId, "ChatHub");
                    //await Clients.Caller.SendAsync("SetUserName", user.Name.ToString());
                }
                else
                    await Clients.Caller.SendAsync("UserNotFound");
            }
            catch (Exception ex)
            {

            }


        }

        public async Task Register(string login, string password, string name)
        {
            User user = new User();
            user.Login = login;
            user.Name = name;
            user.Password = new MD5Hash().GetGuid(password);
            try
            {
                await userRepository.CreateUser(user);
                await Clients.Caller.SendAsync("Registered", login, name);
            }
            catch (Exception)
            {
                await Clients.Caller.SendAsync("LoginIsDefined");
            }
                
        }

    }
}
