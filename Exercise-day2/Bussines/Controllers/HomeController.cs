﻿using Bussines.Models;
using DataAccess_bs.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bussines.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.member);
    }
   
}