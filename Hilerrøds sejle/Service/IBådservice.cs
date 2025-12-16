using System.Collections.Generic;
using Hilerrøds_sejle.Service;
using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Service
{
    public interface IBådservice
    {
        List<Båd> GetAll();
        Båd? GetById(int id);
        void Add(Båd båd);
        void DeleteById(int id);
        void Update(Båd båd);
        
       
    }
       
}
