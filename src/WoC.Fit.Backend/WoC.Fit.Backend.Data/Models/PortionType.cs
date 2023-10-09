using WoC.Fit.Backend.Data.Models;

public class PortionType
{
    public int Id { get; set; }
    public string Name { get; set; } // e.g. "gram", "piece", "oz", etc.

    public virtual ICollection<Product> Products { get; set; }
}
