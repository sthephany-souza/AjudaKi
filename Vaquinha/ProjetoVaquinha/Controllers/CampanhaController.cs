using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoVaquinha.Models;

namespace ProjetoVaquinha.Controllers;

public class CampanhaController : Controller{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CampanhaProd()
    {
        return View();
    }

    public IActionResult Campanha()
    {
        return View();
    }

    public IActionResult CampanhaDin()
    {
        return View();
    }
}