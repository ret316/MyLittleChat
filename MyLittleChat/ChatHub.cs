using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleChat
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName)
        {
            await Clients.All.SendAsync("Send", message, userName);
        }


        public async Task Login(string userName, string password)
        {
            
        }

        public async Task Register(string userName, string password)
        {
            
        }

    }
}
