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
    public partial class PersonalizacionSerpient : Form
    {
        private PictureBox pictureBox;
        private PictureBox pictureBox2;
        private const int tamCelda = 50;
        private const int anchoTablero = 1;
        private const int alturaTablero = 4;
        Serpiente snake;
        Serpiente snake2;
        public PersonalizacionSerpient(Serpiente snake , Serpiente snake2)
        {
            InitializeComponent();
            this.snake=snake;
            this.snake2=snake2;

        }

        private void PersonalizacionSerpient_Load(object sender, EventArgs e)
        {
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(anchoTablero * tamCelda, alturaTablero * tamCelda);
            pictureBox.Location = new Point(90, 70);
            pictureBox.BackColor = snake.Color;
            pictureBox.Paint += PintarJuego;
            Controls.Add(pictureBox);



            pictureBox2 = new PictureBox();
            pictureBox2.Size = new Size(anchoTablero * tamCelda, alturaTablero * tamCelda);
            pictureBox2.Location = new Point(350, 70);
            pictureBox2.BackColor = snake.Color;
            pictureBox2.Paint += PintarJuego;
            Controls.Add(pictureBox2);
        }
        private void PintarJuego(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

          
            for (int x = 0; x < anchoTablero; x++)
            {
                for (int y = 0; y < alturaTablero; y++)
                {
                    g.DrawRectangle(Pens.White, x * tamCelda, y * tamCelda, tamCelda, tamCelda);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {

                snake.Color = colorDialog1.Color;
            }
            pictureBox.BackColor = snake.Color;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal juego = new MenuPrincipal(snake,snake2);
            juego.FormClosed += (s, args) => this.Close();
            juego.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {

                snake2.Color = colorDialog2.Color;
            }
            pictureBox2.BackColor = snake2.Color;
        }
    }
}
