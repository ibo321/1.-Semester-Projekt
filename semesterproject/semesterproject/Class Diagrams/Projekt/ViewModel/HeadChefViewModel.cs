using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Projekt.Annotations;
using Projekt.Model;
using Projekt.Singletons;

namespace Projekt.ViewModel
{
    class HeadChefViewModel : INotifyPropertyChanged
    {
        //private double _specialTotalPrice;
        //private double get;
        public string HeadChef { get; set; }
        public string Meal { get; set; }
        public string Ingredient { get; set; }
        public double IngredientPrice { get; set; }
        public int IngredientAmount { get; set; }
        

        //public double SpecialTotalPrice

        //{
        //    get { return GetSpecialTotalPrice(); }
        //    set { _specialTotalPrice = value; }
        //}

        public double TotalPrice
        {
            get { return GetTotalPrice(); }
            set { TotalPrice = value; }
        }

        //public int WeekNo { get; set; }
        public MenuSingleton MenuSingleton { get; set; }
        public StaffSingleton StaffSingleton { get; set; }
        public PriceSingleton PriceSingleton { get; set; }
        //public ObservableCollection<Ingredients> MondayIngredientList { get; set; }
        //public ObservableCollection<Ingredients> TuesdayIngredientList { get; set; }
        //public ObservableCollection<Ingredients> WednesdayIngredientList { get; set; }
        //public ObservableCollection<Ingredients> ThursdayIngredientList { get; set; }

        public HeadChefViewModel()
        {
            HeadChef = "";
            Meal = "";
            Ingredient = "";
            //TotalPrice = 0;
            //MondayIngredientList = new ObservableCollection<Ingredients>();
            //TuesdayIngredientList = new ObservableCollection<Ingredients>();
            //WednesdayIngredientList = new ObservableCollection<Ingredients>();
            //ThursdayIngredientList = new ObservableCollection<Ingredients>();
            MenuSingleton = MenuSingleton.Instance;
            StaffSingleton = StaffSingleton.Instance;
            PriceSingleton = PriceSingleton.Instance;
        }

        public void AddIngredientMonday()
        {
            PriceSingleton.MondayIngredientList.Add(new Ingredients(Ingredient, IngredientPrice, IngredientAmount));
        }
        public void AddIngredientTuesday()
        {
            PriceSingleton.TuesdayIngredientList.Add(new Ingredients(Ingredient, IngredientPrice, IngredientAmount));
        }
        public void AddIngredientWednesday()
        {
            PriceSingleton.WednesdayIngredientList.Add(new Ingredients(Ingredient, IngredientPrice, IngredientAmount));
        }
        public void AddIngredientThursday()
        {
            PriceSingleton.ThursdayIngredientList.Add(new Ingredients(Ingredient, IngredientPrice, IngredientAmount));
        }

        public double GetTotalPrice()
        {
             return Price.HeadChefTotalPriceCalculation();
        }

        //public double GetSpecialTotalPrice()
        //{
        //    return Price.HeadChefSpecialTotalPriceCalculation();
        //}



        #region PropertyChangeSupport
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
