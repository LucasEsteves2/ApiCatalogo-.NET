using ApiCatlogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context
{
    public class ApiNetContext : DbContext
    {
        public ApiNetContext(DbContextOptions<ApiNetContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; } 
        public DbSet<Categoria> Categorias { get; set; } 
    }
}
