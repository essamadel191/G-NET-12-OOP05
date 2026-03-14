namespace G_NET_12_OOP05.TicketBookingSystem
{
    public struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public SeatLocation(char row , int? number)
        {
            Row = row;
            Number = number ?? 1;
        }
        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
}
