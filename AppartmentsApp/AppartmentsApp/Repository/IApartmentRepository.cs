using AppartmentsApp.Models;

namespace AppartmentsApp.Repository;

public interface IApartmentRepository
{
    Task<IEnumerable<Apartment>> GetAll();
    bool Add(Apartment apartment);
    bool Update(Apartment apartment);
    bool Delete(Apartment apartment);
    bool Save();
}