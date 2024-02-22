using SnakeGame.Factory.Productos_concretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Factory.Creadores_concretos
{
    public class JuegoLentitud : Juego
    {
        public override PowerUp CrearPowerUp()
        {
            return new Lentitud();
        }
    }
}
