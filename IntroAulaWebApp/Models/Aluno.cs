namespace IntroAulaWebApp.Models
{
    public class Aluno
    {
        public int Id {get; set; }
        public string? Name { get; set; }
        public DateTime Nascimento { get; set; }
        public string NomePai { get; set; } = string.Empty;
        public string NomeMae { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
    }
}
