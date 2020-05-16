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
using System.Collections.ObjectModel;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CityAssault
{
   
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Campaign : Page
    {
        public ObservableCollection<Mission> ListaMisiones { get; } = new ObservableCollection<Mission>();

        int rewards= 10;
        int maxRewards =50;
        public Campaign()
        {
            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            this.InitializeComponent();
            RewardsUnlocked();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Cargamos la lista de los Drones
            if (ListaMisiones != null)
            {
                foreach (Mission mis in model.GetAllMissions())
                {
                    VMission VMitem = new VMission(mis);
                    ListaMisiones.Add(VMitem);
                }

            }
            base.OnNavigatedTo(e);
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

        private void LevelSelected(object sender, ItemClickEventArgs e)
        {
            Mission aux = e.ClickedItem as Mission;
            if(aux.side == Mission.State.Unlock)
            {
                PlayButton.IsEnabled = true;
                Texto.Text = aux.Descripcion;
            }
            else {
                PlayButton.IsEnabled = false;
                Texto.Text = aux.Descripcion;
            }
        }

        private void LevelUnselected(object sender, RoutedEventArgs e)
        {
            PlayButton.IsEnabled = false;
            Texto.Text = "";
        }
    }
}
