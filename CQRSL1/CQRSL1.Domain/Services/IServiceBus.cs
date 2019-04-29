namespace CQRSL1.Domain
{
    public interface IServiceBus
    {
        void StartProcess<T>(T command) where T : IMessage;
        void SendCommand<T>(T command) where T : IMessage;
        void RaiseEvent<T>(T theEvent) where T : IEvent;
    }
}
