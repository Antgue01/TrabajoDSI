﻿using System;
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
    public sealed partial class Garage : Page
    {
        public ObservableCollection<VMTank> ListaTanques { get; } = new ObservableCollection<VMTank>();
        public ObservableCollection<VMPieza> ListaPiezas { get; } = new ObservableCollection<VMPieza>();
        public ObservableCollection<VMPieza> ListaCanon { get; } = new ObservableCollection<VMPieza>();
        public ObservableCollection<VMPieza> ListaBlindaje { get; } = new ObservableCollection<VMPieza>();
        public ObservableCollection<VMPieza> ListaRuedas { get; } = new ObservableCollection<VMPieza>();

        private VMTank selectedTank;
        private VMPieza selectedPieza;
        private VMPieza nullPieza;
        private List<VMTank> team = new List<VMTank>();
        private int vit, atk, def, vel, mov;

        public Garage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(Height = 432, Width = 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

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

            if (ListaTanques != null)
                foreach (Tank tank in model.GetAllTanks())
                {
                    VMTank VMitem = new VMTank(tank);
                    ListaTanques.Add(VMitem);
                }

            if (ListaPiezas != null)
                foreach (Pieza pieza in model.GetAllPiezas())
                {
                    VMPieza VMitem = new VMPieza(pieza);
                    ListaPiezas.Add(VMitem);
                }

            if (ListaCanon != null)
                foreach (Pieza pieza in model.GetAllPiezas())
                {
                    VMPieza VMitem = new VMPieza(pieza);

                    if (VMitem.Tipo == Pieza.Type.Null)
                        nullPieza = VMitem;

                    if (VMitem.Tipo == Pieza.Type.Canon)
                        ListaCanon.Add(VMitem);
                }

            if (ListaBlindaje != null)
                foreach (Pieza pieza in model.GetAllPiezas())
                {
                    VMPieza VMitem = new VMPieza(pieza);
                    if (VMitem.Tipo == Pieza.Type.Blindaje)
                        ListaBlindaje.Add(VMitem);
                }

            if (ListaRuedas != null)
                foreach (Pieza pieza in model.GetAllPiezas())
                {
                    VMPieza VMitem = new VMPieza(pieza);
                    if (VMitem.Tipo == Pieza.Type.Ruedas)
                        ListaRuedas.Add(VMitem);
                }

            selectedPieza = nullPieza;

            for (int i = 0; i < 4; ++i)
            {
               team.Add(ListaTanques[i]);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BackButton.IsEnabled = this.Frame.CanGoBack;

            if (e.Parameter != null && e.Parameter is int) {
                selectedTank = ListaTanques[(int)e.Parameter];
            }
            else
            {
                selectedTank = ListaTanques[0];
            }
            base.OnNavigatedTo(e);

            vit = selectedTank.HP;
            atk = selectedTank.Atk;
            def = selectedTank.Def;
            vel = selectedTank.Spe;
            mov = selectedTank.Mov;

            CanonButton.IsChecked = true;
            Habilidad.Text = selectedTank.Habilidad;
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

        private void BackInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //?
        }

        private void CanonButton_Checked(object sender, RoutedEventArgs e)
        {
            BlindajeButton.IsChecked = false;
            RuedasButton.IsChecked = false;

            PiezasList.ItemsSource = ListaCanon;
        }

        private void BlindajeButton_Checked(object sender, RoutedEventArgs e)
        {
            CanonButton.IsChecked = false;
            RuedasButton.IsChecked = false;

            PiezasList.ItemsSource = ListaBlindaje;
        }        

        private void RuedasButton_Checked(object sender, RoutedEventArgs e)
        {
            BlindajeButton.IsChecked = false;
            CanonButton.IsChecked = false;

            PiezasList.ItemsSource = ListaRuedas;
        }

        private void ArrowRight_Click(object sender, RoutedEventArgs e)
        {
            selectedTank = team[(team.IndexOf(selectedTank)+1) % 4];
            TanqueImagen.Source = selectedTank.Img.Source;

            VitBar.Value = selectedTank.HP + selectedPieza.HP;
            AtkBar.Value = selectedTank.Atk + selectedPieza.Atk;
            DefBar.Value = selectedTank.Def + selectedPieza.Def;
            VelBar.Value = selectedTank.Spe + selectedPieza.Spe;
            MovBar.Value = selectedTank.Mov + selectedPieza.Mov;
            Habilidad.Text = selectedTank.Habilidad;
        }

        private void ArrowLeft_Click(object sender, RoutedEventArgs e)
        {
            selectedTank = team[(team.IndexOf(selectedTank) + 3) % 4];
            TanqueImagen.Source = selectedTank.Img.Source;

            VitBar.Value = selectedTank.HP + selectedPieza.HP;
            AtkBar.Value = selectedTank.Atk + selectedPieza.Atk;
            DefBar.Value = selectedTank.Def + selectedPieza.Def;
            VelBar.Value = selectedTank.Spe + selectedPieza.Spe;
            MovBar.Value = selectedTank.Mov + selectedPieza.Mov;
            Habilidad.Text = selectedTank.Habilidad;
        }

        private void SavedList_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMTank tank = e.ClickedItem as VMTank;

            int aux = selectedTank.Id;

            if (aux != tank.Id)
            {
                selectedTank = ListaTanques[tank.Id];
                TanqueImagen.Source = selectedTank.Img.Source;

                VitBar.Value = selectedTank.HP + selectedPieza.HP;
                AtkBar.Value = selectedTank.Atk + selectedPieza.Atk;
                DefBar.Value = selectedTank.Def + selectedPieza.Def;
                VelBar.Value = selectedTank.Spe + selectedPieza.Spe;
                MovBar.Value = selectedTank.Mov + selectedPieza.Mov;
                Habilidad.Text = selectedTank.Habilidad;

                int i = 0;
                while (team[i].Id != aux)
                    ++i;

                team[i] = tank;
            }
        }

        private void PiezasList_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMPieza pieza = e.ClickedItem as VMPieza;

            if (pieza != null)
            {
                selectedPieza = ListaPiezas[pieza.Id];

                VitBar.Value = selectedTank.HP + selectedPieza.HP;
                AtkBar.Value = selectedTank.Atk + selectedPieza.Atk;
                DefBar.Value = selectedTank.Def + selectedPieza.Def;
                VelBar.Value = selectedTank.Spe + selectedPieza.Spe;
                MovBar.Value = selectedTank.Mov + selectedPieza.Mov;
            }
        }
    }
}
