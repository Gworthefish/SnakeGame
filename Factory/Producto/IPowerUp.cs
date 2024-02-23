using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame.Factory.Producto
{
    
    public interface IPowerUp
    {
        void ApplyEffect(Serpiente player); 
        void Render(Graphics g);         
    }

    public class SpeedPowerUp : IPowerUp
    {
        public Point Position { get; set; }
        public Color Color { get; set; } = Color.Blue;

        public SpeedPowerUp(Point position)
        {
            Position = position;
        }

        public void ApplyEffect(Serpiente player)
        {
            player.Speed = 200;
           
        }

        public void Render(Graphics g)
        {

            g.FillRectangle(new SolidBrush(Color), Position.X * 20, Position.Y * 20, 20, 20);
        }
    }



    public class SlownesPowerUp : IPowerUp
    {
        public Point Position { get; set; }
        public Color Color { get; set; } = Color.Purple;

        public SlownesPowerUp(Point position)
        {
            Position = position;
        }

        public void ApplyEffect(Serpiente player)
        {
            player.Speed = 600; 
        }

        public void Render(Graphics g)
        {
            
            g.FillRectangle(new SolidBrush(Color), Position.X*20, Position.Y*20, 20, 20);
            
        }
    }

    public class ShortPowerUp : IPowerUp
    {
        public Point Position { get; set; }
        public Color Color { get; set; } = Color.Yellow;

        public ShortPowerUp(Point position)
        {
            Position = position;
        }

        public void ApplyEffect(Serpiente serpiente)
        {
            serpiente.Count = -1;
        }

        public void Render(Graphics g)
        {

            g.FillRectangle(new SolidBrush(Color), Position.X * 20, Position.Y * 20, 20, 20);

        }
    }

}
