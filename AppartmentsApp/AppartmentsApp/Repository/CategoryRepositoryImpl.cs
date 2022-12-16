using AppartmentsApp.Data;
using AppartmentsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AppartmentsApp.Repository;

public class CategoryRepositoryImpl:ICategoryRepository
{

    private readonly ApplicationDbContext _context;

    public CategoryRepositoryImpl(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Category>> GetAll()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetById(int id)
    {
        return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
    }

    public bool Add(Category category)
    {
        throw new NotImplementedException();
    }

    public bool Update(Category category)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Category category)
    {
        _context.Categories.Remove(category);
        return Save();
    }
    
    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}