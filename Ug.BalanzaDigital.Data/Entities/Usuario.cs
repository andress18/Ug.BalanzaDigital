namespace Ug.BalanzaDigital.Data.Entities;

public class Usuario
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Estado { get; set; }

    public string Comuna { get; set; } = null!;

    public int RolId { get; set; }

    // public virtual ICollection<RegistrosRecoleccion> RegistrosRecoleccions { get; set; } = new List<RegistrosRecoleccion>();

    // public virtual Role Rol { get; set; } = null!;
}
