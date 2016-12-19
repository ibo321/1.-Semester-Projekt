using System.Collections.ObjectModel;
using Projekt.Model;

namespace Projekt.Singletons
{
    class StaffSingleton
    {
        public ObservableCollection<Staff> StaffsMonday { get; set; }
        public ObservableCollection<Staff> StaffsTuesday { get; set; }
        public ObservableCollection<Staff> StaffsWednesday { get; set; }
        public ObservableCollection<Staff> StaffsThursday { get; set; }

        private StaffSingleton()
        {
            StaffsMonday = new ObservableCollection<Staff>();
            StaffsTuesday = new ObservableCollection<Staff>();
            StaffsWednesday = new ObservableCollection<Staff>();
            StaffsThursday = new ObservableCollection<Staff>();
        }

        private static StaffSingleton _instance;

        public static StaffSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StaffSingleton();
                }
                return _instance;
            }
        }
    }
}
