namespace back_end.Domain.Entities
{
    public class Consorcios
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Tipo { get; set; }
        public int? Valor { get; set; }
        public int QuantidadeCotas { get; set; }
    }
}