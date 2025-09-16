using System.ComponentModel.DataAnnotations;

namespace Ug.BalanzaDigital.Data.Entities;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }
    public int RolId { get; set; }

    public virtual Rol Rol { get; set; } = null!;
}
