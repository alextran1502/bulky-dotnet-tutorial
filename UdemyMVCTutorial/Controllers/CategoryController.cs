using Microsoft.AspNetCore.Mvc;
using UdemyMVCTutorial.Data;
using UdemyMVCTutorial.Models;

namespace UdemyMVCTutorial.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        List<Category> objCategoryList = _db.Categories.ToList();
        return View(objCategoryList);
    }
}