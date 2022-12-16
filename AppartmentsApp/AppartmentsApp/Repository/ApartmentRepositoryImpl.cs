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

    public async Task<Apartment> GetById(int id)
    {
        return await _context.Apartments.FirstOrDefaultAsync(a => a.Id == id);
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
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}