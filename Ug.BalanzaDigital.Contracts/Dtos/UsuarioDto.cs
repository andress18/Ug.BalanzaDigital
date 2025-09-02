namespace Ug.BalanzaDigital.Contracts.Dtos;

public class UsuarioDto
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Estado { get; set; }

    public string Comuna { get; set; } = null!;

    public int RolId { get; set; }
}