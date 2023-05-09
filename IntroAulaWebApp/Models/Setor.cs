using System.ComponentModel.DataAnnotations;
namespace IntroAulaWebApp.Models
{
    public class Setor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O lote deve ser informado")]
        [Display(Name = "Setor")]
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Descricao")]
        public string Descricao { get; set; } = string.Empty;
    }
}
