namespace G_NET_12_OOP05.TicketBookingSystem
{
    public class StandardTicket : Ticket
    {
        public SeatLocation Seat { get; set; }

        public StandardTicket(string movieName, decimal price, SeatLocation seat) : base(movieName, price) => Seat = seat;

        public override void PrintTicket()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
