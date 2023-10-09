namespace WoC.Fit.Backend.Api.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string ProductType { get; set; }
        public string MainMacronutrient { get; set; }
        public string Portion { get; set; }
        public double Calories { get; set; }
        public double Sodium { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
    }
}