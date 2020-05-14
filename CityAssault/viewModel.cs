using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace CityAssault
{
    public class VMTank : Tank
    {
        public Image Img;
        public ContentControl CCImg;
        public ContentControl HPBarControl;
        public VMTank(Tank tank)
        {
            Id = tank.Id;
            Imagen = tank.Imagen;
            X = tank.X;
            Y = tank.Y;
            HP = tank.HP;
            Atk = tank.Atk;
            Def = tank.Def;
            Spe = tank.Spe;
            Mov = tank.Mov;
            side = tank.side;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + tank.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg.UseSystemFocusVisuals = true;
            CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;
            HPBarControl = new ContentControl();
            HPBarControl.Content = new ProgressBar();
            (HPBarControl.Content as ProgressBar).Value = 100;
            HPBarControl.UseSystemFocusVisuals = false;
            HPBarControl.Visibility = Windows.UI.Xaml.Visibility.Visible;
            HPBarControl.IsEnabled = true;
        }
    }
    public class VMission : Mission
    {
        public VMission(Mission mis)
        {
            Id = mis.Id;
            Imagen = mis.Imagen;
            Descripcion = mis.Descripcion;
            side = mis.side;
        }
        public VMission() { }
    }


}


