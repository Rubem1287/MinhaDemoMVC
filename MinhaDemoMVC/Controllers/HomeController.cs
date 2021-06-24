using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Controllers
{
    //[Route("")]
    //[Route("gestao-clientes")]
    public class HomeController : Controller
    {
        //[Route("")]
        //[Route("pagina-inicial")]
        //[Route("pagina-inicial/{id:int}/{categoria:guid}")]
        //(int id, Guid categoria)
        public IActionResult Index()
        {
            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };
            return RedirectToAction("Privacy", filme);
            //return View();
        }
        //[Route("sobre")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        //[Route("contato")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //[Route("privacidade")]
        //[Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if(ModelState.IsValid)
            {

            }

            foreach(var error in ModelState.Values.SelectMany(x=>x.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            //return Json("{'nome':'Eduardo'}");
            return Content("Qualquer Coisa");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //[Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
