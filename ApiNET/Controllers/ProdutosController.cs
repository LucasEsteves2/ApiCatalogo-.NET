using ApiCatalogo.Context;
using ApiCatlogo.Models;
using ApiCatlogo.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatlogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApiNetContext _context;

        public ProdutosController(ApiNetContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult GetProducts()
        {
            var produtos = _context.Produtos.Include(c => c.Categoria).ToList();

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public ActionResult GetProductById(int id)
        {
            var prod = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (prod is null)
                return BadRequest("Produto Invalido!");

            return Ok(prod);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProdutoDto prodDto)
        {
            var produto = new Produto();

            if (prodDto is null)
                return BadRequest("Produto Invalido");

            produto.BuildProduct(prodDto);

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProductById), new { id = produto.Id }, produto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var prod = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (prod is null)
                return BadRequest("Produto Invalido!");

            _context.Produtos.Remove(prod);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult EditProduct(int id, ProdutoDto prodDto)
        {
            var prod = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (prod is null)
                return BadRequest("Produto Invalido!");

            prod.BuildProduct(prodDto);

            _context.SaveChanges();

            return NoContent();
        }

    }
}
