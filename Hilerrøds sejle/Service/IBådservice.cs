using System.Collections.Generic;
using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Service
{
    public interface IBådservice
    {
        List<Båd> GetAll();
        Båd? GetById(int id);
        void Add(Båd båd);
        void Update(Båd båd);
        void Delete(int id);
       
    }
       
}
