using G_NET_12_OOP05.TicketBookingSystem.Interfaces;

namespace G_NET_12_OOP05.TicketBookingSystem
{
    public class Ticket : IPrinting, IBookable
    {
        private static int _totalTickets = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }
        public decimal PriceAfterTax => Price * 1.14m;
        public bool IsBooked { get; private set; }

        public Ticket(string movieName, decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Price must be greater than 0.");
                return;
            }

            _totalTickets++;
            TicketId = _totalTickets;
            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets() => _totalTickets;

        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Price must be greater than 0.");
                return;
            }
            Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            if (basePrice <= 0 || multiplier <= 0)
            {
                Console.WriteLine("Base price and multiplier must be greater than 0.");
                return;
            }
            Price = basePrice * multiplier;
        }

        public void Book()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Ticket #{TicketId} is already booked.");
                return;
            }
            IsBooked = true;
        }

        public void Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine($"Ticket #{TicketId} is not booked.");
                return;
            }
            IsBooked = false;
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | Price: {Price} | After Tax: {PriceAfterTax:0.##} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
