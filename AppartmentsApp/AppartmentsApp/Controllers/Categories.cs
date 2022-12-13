using AppartmentsApp.Models;
using AppartmentsApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AppartmentsApp.Controllers;

public class Categories : Controller
{
    private ICategoryRepository _categoryRepository;

    public Categories(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [HttpGet]
    public async Task<IActionResult> CategoriesIndex()
    {
        IEnumerable<Category> categories = await _categoryRepository.GetAll();
        return View(categories);
    }
}