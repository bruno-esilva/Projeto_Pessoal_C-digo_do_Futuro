using System.ComponentModel.DataAnnotations;

namespace ProjetoAula_26_12_2022.Models
{
    public class Pedido
    {
        [Display(Name = "#")]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        [Display(Name = "Total do Pedido")]
        public int? ValorTotal { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        [Display(Name = "Data de Entrada")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DataEntrada { get; set; }
        [Display(Name = "Data de Entrega")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DataEntrega { get; set; }
    }
}
