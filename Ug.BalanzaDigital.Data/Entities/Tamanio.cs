using System.ComponentModel.DataAnnotations;

namespace Ug.BalanzaDigital.Data.Entities;

public class Tamanio
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string RangoAlturaAnchura { get; set; } = null!;
    public ICollection<MaterialReciclado> MaterialesReciclados { get; set; } = [];
}