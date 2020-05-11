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
        public int Zoom;
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
        }
    }



}


