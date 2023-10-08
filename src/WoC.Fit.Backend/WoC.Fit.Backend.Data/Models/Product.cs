using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoC.Fit.Backend.Data.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; } // Virtual property for Lazy Loading
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; } // Virtual property for Lazy Loading
        public int MacronutrientId { get; set; }
        public virtual Macronutrient MainMacronutrient { get; set; } // Virtual property for Lazy Loading
        public string Portion { get; set; }
        public double Calories { get; set; }
        public double Sodium { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
    }

}
