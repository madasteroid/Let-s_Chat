﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Lets_Chat.Hubs
{
    public class Chathub: Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
