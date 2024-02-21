using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class PowerUp
    {

        Point Point { get; set; }
        Brushes Brushes { get; set; }

        public void generarTipoPowerUP()
        {
            Random random = new Random();
            int valor =random.Next(0,3);
            switch (valor)
            {
                case 0:
                    FastPower();
                    break;

                case 1:
                    SlowPower();
                    break; 

                case 2:
                    AntiLargePower();
                    break;

                default:
                    break;
            }


        }
        public void FastPower() { }
        public void SlowPower() { }

        public void AntiLargePower() { }

    }
}
