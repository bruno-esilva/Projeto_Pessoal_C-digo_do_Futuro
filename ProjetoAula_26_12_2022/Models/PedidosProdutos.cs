using System.ComponentModel.DataAnnotations;

namespace ProjetoAula_26_12_2022.Models
{
    public class PedidoProduto
    {

        public int Id { get; set; }
        public int? IdPedido { get; set; }
        public int IdProduto { get; set; }
    }
}
