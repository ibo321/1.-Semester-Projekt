using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.ViewModel;

namespace Projekt.Model
{
    class Price
    {
        public string Ingredients { get; set; }
        public int IngredientsPrice { get; set; }
        public static double TotalPrice { get ; set; }
        public static double SpecialTotalPrice { get; set; }
        public static bool CheckBox { get; set; }

        public Price()
        {
            //Ingredients = ingredients;
            //IngredientsPrice = ingredientsPrice;
        }



        public static double HeadChefTotalPriceCalculation()
        {
            return 42;
        }

        //public static double HeadChefSpecialTotalPriceCalculation()
        //{
        //    CheckBox = PlanViewModel.CheckBox;
        //    if (CheckBox == true)
        //    {
        //        return 167;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}


    }
}
