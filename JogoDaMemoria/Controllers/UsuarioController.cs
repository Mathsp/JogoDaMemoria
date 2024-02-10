using Microsoft.AspNetCore.Mvc;

namespace JogoDaMemoria.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public bool AutenticaUsuario(string userName, string Senha)
        {
            return true;
        }

        [HttpPost]
        public void CadastroUsuario(string email, string userName, string nome, string senha, DateTime dataNascimento)
        {
            
        }
    }
}
