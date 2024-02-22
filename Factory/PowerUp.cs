using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public abstract class PowerUp
    {
        

        public Point Point { get; set; }
        public  Color Brushes { get; set; }
        protected PowerUp(Color Brushes)
        {
            this.Brushes = Brushes;
        }

       

        public abstract void AplicarEfecto();

       



    }
}
