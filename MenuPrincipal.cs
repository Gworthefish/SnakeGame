using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde el menú principal.
            Form1 juego = new Form1();
            juego.FormClosed += (s, args) => this.Close(); // Cerrar el menú principal cuando se cierre el juego.
            juego.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
