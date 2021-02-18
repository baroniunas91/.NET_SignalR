using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRHomework.Hubs
{
    public class DrawingHub : Hub
    {
        public async Task SendCoord(int x, int y)
        {
            await Clients.Others.SendAsync("receiveCoord", x, y);
        }
    }
}
