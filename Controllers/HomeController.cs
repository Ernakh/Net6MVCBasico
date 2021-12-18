using Microsoft.AspNetCore.Mvc;
using Net6MVCBasico.Models;

namespace Net6MVCBasico.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        //public IActionResult Pessoa()
        //{
        //    Pessoa p = new Pessoa();
        //    p.Nome = "Fabrício Tonetto Londero";
        //    return View(p);
        //}

        public IActionResult Pessoa(Pessoa p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa p)
        {
            string nome = p.Nome;

            return View("Pessoa", p);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
