using AppartmentsApp.Models;
using AppartmentsApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AppartmentsApp.Controllers;

public class Apartments : Controller
{
    private IApartmentRepository _apartmentRepository;

    public Apartments(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }

    [HttpGet]
    public async Task<IActionResult> ApartmentsIndex()
    {
        IEnumerable<Apartment> apartments = await _apartmentRepository.GetAll();
        return View(apartments);
    }
    
    [HttpDelete, ActionName("Delete")]
    public async Task<IActionResult> DeleteById(int id)
    {
        Apartment apartment = await _apartmentRepository.GetById(id);
        if(apartment == null) return View("Error");
        _apartmentRepository.Delete(apartment);
        return RedirectToAction("ApartmentsIndex");
    }
}