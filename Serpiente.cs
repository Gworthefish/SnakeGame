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
