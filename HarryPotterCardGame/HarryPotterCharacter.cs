public class HarryPotterCharacter
{
    public string Name { get; set; } = string.Empty;
    public string House { get; set; } = "Unknown";
    public string Image { get; set; } = string.Empty;
    public string Ancestry { get; set; } = "Unknown";
    public string Patronus { get; set; } = "None";
    public Wand Wand { get; set; } = new Wand();
}

public class Wand
{
    public string Wood { get; set; } = "Unknown";
    public string Core { get; set; } = "Unknown";
    public double? Length { get; set; }
}
