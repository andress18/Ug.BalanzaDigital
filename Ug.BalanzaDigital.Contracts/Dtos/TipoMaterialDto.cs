
using System.ComponentModel.DataAnnotations;

namespace Ug.BalanzaDigital.Contracts.Dtos;

public class TipoMaterialDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
}