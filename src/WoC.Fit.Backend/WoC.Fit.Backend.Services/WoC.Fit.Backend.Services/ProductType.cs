namespace WoC.Fit.Backend.Data.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; } // Virtual property for Lazy Loading
    }

}
