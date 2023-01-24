using ApiCatalogo.Context;
using ApiCatlogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatlogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApiNetContext _context;

        public ProdutosController(ApiNetContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var prod = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (prod is null)
                return BadRequest("Produto Invalido!");

            return Ok(prod);
        }

        [HttpPost]
        public IActionResult CreateProduct(Produto produto)
        {
            if (produto is null)
                return BadRequest();
            
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }

    }
}
