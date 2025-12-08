using System.Collections.Generic;
using Hilerrøds_sejle.Model;


namespace Hilerrøds_sejle.Service;


public interface IMedlemRepository
{
    List<Medlem> GetAll();
    Medlem? GetById(int id);
    void Add(Medlem medlem);
    void Update(Medlem medlem);
    void Delete(int id);
}

