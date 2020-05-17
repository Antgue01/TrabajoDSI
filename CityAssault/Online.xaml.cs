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
using Windows.System;
using Windows.UI.ViewManagement;
using System.Collections.ObjectModel;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CityAssault
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Online : Page
    {
        public ObservableCollection<VMTank> ListaTanques { get; } = new ObservableCollection<VMTank>();
        private VMTank selectedTank;

        public Online()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            if (ListaTanques != null)
            {
                foreach (Tank tank in model.GetAllTanks())
                {
                    VMTank VMitem = new VMTank(tank);
                    ListaTanques.Add(VMitem);
                }

                selectedTank = ListaTanques[0];
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void goBack(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(MainMenu));
        }

        private void GarageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Garage), selectedTank.Id);
        }

        private void LocalButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BirdView));
        }

        private void OnlineButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BirdView));

        }

        private void Tank0_Checked(object sender, RoutedEventArgs e)
        {
            Tank1.IsChecked = false;
            Tank2.IsChecked = false;
            Tank3.IsChecked = false;

            selectedTank = ListaTanques[0];
            GarageButton.IsEnabled = true;
        }

        private void Tank1_Checked(object sender, RoutedEventArgs e)
        {
            Tank0.IsChecked = false;
            Tank2.IsChecked = false;
            Tank3.IsChecked = false;

            selectedTank = ListaTanques[1];
            GarageButton.IsEnabled = true;

        }

        private void Tank2_Checked(object sender, RoutedEventArgs e)
        {
            Tank1.IsChecked = false;
            Tank0.IsChecked = false;
            Tank3.IsChecked = false;

            selectedTank = ListaTanques[2];
            GarageButton.IsEnabled = true;

        }

        private void Tank3_Checked(object sender, RoutedEventArgs e)
        {
            Tank1.IsChecked = false;
            Tank2.IsChecked = false;
            Tank0.IsChecked = false;

            selectedTank = ListaTanques[3];
            GarageButton.IsEnabled = true;

        }

        private void Tank_Unchecked(object sender, RoutedEventArgs e)
        {
            GarageButton.IsEnabled = false;

        }
    }
}
