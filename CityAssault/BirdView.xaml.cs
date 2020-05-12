using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace CityAssault
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>

    public sealed partial class BirdView : Page
    {

        public ObservableCollection<VMTank> ListaTanques { get; } = new ObservableCollection<VMTank>();
        private List<ContentControl> contentControls = new List<ContentControl>(8);
        private List<ProgressBar> progressBars = new List<ProgressBar>(8);
        private VMTank selectedTank;
       


        public BirdView()
        {

            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            if (ListaTanques != null)
                foreach (Tank tank in model.GetAllTanks())
                {
                    VMTank VMitem = new VMTank(tank);
                    ListaTanques.Add(VMitem);
                }
            for (int i = 0; i < progressBars.Capacity; i++)
            {
                ProgressBar pb = new ProgressBar();
                pb.IsIndeterminate = false;
                pb.Value = ListaTanques[i].HP;
                
                pb.Width = 6000;
                pb.Height = 100;
                Rect r;
                r.X = ListaTanques[i].X;
                r.Y = ListaTanques[i].Y;
                r.Height= 100;
                r.Width= 6000;
                pb.Arrange(r);
                pb.Opacity = 100;
                pb.Measure(new Size(6000, 100));
                Canvas.SetLeft(pb, ListaTanques[i].X);
                Canvas.SetTop(pb, ListaTanques[i].Y);
                pb.StartBringIntoView();
                pb.Visibility = Visibility.Visible;
                pb.IsEnabled = true;
                progressBars.Add(pb);

            }
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            for (int i = 0; i < contentControls.Capacity; i++)
            {
                Image img = new Image();
                img.Width = 60;
                img.Height = 60;
                img.Source = ListaTanques[i].Img.Source;
                canvasTanques.Children.Add(ListaTanques[i].CCImg);
                ListaTanques[i].CCImg.PointerPressed += SelectTank;
                contentControls.Add(ListaTanques[i].CCImg);
                ListaTanques[i].Img.CenterPoint = new System.Numerics.Vector3(.5f, .5f, .5f);
                if (ListaTanques[i].side == Tank.Side.Enemy)
                {

                    ListaTanques[i].Img.Scale = new System.Numerics.Vector3(ListaTanques[i].Img.Scale.X * -1
                        , ListaTanques[i].Img.Scale.Y, ListaTanques[i].Img.Scale.Z);
                }
                progressBars[i].Translation = new System.Numerics.Vector3(ListaTanques[i].X, ListaTanques[i].Y - 30, 0);
                Canvas.SetTop(contentControls[i], ListaTanques[i].Y);
                Canvas.SetLeft(contentControls[i], ListaTanques[i].X);
            }
            selectedTank = ListaTanques[0];
        }

        private void SelectTank(object sender, PointerRoutedEventArgs e)
        {
            VMTank s = ListaTanques[contentControls.IndexOf(sender as ContentControl)];
            selectedTank = s;
            AtkBar.Value = s.Atk;
            DefBar.Value = s.Def;
            SpeBar.Value = s.Spe;
            MovBar.Value = s.Mov;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Stats_Viewer.Visibility = Visibility.Collapsed;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Stats_Viewer.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BattleView));
        }

        private void GoToMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void Move(object sender, PointerRoutedEventArgs e)
        {
            if (selectedTank.side == Tank.Side.Ally)
                Canvas.SetLeft(contentControls[selectedTank.Id], e.GetCurrentPoint(sender as Image).Position.X - selectedTank.Img.ActualWidth / 2);
            else
                Canvas.SetLeft(contentControls[selectedTank.Id], e.GetCurrentPoint(sender as Image).Position.X + selectedTank.Img.ActualWidth / 2);

            Canvas.SetTop(contentControls[selectedTank.Id], e.GetCurrentPoint(sender as Image).Position.Y - 2 * selectedTank.Img.ActualHeight);

        }
    }
}
