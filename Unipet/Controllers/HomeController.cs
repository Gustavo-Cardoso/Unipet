using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Unipet.Data;
using Unipet.Models;

namespace Unipet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            /* Blog */
            var blogs = _context.Blogs
                .Where(b => b.ExibirHome).OrderBy(b => b.Titulo).ToList();
            ViewData["Blogs"] = blogs;
            return View();
        }

        public IActionResult Sobre()
        {
            /* Relatos */
            var relatos = _context.Relatos
                .Where(r => r.ExibirHome).OrderBy(r => r.Nome).ToList();
            ViewData["Relatos"] = relatos;
            return View();
        }

        public IActionResult Parceiros()
        {
            /* Empresas */
            var parceiros = _context.Empresas
                .Where(p => p.ExibirHome).ToList();
            ViewData["Empresas"] = parceiros;
            return View();
        }

        public async Task<IActionResult> Planos()
        {
            ViewData["Especialidade"] = new SelectList(_context.Especialidades, "IdEspecialidade", "NomeEspecialidade");
            var planos = await _context.Planos
                   .Include(e => e.Empresa)
                   .Include(ep => ep.EspecialidadesPlanos)
                   .ThenInclude(ep => ep.Especialidade)
                   .Where(e => e.ExibirHome).ToListAsync();
            return View(planos);
        }

        public async Task<PartialViewResult> _PlanosGrid(string inputEmpresa, int? inputValores, int? inputEspecialidade, string inputCidade)
        {
            /* Carrega o grid */
            var planos = _context.Planos
                 .Include(e => e.Empresa)
                 .Include(ep => ep.EspecialidadesPlanos)
                 .ThenInclude(ep => ep.Especialidade)
                 .Include(p => p.AreaCobertura)
                 .ThenInclude(a => a.Municipio)
                 .AsQueryable();

            if (inputEmpresa != null)
                planos = planos.Where(p => p.Empresa.RazaoSocial.Contains(inputEmpresa));

            if (inputValores != null)
            {
                switch (inputValores)
                {
                    case 1:
                        planos = planos.Where(p => p.Valor < 40);
                        break;
                    case 2:
                        planos = planos.Where(p => p.Valor >= 40 && p.Valor < 70);
                        break;
                    case 3:
                        planos = planos.Where(p => p.Valor >= 70 && p.Valor < 110);
                        break;
                    case 4:
                        planos = planos.Where(p => p.Valor >= 110);
                        break;
                    default:
                        break;
                }
            }

            if (inputEspecialidade != null)
            {
                var especialidadePlanos = _context.EspecialidadePlanos.Where(ep => ep.IdEspecialidade == inputEspecialidade).Select(ep => ep.IdPlano).ToList();
                planos = planos.Where(p => especialidadePlanos.Contains(p.IdPlano));
            }

            if (inputCidade != null)
            {
                var municipios = _context.Municipios.Where(m => m.NomeMunicipio.Contains(inputCidade)).Select(m => m.IdMunicipio).ToList();
                var areaPlanos = _context.AreaCobertura.Where(a => municipios.Contains(a.IdMunicipio)).Select(a => a.IdArea).ToList();
                planos = planos.Where(p => areaPlanos.Contains(p.IdArea));
            }

            return PartialView(await planos.ToListAsync());
        }

        // public IActionResult AreaCobertura()
        public async Task<IActionResult> AreaCobertura()
        {
             var areas = await _context.AreaCobertura
                   .Include(e => e.Empresa)
                   .Include(a => a.Municipio)
                   .Where(e => e.ExibirHome).ToListAsync();
            return View(areas);
        }
        public async Task<PartialViewResult> _AreasGrid(string inputCidade)
        {
            /* Carrega o grid */
            var areas = _context.AreaCobertura
                 .Include(e => e.Empresa)
                 .Include(a => a.Municipio)
                 .AsQueryable();

            if (inputCidade != null)
                areas = areas.Where(a => a.Municipio.NomeMunicipio.Contains(inputCidade));

            return PartialView(await areas.ToListAsync());
        }

        public IActionResult Duvidas()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult ContratoPlano()
        {
            return View();
        }

        public IActionResult MinhaConta()
        {
            return View();
        }

        public IActionResult GrupoUnipet()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
