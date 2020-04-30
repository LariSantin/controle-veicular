using ControleVeicular.Models;
using ControleVeicular.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleVeicular.Controllers
{
    public class HomeController : Controller
    {
		
		private readonly IAnuncioRepository anuncioRepository;
        private readonly IMarcaRepository marcaRepository;
        private readonly IModeloRepository modeloRepository;

        public HomeController(IAnuncioRepository anuncioRepository, IMarcaRepository marcaRepository, IModeloRepository modeloRepository)
        {
            this.anuncioRepository = anuncioRepository;
            this.marcaRepository = marcaRepository;
            this.modeloRepository = modeloRepository;
        }
		
		public ActionResult Index()
		{
			return View();
		}

        public IActionResult Funcionalidade()
        {
            return View();
        }
        public IActionResult CadastroAnuncio()
        {
            return View();
        }
        public IActionResult CadastroMarca()
        {
            return View();
        }
        public IActionResult CadastroModelo()
        {
            return View();
        }
		
		 public IActionResult Voltar()
        {
            return RedirectToAction(nameof(Funcionalidade));
        }

        [HttpPost]
        public string CadastroMarca([FromBody] Marca marca)
        {
            return marcaRepository.SaveMarca(marca);
        }

        [HttpPost]
        public string CadastroModelo([FromBody] Modelo modelo)
        {
            return modeloRepository.SaveModelo(modelo);
        }

        [HttpPost]
        public string CadastroAnuncio([FromBody] AnuncioBean anuncio)
        {
            return anuncioRepository.SaveAnuncio(anuncio);
        }

        public ActionResult ListagemAnuncio()
        {
            return View(anuncioRepository.GetAnuncios());
        }
		
		public ActionResult ListaMarcas()
        {
            return View(marcaRepository.GetMarcas());
        }
		
		public ActionResult ListaModelos()
        {
            return View(modeloRepository.GetModelos());
        }

        [HttpGet]
        public List<Marca> BuscaMarcas()
        {
            return marcaRepository.GetMarcas();
        }

        [HttpGet]
        public List<Modelo> BuscaModelos()
        {
            return modeloRepository.GetModelos();
        }

    }
}
