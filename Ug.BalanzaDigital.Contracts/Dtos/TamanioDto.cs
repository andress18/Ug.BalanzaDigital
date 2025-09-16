using System.ComponentModel.DataAnnotations;

namespace Ug.BalanzaDigital.Contracts.Dtos;

public class TamanioDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string RangoPesoKilos { get; set; } = null!;
}