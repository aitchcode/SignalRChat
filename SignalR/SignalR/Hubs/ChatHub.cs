using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string username, string message)
        {
            Clients.All.addMessage(username, message);
        }
    }
}