namespace G_NET_12_OOP05.TicketBookingSystem
{
    internal class Cinema
    {
        public string CinemaName { get; }
        private Projector _projector = new Projector();
        private Ticket[] _tickets = new Ticket[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            _projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("========== Cinema Closed ==========");
            _projector.Stop();
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("========== All Tickets ==========");
            foreach (Ticket ticket in _tickets)
            {
                if (ticket != null)
                    ticket.PrintTicket();
            }
        }

        public static void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
        }
    }
}
