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

            //KeyboardAccelerator GoBack = new KeyboardAccelerator();
            //GoBack.Key = VirtualKey.GoBack;
            //GoBack.Invoked += BackInvoked;
            //KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            //AltLeft.Key = VirtualKey.Left;
            //AltLeft.Invoked += BackInvoked;
            //this.KeyboardAccelerators.Add(GoBack);
            //this.KeyboardAccelerators.Add(AltLeft);
            //// ALT routes here
            //AltLeft.Modifiers = VirtualKeyModifiers.Menu;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //BackButton.IsEnabled = this.Frame.CanGoBack;
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            //On_BackRequested();
            this.Frame.Navigate(typeof(MainMenu));
        }

        //private bool On_BackRequested()
        //{
        //    if (this.Frame.CanGoBack)
        //    {
        //        this.Frame.GoBack();
        //        return true;
        //    }
        //    return false;
        //}

        //private void BackInvoked(KeyboardAccelerator sender,
        //KeyboardAcceleratorInvokedEventArgs args)
        //{
        //    On_BackRequested();
        //    args.Handled = true;
        //}

        private void GarageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Garage));
        }

        private void LocalButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnlineButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
