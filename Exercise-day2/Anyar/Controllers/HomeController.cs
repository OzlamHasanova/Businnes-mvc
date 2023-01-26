using DataAcces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anyar.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _appDbContext;

    public HomeController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task <IActionResult> Index()
    {
        var items = await _appDbContext.teamItems.ToListAsync();
        return View(items);
    }
}
