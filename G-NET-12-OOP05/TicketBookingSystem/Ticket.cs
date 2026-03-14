namespace G_NET_12_OOP05.TicketBookingSystem
{
    internal class Ticket
    {
        private static int _totalTickets = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }
        public decimal PriceAfterTax => Price * 1.14m;

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
                return ;
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

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP";
        }
    }
}
