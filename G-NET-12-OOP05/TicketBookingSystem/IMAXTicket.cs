namespace G_NET_12_OOP05.TicketBookingSystem
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
