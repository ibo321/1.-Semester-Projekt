using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Ingredients
    {
        public string Ingredient { get; set; }
        public double IngredientPrice { get; set; }
        public int IngredientAmount { get; set; }

        public Ingredients(string ingredient, double ingredientPrice, int ingredientAmount)
        {
            Ingredient = ingredient;
            IngredientPrice = ingredientPrice;
            IngredientAmount = ingredientAmount;
        }

        public override string ToString()
        {
            return $"Ingrediens: {Ingredient}\nAntal: {IngredientAmount}\nStk. Pris: {IngredientPrice}";
        }
    }
}
