using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Serpiente
    {
        private Color color;
        public int Speed { get; set; } = 400;
        public int Slownes { get; set; }
        public int Count { get; set; }

        // Constructor que establece el color inicial de la serpiente
        public Serpiente(Color colorInicial)
        {
            color = colorInicial;
        }

        // Propiedad pública para acceder y modificar el color de la serpiente
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }




    }
}
