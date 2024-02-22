using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Factory.Productos_concretos
{
    public class Velocidad : PowerUp
    {

        public Velocidad() : base(Color.Pink) // Asigna el color azul a los power-ups de velocidad
        {
        }
        public override void AplicarEfecto()
        {
            Console.WriteLine("La velocidad del jugador ha aumentado.");
        }
    }

}
