using G_NET_12_OOP05.TicketBookingSystem.Interfaces;

namespace G_NET_12_OOP05.TicketBookingSystem
{
    internal static class BookingHelper
    {
        private static int BookingCounter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if (numberOfTickets >= 5)
            {
                double totalPrice = numberOfTickets * pricePerTicket;
                return totalPrice * 0.9; // 10% discount
            }
            return numberOfTickets * pricePerTicket;
        }

        public static string GenerateBookingReference()
        {
            BookingCounter++;
            return $"BK-{BookingCounter}";
        }

        public static void PrintAll(IPrinting[] printables)
        {
            Console.WriteLine("--- BookingHelper.PrintAll ---");
            foreach (IPrinting printable in printables)
            {
                printable.PrintTicket();
            }
        }
    }
}
