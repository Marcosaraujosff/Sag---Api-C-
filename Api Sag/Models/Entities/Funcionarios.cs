namespace Api_Sag.Models.Entities
{
    public class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
        public string Senioridade { get; set; }
        public DateTime Admissao { get; set; }
        public string? Demissao { get; set; }

    }
}
