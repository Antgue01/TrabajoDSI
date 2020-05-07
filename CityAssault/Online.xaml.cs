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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CityAssault
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Online : Page
    {
        public Online()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

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
            this.Frame.Navigate(typeof(Garage));
        }

        private void LocalButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BirdView));
        }

        private void OnlineButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BirdView));

        }
    }
}
