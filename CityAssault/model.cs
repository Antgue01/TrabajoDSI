using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityAssault
{
    public class Tank
    {
        public enum Side { Ally, Enemy };

        public int Id { get; set; }
        public string Imagen { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int HP { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spe { get; set; }
        public int Mov { get; set; }
        public Side side {get;set;}
        public string Habilidad { get; set; }
        public Tank() { }

    }

    public class Pieza
    {
        public enum Type { Canon, Blindaje, Ruedas };

        public int Id { get; set; }
        public string Imagen { get; set; }
        public int HP { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spe { get; set; }
        public int Mov { get; set; }
        public Type Tipo { get; set; }
        public Pieza() { }
    }

    public class model
    {
        public static List<Tank> Tanks = new List<Tank>()
        {
            new Tank()
            {
                Id = 0,
                Imagen = "Assets\\Tank0.png",
                X = 47,
                Y = 175,
                HP = 50,
                Atk = 34,
                Def = 54,
                Spe = 32,
                Mov = 75,
                side=Tank.Side.Ally,
                Habilidad = "Rayo Gélido"
            },
            new Tank()
            {
                Id = 1,
                Imagen = "Assets\\Tank1.png",
                X = 306,
                Y = 0,
                HP = 100,
                Atk = 65,
                Def = 37,
                Spe = 98,
                Mov = 44,
                side=Tank.Side.Ally,
                Habilidad = "Bomba"
            },
            new Tank()
            {
                Id = 2,
                Imagen = "Assets\\Tank2.png",
                X = 373,
                Y = 187,
                HP = 43,
                Atk = 22,
                Def = 87,
                Spe = 60,
                Mov = 24,
                side=Tank.Side.Ally,
                Habilidad = "Terremoto"
            },
            new Tank()
            {
                Id = 3,
                Imagen = "Assets\\Tank3.png",
                X = 200,
                Y = 143,
                HP = 33,
                Atk = 74,
                Def = 49,
                Spe = 22,
                Mov = 75,
                side=Tank.Side.Ally,
                Habilidad = "Visión Nocturna"
            },
            new Tank()
            {
                Id = 4,
                Imagen = "Assets\\Tank0.png",
                X = 710,
                Y = 198,
                HP = 25,
                Atk = 66,
                Def = 12,
                Spe = 34,
                Mov = 90,
                side=Tank.Side.Enemy,
                Habilidad = "Rayo Gélido"
            },
            new Tank()
            {
                Id = 5,
                Imagen = "Assets\\Tank1.png",
                X = 685,
                Y = 68,
                HP = 21,
                Atk = 12,
                Def = 34,
                Spe = 43,
                Mov = 55,
                side=Tank.Side.Enemy,
                Habilidad = "Bomba"
            },
            new Tank()
            {
                Id = 6,
                Imagen = "Assets\\Tank2.png",
                X = 669,
                Y = 138,
                HP = 100,
                Atk = 86,
                Def = 34,
                Spe = 74,
                Mov = 23,
                side=Tank.Side.Enemy,
                Habilidad = "Terremoto"
            },
            new Tank()
            {
                Id = 7,
                Imagen = "Assets\\Tank3.png",
                X = 481,
                Y = 63,
                HP = 33,
                Atk = 86,
                Def = 12,
                Spe = 37,
                Mov = 94,
                side=Tank.Side.Enemy,
                Habilidad = "Visión Nocturna"
            }
        };

        public static List<Pieza> Piezas = new List<Pieza>()
        {
            new Pieza()
            {
                Id = 0,
                Imagen = "Assets\\Tank0.png",
                HP = 0,
                Atk = 0,
                Def = 0,
                Spe = 0,
                Mov = 0,
                Tipo = Pieza.Type.Canon
            }
        };


        public static IList<Tank> GetAllTanks()
        {
            return Tanks;
        }
        
        public static Tank GetTankById(int id)
        {
            return Tanks[id];
        }

        public static IList<Pieza> GetAllPiezas()
        {
            return Piezas;
        }

        public static Pieza GetPiezaById(int id)
        {
            return Piezas[id];
        }
    }
}
