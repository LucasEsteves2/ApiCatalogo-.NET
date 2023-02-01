using System.ComponentModel.DataAnnotations;

namespace ApiCatlogo.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Nome { get; set; }

        public string? ImagemUrl { get; set; }

        public virtual List<Produto>? Produtos { get; set; }

        public Categoria()
        {
            Produtos = new List<Produto>();
        }
    }
}
