using System.ComponentModel.DataAnnotations;

namespace ApiCatlogo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "O nome deve ter no maximo 100 caracter e no min 6", MinimumLength = 6)]
        [Required(ErrorMessage = "Informe o nome  do produto")]
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public int CateogriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
