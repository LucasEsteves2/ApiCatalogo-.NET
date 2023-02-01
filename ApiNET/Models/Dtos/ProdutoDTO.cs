using System.ComponentModel.DataAnnotations;

namespace ApiCatlogo.Models.Dtos
{
    public class ProdutoDto
    {
        [StringLength(100, ErrorMessage = "O nome deve ter no maximo 100 caracter e no min 6", MinimumLength = 6)]
        [Required(ErrorMessage = "Informe o nome  do produto")]
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
