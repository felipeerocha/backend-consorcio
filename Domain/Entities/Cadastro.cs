namespace back_end.Domain.Entities
{
    public class Cadastro
    {
        public int Id { get; set; }
        public int CotaId { get; set; }
        public int NumeroCota { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Contato { get; set; }
        public string? Parcelamento { get; set; }
        public string? Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}