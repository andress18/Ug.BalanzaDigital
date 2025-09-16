using System.ComponentModel.DataAnnotations;

namespace Ug.BalanzaDigital.Data.Entities;

public class Rol
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
}