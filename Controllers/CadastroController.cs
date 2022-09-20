using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CalculadoraAspNetMvc.Models;

namespace CalculadoraAspNetMvc.Controllers;

public class CadastroController : Controller
{
    private readonly ILogger<CadastroController> _logger;

    public CadastroController(ILogger<CadastroController> logger)
    {
        _logger = logger;
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public IActionResult CadastrarUsuario([FromForm] string nome, [FromForm] string email, [FromForm] string senha)
    {
        var user = new UserModel(nome, email, senha);
        return Content("Novo usuário cadastrado.");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}