using AppartmentsApp.Models;

namespace AppartmentsApp.Repository;

public interface IApartmentRepository
{
    Task<IEnumerable<Apartment>> GetAll();
    Task<Apartment> GetById(int id);
    bool Add(Apartment apartment);
    bool Update(Apartment apartment);
    bool Delete(Apartment apartment);
    bool Save();
}