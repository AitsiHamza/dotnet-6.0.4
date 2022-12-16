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
    public async Task<IActionResult> Delete(int id)
    {
        var category = await _categoryRepository.GetById(id);
        if(category == null) return View("Error");
        return View(category);
    }
    
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteById(int id)
    {
        Category category = await _categoryRepository.GetById(id);
        if(category == null) return View("Error");
        Boolean b=_categoryRepository.Delete(category);
        Console.WriteLine(b);
        return RedirectToAction("CategoriesIndex");
    }
}