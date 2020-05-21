namespace Actio.Common.Events
{
    // this class is for when there is async error in registration or login
    public interface IRejectedEvent : IEvent
    {
        string Reason { get; }
        string Code { get; }
    }
}