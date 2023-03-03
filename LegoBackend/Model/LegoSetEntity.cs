namespace LegoBackend.Model;

public class LegoSetEntity
{
    public int Id { get; set; }
    public int TotalPieces { get; set; }
    public decimal Price { get; set; }
    public float HeigthInCm { get; set; }
    public float WidthInCm { get; set; }
    public float LengthInCm { get; set; }
    public int ThemeId { get; set; }
    public LegoThemeEntity Theme { get; set; } = new();
}