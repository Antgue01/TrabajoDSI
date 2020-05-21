using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace CityAssault
{
    public class VMTank : Tank
    {
        public Image Img;
        public ContentControl CCImg;
        public StackPanel panel;
        public ProgressBar pb;
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
            Habilidad = tank.Habilidad;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + tank.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg.UseSystemFocusVisuals = true;
            CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;
            panel = new StackPanel();
            pb = new ProgressBar();
            pb.Value = tank.HP;
            Windows.UI.Color col = new Windows.UI.Color();
            col.B = 0x00;
            col.A = 0xff;
            if (tank.side == Side.Ally)
            {
                col.R = 0x00;
                col.G = 0xff;
            }else
            {
                col.R = 0xff;
                col.G = 0x00;
            }   
            Windows.UI.Color colbg = new Windows.UI.Color();
            colbg.R = 0xff;
            colbg.G = 0xff;
            colbg.B = 0xff;
            colbg.A = 0xaa;
            pb.Foreground = new SolidColorBrush(col);
            pb.Background = new SolidColorBrush(colbg);
            panel.Children.Add(pb);
            panel.Children.Add(CCImg);



        }
    }

    public class VMPieza : Pieza
    {
        public Image Img;
        public VMPieza(Pieza pieza)
        {
            Id = pieza.Id;
            Imagen = pieza.Imagen;
            HP = pieza.HP;
            Atk = pieza.Atk;
            Def = pieza.Def;
            Spe = pieza.Spe;
            Mov = pieza.Mov;
            Tipo = pieza.Tipo;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + pieza.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
        }
    }

    public class VMission : Mission
    {
        public VMission(Mission mis)
        {
            Id = mis.Id;
            Imagen = mis.Imagen;
            DescripcionEsp = mis.DescripcionEsp;
            DescripcionEn = mis.DescripcionEn;
            DescripcionJa = mis.DescripcionJa;
            side = mis.side;
        }
        public VMission() { }
    }
}