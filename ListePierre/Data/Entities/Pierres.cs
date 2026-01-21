namespace ListePierre.Data.Entities;

public class Pierres : Proprietaires
{
    public Guid Id { get; set; }
    public int IdProp { get; set; }
    public string Nom { get; set; }
    public string Origine { get; set; }
    public double PoidsEnGramme { get; set; }
    public string Description { get; set; }

    public string DureteMesure { get; set; }
    public DateOnly AcquisDepuis { get; set; }
    public bool Exposee { get; set; } = false;




}
