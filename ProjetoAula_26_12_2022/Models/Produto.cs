using System.ComponentModel.DataAnnotations;

namespace ProjetoAula_26_12_2022.Models
{
    public class Produto
    {
        [Display(Name = "#")]

        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        [Display(Name = "Descrição")]

        public string? Descricao { get; set; }
        [Display(Name = "Data de Entrada")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]

        public DateTime? DataEntrada { get; set; }
        [Display(Name = "Data de Validade")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]

        public DateTime? DataValidade { get; set; }
        [Display(Name = "Estoque")]

        public int QtdEstoque { get; set; }
    }
}
