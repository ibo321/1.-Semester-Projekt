using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Projekt.View;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Projekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void PlanButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Plan));
        }

        private void EatingButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.SignUp));
        }

        private void ChefButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.HeadChef));
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Payment));
        }
    }
}
