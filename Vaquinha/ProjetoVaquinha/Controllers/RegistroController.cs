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

    [HttpPost]
    public IActionResult Adicionar(Registro registro)
    {
        RepositorioRegistrar.AdicionarUsuario(registro);
        return RedirectToAction("Registro");
    }

    [HttpPost]
    public IActionResult AdicionarUsu(Registro registro)
    {
        RepositorioRegistrar.AdicionarUsuario(registro);
        return RedirectToAction("Inicio", "Home");
    }

    [HttpPost]
    public IActionResult Logar(Registro registro)
    {
        RepositorioRegistrar.AdicionarUsuario(registro);
        return RedirectToAction("Inicio", "Home");
    }
}