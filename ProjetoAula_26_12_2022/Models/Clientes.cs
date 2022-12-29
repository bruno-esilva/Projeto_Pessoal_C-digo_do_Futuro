using System.ComponentModel.DataAnnotations;

namespace ProjetoAula_26_12_2022.Models
{
    public class Cliente
    {
        [Display(Name = "#")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        [Display(Name = "CPF")]
        public string? CPF { get; set; }
        [Display(Name = "Logradouro")]
        public string? Logradouro { get; set; }
        [Display(Name = "Número")]
        public int? Numero { get; set; }
        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }
        [Display(Name = "Estado")]
        public string? Estado { get; set; }
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DataCadastro { get; set; }
    }
}
