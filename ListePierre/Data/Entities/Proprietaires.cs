namespace ListePierre.Data.Entities;

public class Proprietaires
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Prenom { get; set; } = null;
    public string Email { get; set; } = null!;
    public int NombrePierrePossedee { get; set; } = 0;
}
