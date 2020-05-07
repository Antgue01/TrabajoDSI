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

using Windows.UI.ViewManagement;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CityAssault
{
   
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Campaign : Page
    {
        int rewards= 10;
        int maxRewards =50;
        public Campaign()
        {
            //ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            //ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            this.InitializeComponent();
            RewardsUnlocked();
        }

        private void RewardsUnlocked()
        {
            Rewards.Text = rewards + "/" + maxRewards;
        }
        private void Button_Play(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BirdView));
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void LevelSelected(object sender, RoutedEventArgs e)
        {
            PlayButton.IsEnabled = true;
        }
    }
}
