using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Service
{
    public interface IBookingService
    {
        List<Booking> GetAll();
        void Add(Booking booking);
        void Delete(string id);
        Booking? GetById(string id);
    }
}
