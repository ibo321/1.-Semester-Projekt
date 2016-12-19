using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.ContentRestrictions;
using Projekt.Model;
using Projekt.Singletons;

namespace Projekt.ViewModel
{
    class PlanViewModel : INotifyPropertyChanged
    {
        //public ObservableCollection<Staff> StaffsMonday { get; set; }
        //public ObservableCollection<Staff> StaffsTuesday { get; set; }
        //public ObservableCollection<Staff> StaffsWednesday { get; set; }
        //public ObservableCollection<Staff> StaffsThursday { get; set; }
        //public ObservableCollection<Menu> MenusMonday { get; set; }
        //public ObservableCollection<Menu> MenusTuesday { get; set; }
        //public ObservableCollection<Menu> MenusWednesday { get; set; }
        //public ObservableCollection<Menu> MenusThursday { get; set; }
        public MenuSingleton MenuSingleton { get; set; }
        public PriceSingleton PriceSingleton { get; set; }
        public StaffSingleton StaffSingleton { get; set; }
        //public ObservableCollection<Object> StaffsMenus { get; set; }
        //public string HeadChef { get; set; }
        //public string AssistantChef { get; set; }
        //public string Cleaners { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Meal { get; set; }
        public static bool MondayCheckBox { get; set; }
        public static bool TuesdayCheckBox { get; set; }
        public static bool WednesdayCheckBox { get; set; }
        public static bool ThursdayCheckBox { get; set; }

        public PlanViewModel()
        {
            //StaffsMonday = new ObservableCollection<Staff>();
            //StaffsTuesday = new ObservableCollection<Staff>();
            //StaffsWednesday = new ObservableCollection<Staff>();
            //StaffsThursday = new ObservableCollection<Staff>();
            //MenusMonday = new ObservableCollection<Menu>();
            //MenusTuesday = new ObservableCollection<Menu>();
            //MenusWednesday = new ObservableCollection<Menu>();
            //MenusThursday = new ObservableCollection<Menu>();
            MenuSingleton = MenuSingleton.Instance;
            PriceSingleton = PriceSingleton.Instance;
            StaffSingleton = StaffSingleton.Instance;
            Name = "";
            Job = "";
            Meal = "";
            
        }


        public void AddMonday()
        {
            StaffSingleton.StaffsMonday.Add(new Staff(Job, Name));
            OnPropertyChanged();
        }

        public void AddTuesday()
        {
            StaffSingleton.StaffsTuesday.Add(new Staff(Job, Name));
            OnPropertyChanged();
        }

        public void AddWednesday()
        {
            StaffSingleton.StaffsWednesday.Add(new Staff(Job, Name));
            OnPropertyChanged();
        }

        public void AddThursday()
        {
            StaffSingleton.StaffsThursday.Add(new Staff(Job, Name));
            OnPropertyChanged();
        }

        public void AddMenuMonday()
        {
            MenuSingleton.MenusMonday.Add(new Menu(Meal));
            OnPropertyChanged();
        }

        public void AddMenuTuesday()
        {
            MenuSingleton.MenusTuesday.Add(new Menu(Meal));
            OnPropertyChanged();
        }

        public void AddMenuWednesday()
        {
            MenuSingleton.MenusWednesday.Add(new Menu(Meal));
            OnPropertyChanged();
        }

        public void AddMenuThursday()
        {
            MenuSingleton.MenusThursday.Add(new Menu(Meal));
            OnPropertyChanged();
        }

        #region PropertyChangeSupport
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
