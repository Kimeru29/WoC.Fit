namespace WoC.Fit.Backend.Data.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } // Virtual property for Lazy Loading
    }

}
