namespace SignallingServer.Interfaces
{
    public interface IHubContext
    {
        Task ReceiveMessage(string message);
    }
}
