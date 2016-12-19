using System.Collections.ObjectModel;
using Projekt.Model;

namespace Projekt.Singletons
{
    class MenuSingleton
    {
        public ObservableCollection<Menu> MenusMonday { get; set; }
        public ObservableCollection<Menu> MenusTuesday { get; set; }
        public ObservableCollection<Menu> MenusWednesday { get; set; }
        public ObservableCollection<Menu> MenusThursday { get; set; }

        private MenuSingleton()
        {
            MenusMonday = new ObservableCollection<Menu>();
            MenusTuesday = new ObservableCollection<Menu>();
            MenusWednesday = new ObservableCollection<Menu>();
            MenusThursday = new ObservableCollection<Menu>();
        }

        private static MenuSingleton _instance;

        public static MenuSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MenuSingleton();
                }
                return _instance;
            }
        }
    }
}
