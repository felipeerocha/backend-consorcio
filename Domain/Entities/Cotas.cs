namespace back_end.Domain.Entities
{
    public class Cotas
    {
        public int Id { get; set; }
        public int ConsorcioId { get; set; }
        public int NumeroCota { get; set; }
        public decimal Valor { get; set; }
        public string? Status { get; set; }
        public string? Tipo { get; set; }

    }
}