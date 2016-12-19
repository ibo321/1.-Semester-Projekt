using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Menu
    {
        public int No { get; set; }
        public string Meal { get; set; }
        public static int Count { get; set; } = 1;

        public Menu(string meal)
        {
            No = Count++;
            Meal = meal;
        }

        public override string ToString()
        {
            return $"Menu: {Meal}";
        }
    }
}
