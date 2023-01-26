using DataAcces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anyar.Areas.Admin.Controllers;


[Area("Admin")]
public class DashBoardController : Controller
{
    private readonly AppDbContext _context;

    public DashBoardController(AppDbContext context)
    {
        _context = context;
    }

    public async Task < IActionResult> Index()
    {
        var members = await _context.teamItems.ToListAsync();
        return View(members);
    }
}
