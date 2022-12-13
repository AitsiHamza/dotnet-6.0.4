using AppartmentsApp.Data;
using AppartmentsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AppartmentsApp.Repository;

public class ApartmentRepositoryImpl:IApartmentRepository
{

    private readonly ApplicationDbContext _context;

    public ApartmentRepositoryImpl(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Apartment>> GetAll()
    {
        return await _context.Apartments.Include(i => i.Category).ToListAsync();
    }

    public bool Add(Apartment apartment)
    {
        throw new NotImplementedException();
    }

    public bool Update(Apartment apartment)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Apartment apartment)
    {
        throw new NotImplementedException();
    }

    public bool Save()
    {
        throw new NotImplementedException();
    }
}