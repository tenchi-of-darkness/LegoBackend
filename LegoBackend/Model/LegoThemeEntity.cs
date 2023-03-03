namespace LegoBackend.Model;

public class LegoThemeEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public bool Discontinued { get; set; }
    public IEnumerable<LegoSetEntity> LegoSets { get; set; } = Enumerable.Empty<LegoSetEntity>();
}