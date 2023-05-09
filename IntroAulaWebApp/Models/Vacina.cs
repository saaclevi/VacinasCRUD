using System.ComponentModel.DataAnnotations;

namespace IntroAulaWebApp.Models
{
    public class Vacina
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Id deve ser informado")]

        [Display(Name = "Lote da vacina")]
        public int Lote { get; set; }
        [Display(Name = "Quantidade de vacinas disponíveis ")]
        public int Qtde { get; set; }
        [Display(Name = "Data de fabricação da vacina")]
        public DateTime dataFabr { get; set; }
        [Display(Name = "Data de vencimento da vacina")]
        public DateTime dataVenc { get; set; }
        [Display(Name = "Nome da Vacina")]
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Fornecedor")]
        public string Fornecedor { get; set; } = string.Empty;


        //(lote, quantidade, data de fabricação, data de vencimento, etc.)
    }
}
