using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PPA.Models;
using AppContext = PPA.Data.AppContext;

namespace PPA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppContext _context;

        public HomeController(ILogger<HomeController> logger, AppContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult PV_Eixo1()
        {
            return PartialView();
        }
        public ActionResult PV_Eixo2()
        {
            return PartialView();
        }
        public ActionResult PV_Eixo3()
        {
            return PartialView();
        }
        public ActionResult PV_Eixo4()
        {
            return PartialView();
        }
        public ActionResult PV_Nada()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult DefinirEixo(string eixo)
        {
            
            switch (eixo)
            {
                case "1":
                    return PartialView(nameof(PV_Eixo1));
                case "2":
                    return PartialView(nameof(PV_Eixo2));
                case "3":
                    return PartialView(nameof(PV_Eixo3));
                case "4":
                    return PartialView(nameof(PV_Eixo4));
                default:
                    return PartialView(nameof(PV_Nada));
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Finalizar(OpiniaoViewModel opiniaoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), opiniaoViewModel);
            }
            var resultado = opiniaoViewModel.ToModel(opiniaoViewModel.Cpf,
                opiniaoViewModel.Rg, opiniaoViewModel.Nome,
                opiniaoViewModel.Endereco, opiniaoViewModel.Eixo,
                opiniaoViewModel.Opiniao, opiniaoViewModel.Telefone, opiniaoViewModel.Email);

            string[] div = opiniaoViewModel.Topico.Split('-');
            resultado.NPrograma = div[0];
            resultado.Tema = div[1];
            resultado.AreaTematica = div[2];

            _context.Opiniaos.Add(resultado);
            await _context.SaveChangesAsync();
            
            return View(nameof(Concluido));
        }
        
        public IActionResult Concluido()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}