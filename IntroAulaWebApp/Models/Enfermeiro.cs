using System.ComponentModel.DataAnnotations;
namespace IntroAulaWebApp.Models
{
    public class Enfermeiro
    {
        //(id, nome, RG, CPF, Endereço, Coren, data de admissão, etc.)
        public int Id { get; set; }
        [Required(ErrorMessage = "O Id deve ser informado")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Rg")]
        public int Rg { get; set; }
        [Display(Name = "CPF")]
        public int CPF { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; } = string.Empty;
        [Display(Name = "Coren")]
        public int Coren { get; set; }
        [Display(Name = "Data da Admissão")]
        public DateTime DataAdmi { get; set; }
    }
}
