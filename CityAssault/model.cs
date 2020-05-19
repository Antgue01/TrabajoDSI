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
        public enum Type { Null, Canon, Blindaje, Ruedas };

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

    public class Mission
    {
        public enum State { Unlock, Lock };

        public int Id { get; set; }
        public string Imagen { get; set; }
        public int Dificultad { get; set; }     //0 facil, 1 medio, 2 dificil
        public string DescripcionEsp { get; set; }
        public string DescripcionEn { get; set; }
        public string DescripcionJa { get; set; }
        public State side { get; set; }
        public Mission() { }

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
                Habilidad = "Ice Beam"
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
                Habilidad = "Bomb"
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
                Habilidad = "Earthquake"
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
                Habilidad = "Night Vision"
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
                Habilidad = "Ice Beam"
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
                Habilidad = "Bomb"
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
                Habilidad = "Earthquake"
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
                Habilidad = "Night Vision"
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
                Tipo = Pieza.Type.Null
            },

            new Pieza()
            {
                Id = 1,
                Imagen = "Assets\\canon1.png",
                HP = 0,
                Atk = 10,
                Def = 0,
                Spe = 0,
                Mov = 0,
                Tipo = Pieza.Type.Canon
            },

            new Pieza()
            {
                Id = 2,
                Imagen = "Assets\\canon2.png",
                HP = 2,
                Atk = 14,
                Def = 0,
                Spe = 0,
                Mov = 0,
                Tipo = Pieza.Type.Canon
            },

            new Pieza()
            {
                Id = 3,
                Imagen = "Assets\\canon3.png",
                HP = -10,
                Atk = 20,
                Def = 0,
                Spe = 0,
                Mov = 0,
                Tipo = Pieza.Type.Canon
            },

            new Pieza()
            {
                Id = 4,
                Imagen = "Assets\\blindaje1.png",
                HP = 0,
                Atk = 0,
                Def = 16,
                Spe = -3,
                Mov = 0,
                Tipo = Pieza.Type.Blindaje
            },

            new Pieza()
            {
                Id = 5,
                Imagen = "Assets\\blindaje2.png",
                HP = 0,
                Atk = 0,
                Def = 8,
                Spe = 0,
                Mov = 0,
                Tipo = Pieza.Type.Blindaje
            },

            new Pieza()
            {
                Id = 6,
                Imagen = "Assets\\blindaje3.png",
                HP = 0,
                Atk = 0,
                Def = 20,
                Spe = -10,
                Mov = 0,
                Tipo = Pieza.Type.Blindaje
            },

            new Pieza()
            {
                Id = 7,
                Imagen = "Assets\\ruedas1.png",
                HP = 0,
                Atk = 0,
                Def = 0,
                Spe = 10,
                Mov = 10,
                Tipo = Pieza.Type.Ruedas
            },

            new Pieza()
            {
                Id = 8,
                Imagen = "Assets\\ruedas2.png",
                HP = 0,
                Atk = 0,
                Def = 0,
                Spe = 10,
                Mov = 5,
                Tipo = Pieza.Type.Ruedas
            },

            new Pieza()
            {
                Id = 9,
                Imagen = "Assets\\ruedas3.png",
                HP = 0,
                Atk = 0,
                Def = 0,
                Spe = 13,
                Mov = 8,
                Tipo = Pieza.Type.Ruedas
            },

            new Pieza()
            {
                Id = 10,
                Imagen = "Assets\\ruedas4.png",
                HP = 0,
                Atk = 0,
                Def = 0,
                Spe = 5,
                Mov = 13,
                Tipo = Pieza.Type.Ruedas
            }
        };

        public static List<Mission> Misiones = new List<Mission>()
        {
            new Mission()
            {
                Id = 0,
                Imagen = "Assets\\M1.png",
                Dificultad = 0,
                DescripcionEsp = "Deberás de capturar la bandera de los enemigos en un límite de tiempo de 2 minutos.",
                DescripcionEn="You must capture the enemy flag within the 2 minutes time limit.",
                DescripcionJa="二分で敵の旗を捉えろ",
                side=Mission.State.Unlock
            },
            new Mission()
            {
                Id = 0,
                Imagen = "Assets\\M2.png",
                Dificultad = 0,
                DescripcionEsp = "Deberás de eliminar a todos los enemigos en un limite de 10 turnos. Contarás con mas vida de la habitual.",
                DescripcionEn="You must destroy all enemy tanks within the 10 turn limit. You'll have more life points than usual.",
                DescripcionJa="十ターンで全ての敵戦車を全滅しろ。普段よりもっとHPがあります",
                side=Mission.State.Unlock
            },
            new Mission()
            {
                Id = 1,
                Imagen = "Assets\\M3.png",
                Dificultad = 1,
                DescripcionEsp = "Deberas de eliminar a los tanques enemigos desde la distancia usando los disparos de mortero.",
                DescripcionEn="You must destroy all enemy tanks from the distance using the mortar.",
                DescripcionJa="迫撃砲で遠い場所から全ての敵戦車を全滅しろ",
                side=Mission.State.Unlock
            },
            new Mission()
            {
                Id = 2,
                Imagen = "Assets\\M4.png",
                Dificultad = 1,
                DescripcionEsp = "Deberás de incapacitar a 3 tanques enemigos a la vez usando un ataque especial en área.",
                DescripcionEn="You'll have to incapacitate 3 enemy tanks at a time using an area special attack.",
                DescripcionJa="エリア超攻撃で三つの敵戦車を全滅しろ",
                side=Mission.State.Unlock
            },
            new Mission()
            {
                Id = 3,
                Imagen = "Assets\\M5.png",
                Dificultad = 2,
                DescripcionEsp = "Debes derrotar al general de las fuerzas enemigas en un combate cara a cara. No hay restricciones. Usa tu mejor armamento",
                DescripcionEn="You have to defeat the general's forces in a face to face battle. No restriction. Use your best weaponry.",
                DescripcionJa="真剣勝負に全ての将軍の兵を撃て。制限がない。出来るほどの力を使うが良い。",
                side=Mission.State.Unlock
            },
            new Mission()
            {
                Id = 4,
                Imagen = "Assets\\Lock.png",
                Dificultad = 1,
                DescripcionEsp = "Misión no desbloqueada",
                DescripcionEn ="Locked Mission",
                DescripcionJa="ロックされた任務。",
                side=Mission.State.Lock
            },
            new Mission()
            {
                Id = 5,
                Imagen = "Assets\\Lock.png",
                Dificultad = 0,
                DescripcionEsp = "Misión no desbloqueada",
                DescripcionEn ="Locked Mission",
                DescripcionJa="ロックされた任務。",
                side=Mission.State.Lock
            },
            new Mission()
            {
                Id = 6,
                Imagen = "Assets\\Lock.png",
                Dificultad = 1,
                DescripcionEsp = "Misión no desbloqueada",
                DescripcionEn ="Locked Mission",
                DescripcionJa="ロックされた任務。",
                side=Mission.State.Lock
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

        public static IList<Mission> GetAllMissions()
        {
            return Misiones;
        }

        public static Mission GetMissionById(int id)
        {
            return Misiones[id];
        }
    }
}
