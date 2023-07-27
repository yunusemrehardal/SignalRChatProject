using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChatProject.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", username, message);
        }
    }
}
