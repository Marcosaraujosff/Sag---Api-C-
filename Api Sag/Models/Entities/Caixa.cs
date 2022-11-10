namespace Api_Sag.Models.Entities
{
    public class Caixa
    {
        public int Id { get; set; }
        public string Operador { get; set; }
        public bool Confere { get; set; }
        public int ValorDia { get; set; }
        public bool ConfereGerente { get; set; }
    }
}
