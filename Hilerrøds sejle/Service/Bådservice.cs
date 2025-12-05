using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;
namespace Hilerrøds_sejle.Service
{
    public class Bådeservice : IBådservice
    {
        private List<Båd> _både = new List<Båd>()
        {
            new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
            new Båd("Sejlbåd", "Q35","3115",8,3,"2003","The Quruce"),
            new Båd("Skoda", "60","3112",4,1,"2022","Enyaq")
        };

        public List<Båd> GetAll()
        {
            return _både;
        }


        //public void Add(Båd båd)
        //{
        //    _både.Add(båd);
        //}

    }
}
