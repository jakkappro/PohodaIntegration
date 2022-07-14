namespace PohodaIntegration.Pohoda
{
    public interface IServerStarter
    {
        void StartServer();

        Task<bool> IsConnectionAvailable();

        void StopServer();
    }
}
