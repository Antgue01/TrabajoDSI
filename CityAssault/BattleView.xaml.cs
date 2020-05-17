using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class BattleView : Page
    {
        int min = 2;
        int sec = 0;

        public DispatcherTimer GameTimer { get; private set; }

        public BattleView()
        {
            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            GameTimeSetup();    //Activamos el timer para leer el mando
        }

        public void GameTimeSetup()
        {
            GameTimer = new DispatcherTimer();
            GameTimer.Tick += Counter;     //Metodo al que llama cada vez
            GameTimer.Interval = new TimeSpan(10000000);
            GameTimer.Start();
        }

        private void Counter(object sender, object e)   //Contador del tiempo de batalla
        {
            sec--;
            if(sec < 0)
            {
                sec = 59;
                min--;
            }

            if (min <= 0 && sec <=0)
            {
                this.Frame.Navigate(typeof(BirdView));
                GameTimer.Stop();
            }

            Contador.Text = min + ":" + sec;
        }

        private void NormalShoot(object sender, RoutedEventArgs e)
        {
            //Pium
            BarraSaludE1.Value -= 5;
        }

        private void SpecialAttack(object sender, RoutedEventArgs e)
        {
            //Ataque tope poderoso
            BarraSaludE0.Value -= 15;
        }

        public void RecieveDamage(int damage)//Para comprobar que cambia la vida del jugador
        {
            BarraSalud.Value -= damage;
        }

        private void Volver(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BirdView));
        }
    }
}
