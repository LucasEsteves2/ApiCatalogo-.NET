using ApiCatlogo.Models.Dtos;
using System.ComponentModel.DataAnnotations;

namespace ApiCatlogo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public int CateogriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

        public Produto()
        {

        }


        public void BuildProduct(ProdutoDto prod)
        {
            Nome = prod.Nome;
            Descricao = prod.Descricao;
            ImagemUrl = prod.ImagemUrl;
            Estoque = prod.Estoque;
            DataCadastro = prod.DataCadastro;
        }
    }
}
