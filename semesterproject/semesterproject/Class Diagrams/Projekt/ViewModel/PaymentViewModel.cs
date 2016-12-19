using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Projekt.Annotations;
using Projekt.Model;
using Projekt.Singletons;

namespace Projekt.ViewModel
{
    class PaymentViewModel : INotifyPropertyChanged
    {
        //private double _totalPrice;
        //private double _specialTotalPrice;
        public int HouseNo { get; set; }
        public int DaysSignedUp { get; set; } = 3;
        public static bool MondayCheckBox { get; set; }
        public static bool TuesdayCheckBox { get; set; }
        public static bool WednesdayCheckBox { get; set; }
        public static bool ThursdayCheckBox { get; set; }
        public PriceSingleton PriceSingleton { get; set; }
        public double SpecialTotalPrice
        {
            get { return HeadChefSpecialTotalPriceCalculation(); }
            set { SpecialTotalPrice = value; }
        }

        public double TotalPrice
        {
            get { return TotalPriceX(); }
            set { TotalPrice = value; }
        }

        public double TotalPriceX()
        {
            return Price.HeadChefTotalPriceCalculation() * 3;
            //if (HouseNo != 0)
            //{
            //    return Price.HeadChefTotalPriceCalculation() * 3;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        //public double SpecialTotalPriceX()
        //{
        //    return Price.HeadChefSpecialTotalPriceCalculation();  
        //}
        public static double HeadChefSpecialTotalPriceCalculation()
        {
            MondayCheckBox = PlanViewModel.MondayCheckBox;
            TuesdayCheckBox = PlanViewModel.TuesdayCheckBox;
            WednesdayCheckBox = PlanViewModel.WednesdayCheckBox;
            ThursdayCheckBox = PlanViewModel.ThursdayCheckBox;

            if (MondayCheckBox == true || TuesdayCheckBox == true || WednesdayCheckBox == true || ThursdayCheckBox == true)
            {
                return 167;
            }
            else
            {
                return 0;
            }
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
