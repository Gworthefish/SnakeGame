using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Factory.Productos_concretos
{
    public class Lentitud : PowerUp
    {
        public Lentitud() : base(Color.Blue) // Asigna el color azul a los power-ups de velocidad
        {
        }
        public override void AplicarEfecto()
        {
            Console.WriteLine("La Lentitud de la serpiente ha aumentado.");
        }
    }
}
