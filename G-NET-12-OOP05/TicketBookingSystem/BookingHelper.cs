using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05.TicketBookingSystem
{
    internal static class BookingHelper
    {

        private static int BookingCounter = 0;

        public static double CalcGroupDiscount(int numberOfTickets , double pricePerTicket) 
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

    }
}
