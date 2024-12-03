using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoVaquinha.Models;

namespace ProjetoVaquinha.Controllers;

public class DoacaoController : Controller{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult InfoProdutos()
    {
        return View();
    }
    
    public IActionResult Pagamento()
    {
        return View();
    }
}