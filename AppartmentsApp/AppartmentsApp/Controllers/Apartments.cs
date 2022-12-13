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
}