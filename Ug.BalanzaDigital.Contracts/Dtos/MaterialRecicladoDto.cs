namespace Ug.BalanzaDigital.Contracts.Dtos;

public class MaterialRecicladoDto
{
    public int Id { get; set; }
    public TipoMaterialDto Tipo { get; set; } = null!;
    public decimal Peso { get; set; }
    public int TamanioId { get; set; }
    public TamanioDto Tamanio { get; set; } = new();
}
