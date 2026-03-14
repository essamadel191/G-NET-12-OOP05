namespace G_NET_12_OOP05.TicketBookingSystem
{
    public class VIPTicket : Ticket, ICloneable
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;

        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess);
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
