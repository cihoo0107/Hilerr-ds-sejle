namespace Hilerrøds_sejle.Model
{
    public class Events
    {
        public string Navn { get; set; }
        public DateTime Tidspunkt { get; }


        public Events(string navn, DateTime tidspunkt)

        {
            Navn = navn;
            Tidspunkt = tidspunkt;

        }
    }
}
