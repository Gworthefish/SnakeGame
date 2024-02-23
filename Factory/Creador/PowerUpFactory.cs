using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.Factory.Producto;
namespace SnakeGame.Factory.Creador
{
    // Fábrica abstracta de power-ups
    public abstract class PowerUpFactory
    {
        public abstract IPowerUp CreatePowerUp(Point position);
    }

  
    public class SpeedPowerUpFactory : PowerUpFactory
    {
        public override IPowerUp CreatePowerUp(Point position)
        {
            return new SpeedPowerUp(position);
        }
    }

    // Fábrica concreta para power-ups de fuerza
    public class SlownesPowerUpFactory : PowerUpFactory
    {
        public override IPowerUp CreatePowerUp(Point position)
        {
            return new SlownesPowerUp(position);
        }
    }
}
