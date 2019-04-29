namespace CQRSL1.Domain
{
    public interface IMessage { }
    public interface IEvent { }

    public interface IStartsWithMessage<T> where T : IMessage
    {
        void Start(T command);
    }

    public interface ICanHandleMessage<T> where T : IMessage
    {
        void Handle(T command);
    }

    public interface ICanHandleEvent<T> where T : IEvent
    {
        void Handle(T theEvent);
    }
}
