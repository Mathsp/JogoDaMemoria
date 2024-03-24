using JogoDaMemoria.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JogoDaMemoria.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroController(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
