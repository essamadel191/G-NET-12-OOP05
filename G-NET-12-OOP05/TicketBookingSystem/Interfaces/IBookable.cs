namespace G_NET_12_OOP05.TicketBookingSystem.Interfaces
{
    public interface IBookable
    {
        bool IsBooked { get; }
        void Book();
        void Cancel();
    }
}
