using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Service;

public class EventService : IEventService
{
    private List<Event> _Event = new List<Event>()
    {
          new Event("Sommerfest", new DateTime (2025, 5, 20, 17, 0, 0)), // Kl. 17:00
            new Event("Vinterfest", new DateTime (2026, 12, 17, 20, 0, 0)) // Kl. 20:00
    };

    public List<Event> GetAll()
    {
        return _Event;
    }
}