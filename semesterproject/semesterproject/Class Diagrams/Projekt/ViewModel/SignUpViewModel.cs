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
    class SignUpViewModel : INotifyPropertyChanged
    {
        public int HouseNo { get; set; }
        public int Adults { get; set; }
        public int Child715 { get; set; }
        public int Child36 { get; set; }
        public int Child02 { get; set; }
        //public string Menu { get; set; }
        //public ObservableCollection<Residence> SignUpMonday { get; set; }
        //public ObservableCollection<Residence> SignUpTuesday { get; set; }
        //public ObservableCollection<Residence> SignUpWednesday { get; set; }
        //public ObservableCollection<Residence> SignUpThursday { get; set; }
        public MenuSingleton MenuSingleton { get; set; }
        public ResidenceSingleton ResidenceSingleton { get; set; }

        public SignUpViewModel()
        {
            //Menu = "";
            //SignUpMonday = new ObservableCollection<Residence>();
            //SignUpTuesday = new ObservableCollection<Residence>();
            //SignUpWednesday = new ObservableCollection<Residence>();
            //SignUpThursday = new ObservableCollection<Residence>();
            MenuSingleton = MenuSingleton.Instance;
            ResidenceSingleton = ResidenceSingleton.Instance;
        }

        public void AddMonday()
        {
            ResidenceSingleton.SignUpMonday.Add(new Residence(Adults, HouseNo, Child02, Child36, Child715));
            OnPropertyChanged();
        }

        public void AddTuesday()
        {
            ResidenceSingleton.SignUpTuesday.Add(new Residence(Adults, HouseNo, Child02, Child36, Child715));
            OnPropertyChanged();
        }

        public void AddWednesday()
        {
            ResidenceSingleton.SignUpWednesday.Add(new Residence(Adults, HouseNo, Child02, Child36, Child715));
            OnPropertyChanged();
        }

        public void AddThursday()
        {
            ResidenceSingleton.SignUpThursday.Add(new Residence(Adults, HouseNo, Child02, Child36, Child715));
            OnPropertyChanged();
        }

        public void RemoveMonday()
        {
            foreach (Residence r in ResidenceSingleton.SignUpMonday)
            {
                if (HouseNo == r.HouseNo)
                {
                   ResidenceSingleton.SignUpMonday.Remove(r);
                    if (ResidenceSingleton.SignUpMonday.Count() == 0)
                    {
                        break;
                    }
                }
            }
            OnPropertyChanged();
        }

        public void RemoveTuesday()
        {
            foreach (Residence r in ResidenceSingleton.SignUpTuesday)
            {
                if (HouseNo == r.HouseNo)
                {
                    ResidenceSingleton.SignUpTuesday.Remove(r);
                    if (ResidenceSingleton.SignUpTuesday.Count() == 0)
                    {
                        break;
                    }
                }
            }
            OnPropertyChanged();
        }

        public void RemoveWednesday()
        {
            foreach (Residence r in ResidenceSingleton.SignUpWednesday)
            {
                if (HouseNo == r.HouseNo)
                {
                    ResidenceSingleton.SignUpWednesday.Remove(r);
                    if (ResidenceSingleton.SignUpWednesday.Count() == 0)
                    {
                        break;
                    }
                }
            }
            OnPropertyChanged();
        }

        public void RemoveThursday()
        {
            foreach (Residence r in ResidenceSingleton.SignUpThursday)
            {
                if (HouseNo == r.HouseNo)
                {
                    ResidenceSingleton.SignUpThursday.Remove(r);
                    if (ResidenceSingleton.SignUpThursday.Count() == 0)
                    {
                        break;
                    }
                }
            }
            OnPropertyChanged();
        }

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
