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
        public virtual Brand Brand { get; set; } 
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public int MacronutrientId { get; set; }
        public virtual Macronutrient MainMacronutrient { get; set; }
        public string Portion { get; set; }
        public int PortionTypeId { get; set; }
        public PortionType PortionType { get; set; }
        public double Calories { get; set; }
        public double Sodium { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
    }

}
