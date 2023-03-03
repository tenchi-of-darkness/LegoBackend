namespace LegoBackend.Model;

public class InventoryEntity
{
    public int Id { get; set; }
    public IEnumerable<LegoSetEntity> OwnedLegoSets { get; set; } = Enumerable.Empty<LegoSetEntity>();
}