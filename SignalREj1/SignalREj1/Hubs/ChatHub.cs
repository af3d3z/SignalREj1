using Microsoft.AspNetCore.SignalR;
using Models;

namespace SignalREj1.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MensajeUsuario msg) {
            await Clients.All.SendAsync("ReceiveMessage", msg);
        }
    }
}
