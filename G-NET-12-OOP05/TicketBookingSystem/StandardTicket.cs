namespace G_NET_12_OOP05.TicketBookingSystem
{
    internal class StandardTicket : Ticket
    {
        public SeatLocation Seat { get; set; }

        public StandardTicket(string movieName, decimal price, SeatLocation seat) : base(movieName, price)
        {
            Seat = seat;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Seat: {Seat}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Seat: {Seat}";
        }
    }
}
