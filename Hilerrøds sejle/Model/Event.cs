namespace Hilerrøds_sejle.Model
{
    public class Event
    {
        public string Navn { get; set; }
        public DateTime Tidspunkt { get; }

        public Event() 
        { 
        }
        public Event(string navn, DateTime tidspunkt)

        {
            Navn = navn;
            Tidspunkt = tidspunkt;
        }
    }
}
