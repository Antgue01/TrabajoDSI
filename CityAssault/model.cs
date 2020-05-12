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
        public Tank() { }

    }
    public class model
    {
        public static List<Tank> Tanks = new List<Tank>()
        {
            new Tank()
            {
                Id = 0,
                Imagen = "Assets\\Tank0.png",
                X = 10,
                Y = 20,
                HP = 50,
                Atk = 34,
                Def = 54,
                Spe = 32,
                Mov = 75,
                side=Tank.Side.Ally
            },
            new Tank()
            {
                Id = 1,
                Imagen = "Assets\\Tank1.png",
                X = 50,
                Y = 30,
                HP = 100,
                Atk = 65,
                Def = 37,
                Spe = 98,
                Mov = 44,
                side=Tank.Side.Ally

            },
            new Tank()
            {
                Id = 2,
                Imagen = "Assets\\Tank2.png",
                X = 100,
                Y = 76,
                HP = 43,
                Atk = 22,
                Def = 87,
                Spe = 60,
                Mov = 24,
                side=Tank.Side.Ally
                

            },
            new Tank()
            {
                Id = 3,
                Imagen = "Assets\\Tank3.png",
                X = 500,
                Y = 323,
                HP = 33,
                Atk = 74,
                Def = 49,
                Spe = 22,
                Mov = 75,
                side=Tank.Side.Ally

            },
            new Tank()
            {
                Id = 4,
                Imagen = "Assets\\Tank0.png",
                X = 56,
                Y = 76,
                HP = 25,
                Atk = 66,
                Def = 12,
                Spe = 34,
                Mov = 90,
                side=Tank.Side.Enemy
            },
            new Tank()
            {
                Id = 5,
                Imagen = "Assets\\Tank1.png",
                X = 304,
                Y = 304,
                HP = 21,
                Atk = 12,
                Def = 34,
                Spe = 43,
                Mov = 55,
                side=Tank.Side.Enemy
            },
            new Tank()
            {
                Id = 6,
                Imagen = "Assets\\Tank2.png",
                X = 105,
                Y = 303,
                HP = 100,
                Atk = 86,
                Def = 34,
                Spe = 74,
                Mov = 23,
                side=Tank.Side.Enemy
            },
            new Tank()
            {
                Id = 7,
                Imagen = "Assets\\Tank3.png",
                X = 130,
                Y = 100,
                HP = 33,
                Atk = 86,
                Def = 12,
                Spe = 37,
                Mov = 94,
                side=Tank.Side.Enemy
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
    }
}
