﻿using JogoDaMemoria.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JogoDaMemoria.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AutenticaUsuario(string userName, string senha)
        {
            try
            {
                _usuarioRepository.ValidaUsuario(userName, senha);
                return View();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public void CadastroUsuario(string email, string userName, string nome, string senha, DateTime dataNascimento)
        {
            _usuarioRepository.CadastrarUsuario(email, userName, nome, senha, dataNascimento);
        }
    }
}
