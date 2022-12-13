﻿using AppartmentsApp.Models;

namespace AppartmentsApp.Repository;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    bool Add(Category category);
    bool Update(Category category);
    bool Delete(Category category);
    bool Save();
}