using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Model;

namespace Projekt.Singletons
{
    class ResidenceSingleton
    {
        public ObservableCollection<Residence> SignUpMonday { get; set; }
        public ObservableCollection<Residence> SignUpTuesday { get; set; }
        public ObservableCollection<Residence> SignUpWednesday { get; set; }
        public ObservableCollection<Residence> SignUpThursday { get; set; }

        private ResidenceSingleton()
        {
            SignUpMonday = new ObservableCollection<Residence>();
            SignUpTuesday = new ObservableCollection<Residence>();
            SignUpWednesday = new ObservableCollection<Residence>();
            SignUpThursday = new ObservableCollection<Residence>();
        }

        private static ResidenceSingleton _instance;

        public static ResidenceSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ResidenceSingleton();
                }
                return _instance;
            }
        }
    }
}
