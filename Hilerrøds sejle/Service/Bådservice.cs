using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;
namespace Hilerrøds_sejle.Service
{
    public class Bådeservice : IBådservice
    {
        private static List<Båd> _både = new List<Båd>()
        {
            new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
            new Båd("Sejlbåd", "Q35","3115",8,3,"2003","The Quruce"),
            new Båd("Skoda", "60","3112",4,1,"2022","Enyaq")
        };
        private static int _nextId = 3;

        public List<Båd> GetAll()
        {
            return _både.ToList();
        }

        // Hent alle både
        public Båd? GetById(int id)
        {
            return _både.FirstOrDefault(b => b.Id == id);
        }

        // Tilføj en ny båd 
        public void Add(Båd båd)
        {
            båd.Id = _nextId++;
            _både.Add(båd);
        }

        public void Update(Båd båd)
        {
            var existing = _både.FirstOrDefault(b => b.Id == båd.Id);
            if (existing != null)
            {
                existing.BådNavn = båd.BådNavn;
                existing.SejlNummer = båd.SejlNummer;
                existing.BådHøjde = båd.BådHøjde;
                existing.BådLængde = båd.BådLængde;
                existing.ByggeÅr = båd.ByggeÅr;
                existing.BådType = båd.BådType;
                existing.Model = båd.Model;
            }
        }
        public void DeleteById(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _både.Remove(existing);
        }

        //public void Add(Båd båd)
        //{
        //    _både.Add(båd);
        //}

    }
}
