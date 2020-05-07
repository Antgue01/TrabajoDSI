using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CityAssault
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        private double MusicVolume = 0;
        private double EffectsVolume = 0;
        public Settings()
        {
            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            this.InitializeComponent();
            KeyboardAccelerator GoBack = new KeyboardAccelerator();
            GoBack.Key = VirtualKey.GoBack;
            GoBack.Invoked += BackInvoked;
            KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            AltLeft.Key = VirtualKey.Left;
            AltLeft.Invoked += BackInvoked;
            this.KeyboardAccelerators.Add(GoBack);
            this.KeyboardAccelerators.Add(AltLeft);
            // ALT routes here
            AltLeft.Modifiers = VirtualKeyModifiers.Menu;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BackButton.IsEnabled = this.Frame.CanGoBack;
        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
        }
        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }
        private void BackInvoked(KeyboardAccelerator sender,
        KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        }

        private void Estereo_Checked(object sender, RoutedEventArgs e)
        {
            Mono.IsChecked = false;
        }

        private void Mono_Checked(object sender, RoutedEventArgs e)
        {
            Estereo.IsChecked = false;
        }

        private void Joystick_Checked(object sender, RoutedEventArgs e)
        {
            Girscopio.IsChecked = false;
        }

        private void Girscopio_Checked(object sender, RoutedEventArgs e)
        {
            Joystick.IsChecked = false;
        }

        private void Mute_Music_Checked(object sender, RoutedEventArgs e)
        {
            Music_Slider.Value = 0;
        }

        private void Mute_Music_Unchecked(object sender, RoutedEventArgs e)
        {
            if(Music_Slider.Value != MusicVolume)
            Music_Slider.Value = MusicVolume;
        }

        private void Music_Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (Mute_Music.IsChecked == false)
                MusicVolume = (sender as Slider).Value;
        }

        private void Mute_Effects_Unchecked(object sender, RoutedEventArgs e)
        {
            if(Music_Slider.Value != EffectsVolume)
                Effects_Slider.Value = EffectsVolume;

        }

        private void Mute_Effects_Checked(object sender, RoutedEventArgs e)
        {
            Effects_Slider.Value = 0;

        }

        private void Effects_Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (Mute_Effects.IsChecked == false)
                EffectsVolume = (sender as Slider).Value;
        }
    }
}
