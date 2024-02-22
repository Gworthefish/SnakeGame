using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Factory
{
    public abstract class Juego
    {
        public abstract PowerUp CrearPowerUp();
        public void RenderizarPowerUp(PowerUp powerUp, int tamCelda, Graphics g)
        {
            // Aquí iría la lógica para renderizar el power-up.
            // Por ahora, solo vamos a simularlo con un mensaje en consola.


            
            using (SolidBrush brush = new SolidBrush(powerUp.Brushes))
            {
                g.FillRectangle(brush, powerUp.Point.X * tamCelda, powerUp.Point.Y * tamCelda, tamCelda, tamCelda);
            }
               


            Console.WriteLine($"Renderizando un power-up de tipo: {powerUp.GetType().Name} en la pantalla.");
        }
        public void GenerarPosicion(PowerUp powerUp,int anchoTablero, int alturaTablero, Random random)
        {

            
            powerUp.Point = new Point(random.Next(anchoTablero), random.Next(alturaTablero));
        }
       

    }
}
