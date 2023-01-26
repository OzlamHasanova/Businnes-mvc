using Core_bs.Entities;
using DataAccess_bs.Context;
using Microsoft.AspNetCore.Mvc;

namespace Bussines.Areas.Admin.Controllers;
[Area("Admin")]

public class TeamController : Controller
{
    private readonly AppDbContext _context;

    public TeamController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.member);
    }
    public async Task<IActionResult> Detail(int? id)
    {
        var member = await _context.member.FindAsync(id);
        if (member == null) return BadRequest();
        return View(member);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TeamMember person)
    {
        if(!ModelState.IsValid)return View(person); 
        await _context.member.AddAsync(person);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
    public async Task<IActionResult> Update(int? id)
    {
        var memberdb = await _context.member.FindAsync(id);
        if (memberdb == null) return BadRequest();
        return View(memberdb);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(int? id,TeamMember person)
    {
        if(!ModelState.IsValid)return View(person);
        var memberdb = await _context.member.FindAsync(id);
        if(memberdb == null) return BadRequest();
        memberdb.Image=person.Image;
        memberdb.Name=person.Name;
        memberdb.Position=person.Position;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> DeleteAsync(int id)
    {
        var member = await _context.member.FindAsync(id);
        if (member == null) return BadRequest();
        return View(member);
        
    }
    [HttpPost]
    [ValidateAntiForgeryToken]  
    [ActionName("Delete")]
    public async Task<IActionResult> DeletePost(int id)
    {
        var member = await _context.member.FindAsync(id);
        if (member == null) return BadRequest();
        _context.member.Remove(member);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

}
