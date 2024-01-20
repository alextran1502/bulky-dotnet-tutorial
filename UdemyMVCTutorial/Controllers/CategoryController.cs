using Microsoft.AspNetCore.Mvc;

namespace UdemyMVCTutorial.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}