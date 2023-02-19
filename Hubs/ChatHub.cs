using Microsoft.AspNetCore.SignalR;

namespace SignallingServer.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IHubContext<ChatHub> _context;

        public ChatHub(IHubContext<ChatHub> context)
        {
            _context = context;
        }

        public async Task NewMessage(string username, string message)
        {
            await _context.Clients.All.SendAsync("messageReceived", username, message);
            Console.WriteLine("Sent");
        }
    }
}
