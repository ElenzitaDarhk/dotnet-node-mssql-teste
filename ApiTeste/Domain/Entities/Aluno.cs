namespace ApiTeste.Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
