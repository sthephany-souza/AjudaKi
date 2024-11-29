using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoVaquinha.Models;

namespace ProjetoVaquinha.Controllers;

public class RegistroController : Controller{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Registro()
    {
        return View();
    }
}