using System.Collections.ObjectModel;
using Projekt.Model;
using Projekt.ViewModel;

namespace Projekt.Singletons
{
    class PriceSingleton
    {
        public bool MondayCheckBox { get; set; }
        public bool TuesdayCheckBox { get; set; }
        public bool WednesdayCheckBox { get; set; }
        public bool ThursdayCheckBox { get; set; }
        public ObservableCollection<Ingredients> MondayIngredientList { get; set; }
        public ObservableCollection<Ingredients> TuesdayIngredientList { get; set; }
        public ObservableCollection<Ingredients> WednesdayIngredientList { get; set; }
        public ObservableCollection<Ingredients> ThursdayIngredientList { get; set; }

        private PriceSingleton()
        {
            MondayCheckBox = PlanViewModel.MondayCheckBox;
            TuesdayCheckBox = PlanViewModel.TuesdayCheckBox;
            WednesdayCheckBox = PlanViewModel.WednesdayCheckBox;
            ThursdayCheckBox = PlanViewModel.ThursdayCheckBox;
            MondayIngredientList = new ObservableCollection<Ingredients>();
            TuesdayIngredientList = new ObservableCollection<Ingredients>();
            WednesdayIngredientList = new ObservableCollection<Ingredients>();
            ThursdayIngredientList = new ObservableCollection<Ingredients>();
        }

        private static PriceSingleton _instance;

        public static PriceSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PriceSingleton();
                }
                return _instance;
            }
        }
    }
}
