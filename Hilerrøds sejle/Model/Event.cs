namespace Hilerrøds_sejle.Model
{
    public class Event
    {
        public string Id { get; set; }
        public string Navn { get; set; }
        public DateTime Tidspunkt { get; set; }
      
       

        public Event() 
        {
            Id = Guid.NewGuid().ToString();
        }

        public Event(string navn, DateTime tidspunkt)

        {
            Id = Guid.NewGuid().ToString();
            Navn = navn;
            Tidspunkt = tidspunkt;
            

        }
    }
}
