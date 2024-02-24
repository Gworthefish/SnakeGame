using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
       
        [STAThread]
       
        static void Main()
        {
            Serpiente s= new Serpiente(Color.Green);
            Serpiente s2 = new Serpiente(Color.Green);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal(s,s2));
        }
    }
}
