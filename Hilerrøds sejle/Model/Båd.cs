namespace Hilerrøds_sejle.Model
{
    public class Båd
    {
        public string BådType { get; set; }
        public int Id { get; set; }
        public string Model { get; set; }
        public string SejlNummer { get; set; }
        public int BådLængde { get; set; }
        public int BådHøjde { get; set; }
        public string ByggeÅr { get; set; }
        public string BådNavn { get; set; }

        private static int _nextId = 1;

        public Båd() { }

        public Båd(string bådtype, string model, string sejlNummer, int bådLængde, int bådHøjde, string byggeÅr, string bådnavn)
        {
            Id = _nextId++;
            BådType = bådtype;
            Model = model;
            SejlNummer = sejlNummer;
            BådLængde = bådLængde;
            BådHøjde = bådHøjde;
            ByggeÅr = byggeÅr;
            BådNavn = bådnavn;
        }
    }


   
}
