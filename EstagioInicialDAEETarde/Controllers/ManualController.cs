using EstagioInicialDAEETarde.Data;
using EstagioInicialDAEETarde.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebMvcMysql.Controllers
{
    public class ManualController : Controller
    {
        private readonly Contexto _Contexto;
        public ManualController(Contexto contexto)
        {
            _Contexto = contexto;
        }

        public IActionResult GitFlow()
        {
            IEnumerable<Git> conteudoGit = _Contexto.Git;
            return View(conteudoGit);
        }

        public IActionResult EntityFramework()
        {
            return View();
        }

        public IActionResult GitIntegrado()
        {
            return View();
        }

        public IActionResult Jquery()
        {
            IEnumerable<Jquery> conteudoJquery = _Contexto.Jquery;
            return View(conteudoJquery);
        }

        public IActionResult Git()
        {
            return View();
        }

        public IActionResult AspNet()
        {
            return View();
        }

        public IActionResult MVC()
        {   IEnumerable<Mvc> conteudoMvc = _Contexto.Mvc;
            return View(conteudoMvc);
        }

        public IActionResult Scrum()
        {
            IEnumerable<Scrum> conteudoScrum = _Contexto.Scrum;
            return View(conteudoScrum);
        }
    }
}
