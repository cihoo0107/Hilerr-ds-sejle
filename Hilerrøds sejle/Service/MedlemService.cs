using System.Collections.Generic;
using System.Linq;
using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Service
{
    public class MedlemService : IMedlemService
    {
        private static readonly List<Medlem> _medlemmer = new List<Medlem>
        {
        new Medlem("Niels", "Niels@mail.com",1,Medlemsrolle.Formand,"10203040","Købmandsgade 12"),
        new Medlem("Peter","Peterersej@mail.com",3,Medlemsrolle.Medlem,"40302010","Smedegade 37"),
        new Medlem("Maja","Maja@mail.com",2,Medlemsrolle.Medlem,"30405060","Jernbanevej 15" )

        };
        private static int _nextId = 4; // næste medlem for tildelt id 4, fordi Niels = 1, Peter = 3 og Maja = 2

        public List<Medlem> GetAll()
        {
            return _medlemmer.ToList();
        }

        public Medlem? GetById(int id)

        {
            return _medlemmer.FirstOrDefault(m => m.Id == id);
        }

        public void Add(Medlem medlem)
        {
            medlem.Id = _nextId++;
            _medlemmer.Add(medlem); 
        }

        public void Update(Medlem medlem)

        {
            var existing = GetById(medlem.Id); 
            if (existing == null) return;

            existing.Navn = medlem.Navn;
            existing.Email = medlem.Email;
            existing.Rolle = medlem.Rolle;
            existing.Adresse = medlem.Adresse;
            existing.Telefonnummer = medlem.Telefonnummer;
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _medlemmer.Remove(existing);
        }
    }
        }