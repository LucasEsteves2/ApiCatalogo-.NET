using ApiCatalogo.Context;
using ApiCatlogo.Models.Dtos;
using ApiCatlogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace ApiCatlogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ApiNetContext _context;

        public CategoriaController(ApiNetContext context)
        {
            _context = context;
        }


        [HttpGet("produtos")]
        public ActionResult GetCategoriaAndProducts()
        {
            var cat = _context.Categorias.Include(p => p.Produtos).ToList();

            return Ok(cat);
        }

        [HttpGet]
        public ActionResult GetCategorias()
        {
            var cat = _context.Categorias.ToList();

            return Ok(cat);
        }

        [HttpPost]
        public IActionResult CreateCategoria(Categoria cat)
        {
           _context.Categorias.Add(cat);
            _context.SaveChanges();

            return Ok(null);

        }

    }
}
