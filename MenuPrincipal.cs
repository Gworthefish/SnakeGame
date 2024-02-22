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

        public Serpiente snake;

        public MenuPrincipal(Serpiente snake)
        {
            InitializeComponent();
            this.snake = snake;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 juego = new Form1(snake);
            juego.FormClosed += (s, args) => this.Close(); 
            juego.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalizacionSerpient juego = new PersonalizacionSerpient(snake);
            juego.FormClosed += (s, args) => this.Close();
            juego.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
         
        }
       

        private void br_Click(object sender, EventArgs e)
        {

        }
    }
}
