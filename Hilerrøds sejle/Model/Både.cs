namespace Hilerrøds_sejle.Model
{
    public class Båd
    {
        public string BådType { get; }
        public int Id { get; set; }
        public string Model { get; }
        public string SejlNummer { get; }
        public int BådLængde { get; }
        public int BådHøjde { get; }
        public string ByggeÅr { get; }
        public string BådNavn { get; }

        public Båd(string bådtype, string model, string sejlNummer, int bådLængde, int bådHøjde, string byggeÅr, string bådnavn)
        {
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
