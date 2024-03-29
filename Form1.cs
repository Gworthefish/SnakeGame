﻿
using SnakeGame.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeGame.Factory.Creador;
using System.Runtime.CompilerServices;
using SnakeGame.Factory.Producto;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        #region Variables 
        /// <summary>
        /// Define las constantes y variables utilizadas en el juego de Snake.
        /// - tamCelda: El tamaño en píxeles de cada celda en el tablero.
        /// - anchoTablero: El número de celdas a lo ancho del tablero.
        /// - alturaTablero: El número de celdas de altura del tablero.
        /// - tamInicialSerpiente: El tamaño inicial de la serpiente al inicio del juego.
        /// - pictureBox: El control PictureBox utilizado para mostrar el juego en la interfaz de usuario.
        /// - serpiente: Una lista que almacena las posiciones de los segmentos de la serpiente en el tablero.
        /// - comidita: La posición de la comida en el tablero.
        /// - direccion: La dirección actual de movimiento de la serpiente.
        /// - hiloJuego: El hilo utilizado para ejecutar el bucle principal del juego.
        /// - jugando: Indica si el juego está en curso.
        /// - Direction: Enumerado que define las direcciones posibles de movimiento de la serpiente (arriba, abajo, izquierda, derecha).
        /// </summary>
        private const int tamCelda = 20;
        private const int anchoTablero = 20;
        private const int alturaTablero = 20;
        private const int tamInicialSerpiente = 3;

        private int nivel = 0;
        private int puntos = 0;


        private PictureBox pictureBox;
        private PictureBox pictureBox2;
        private List<Point> serpiente;
        private List<Point> serpiente2;
        private Point comidita;
        private Point positionAux;
        private Direction direccion;
        private Direction direccionJugador2;
        private Thread hiloJuego;
        private bool jugando;
        IPowerUp powerUpAux;
        Random random;
    
        private enum Direction { Up, Down, Left, Right }
        Serpiente snake;
        Serpiente snake2;
        private int velocidadSerpiente = 300;
        #endregion
        public Form1(Serpiente snake, Serpiente snake2)
        {
            InitializeComponent();
            this.snake = snake;
            Jugar();
            this.snake2 = snake2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Inicia el juego de Snake.
        /// Crea una nueva instancia del juego con las configuraciones iniciales, como la dirección, la posición de la serpiente y la generación de comida.
        /// También crea un nuevo PictureBox para visualizar el juego en la interfaz de usuario y comienza un nuevo hilo para ejecutar el bucle principal del juego.
        /// </summary>
        private void Jugar()
        {
            jugando = true;
            direccion = Direction.Right;
            serpiente = new List<Point>();
            serpiente.Add(new Point(anchoTablero / 2, alturaTablero / 2));

            direccionJugador2 = Direction.Right;
            serpiente2 = new List<Point>();
            serpiente2.Add(new Point(anchoTablero / 2-2, alturaTablero / 2-2));


            random = new Random();
            GenerarComidita(random);// metodo random para generar la posion

            PowerUpFactory factory = new SlownesPowerUpFactory();
            Point position = GetRandomGridPosition();
            IPowerUp powerUp = factory.CreatePowerUp(position);
            
          
            powerUpAux = powerUp;
            positionAux = position;

         
       

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(anchoTablero * tamCelda, alturaTablero * tamCelda);
            pictureBox.Location = new Point(0, 10);
            pictureBox.BackColor = Color.Black; 
            pictureBox.Paint += PintarJuego;
            Controls.Add(pictureBox);



         

            hiloJuego = new Thread(BucleJuego);
            hiloJuego.Start();

          

        }
       

        /// <summary>
        /// Manejador de eventos para dibujar la serpiente y la comida en un control gráfico.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento Paint que contienen información sobre cómo dibujar.</param>
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
            DibujarSerpiente(g);
            DibujarSerpiente2(g);
            

            DibujarComidita(g);
            powerUpAux.Render(e.Graphics);
        }

        /// <summary>
        /// Dibuja la serpiente en el tablero de juego utilizando el objeto Graphics especificado.
        /// Itera a través de cada segmento de la serpiente y dibuja un rectángulo verde en la posición correspondiente en el tablero de juego.
        /// Cada segmento de la serpiente se representa como un rectángulo de tamaño igual al tamaño de una celda en el tablero.
        /// </summary>
        /// <param name="g">El objeto Graphics utilizado para dibujar en el tablero de juego.</param>

        private void DibujarSerpiente(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(snake.Color))
            {
                foreach (Point segment in serpiente)
                {
                    g.FillRectangle(brush, segment.X * tamCelda, segment.Y * tamCelda, tamCelda, tamCelda);
                }
            }
            
        }
        private void DibujarSerpiente2(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color.Pink))
            {
                foreach (Point segment in serpiente2)
                {
                    g.FillRectangle(brush, segment.X * tamCelda, segment.Y * tamCelda, tamCelda, tamCelda);
                }
            }

        }

        /// <summary>
        /// Dibuja la comida en el tablero de juego utilizando el objeto Graphics especificado.
        /// Dibuja un rectángulo rojo en la posición de la comida en el tablero de juego.
        /// La posición de la comida se especifica por la coordenada (X, Y) de la variable comidita, multiplicada por el tamaño de una celda en el tablero.
        /// </summary>
        /// <param name="g">El objeto Graphics utilizado para dibujar en el tablero de juego.</param>

        private void DibujarComidita(Graphics g)
        {
            g.FillRectangle(Brushes.Red, comidita.X * tamCelda, comidita.Y * tamCelda, tamCelda, tamCelda);
        }

        /// <summary>
        /// Genera la posición aleatoria de la comida en el tablero de juego.
        /// Utiliza un objeto Random para generar coordenadas aleatorias dentro del rango del tablero de juego.
        /// La posición de la comida se establece en una nueva coordenada (X, Y) generada aleatoriamente.
        /// </summary>
        private void GenerarComidita(Random random)
        {
            nivel++;
            puntos += 100;
            Console.WriteLine(nivel);
            
            comidita = new Point(random.Next(anchoTablero), random.Next(alturaTablero));
        }

       
        /// <summary>
        /// Controla el bucle principal del juego de Snake.
        /// Mueve la serpiente, verifica si ha ocurrido alguna colisión y actualiza la visualización del juego en el PictureBox.
        /// El bucle se ejecuta mientras el juego esté en curso (jugando = true).
        /// </summary>
        private void BucleJuego()
        {
           
            while (jugando)
            {
                MoverSerpiente(serpiente, direccion,snake);
                MoverSerpiente(serpiente2, direccionJugador2, snake2);

                revisarChoque(serpiente, serpiente2); 
                revisarChoque(serpiente2, serpiente); 
                puntos += 5;
                pictureBox.Invalidate();
               

                Thread.Sleep(snake.Speed); 

                
                ActualizarText(textVelocidad,"" + snake.Speed);
                ActualizarText(textTamSerpi, "" + serpiente.Count);

                ActualizarText(textTamSerpi2, "" + serpiente2.Count);
                ActualizarText(textVelocidad2, "" + snake2.Speed);

                ActualizarText(textNivel, "" + nivel);
                ActualizarText(textPuntos, "" + puntos);
            }
        }
        private void ActualizarText(Label label,string texto)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action<Label,string>(ActualizarText),label, texto);
            }
            else
            {
                label.Text = texto;
            }
        }

        /// <summary>
        /// Mueve la serpiente en el tablero de juego según la dirección actual.
        /// Calcula la nueva posición de la cabeza de la serpiente basada en la dirección actual.
        /// Inserta la nueva posición de la cabeza en la lista de segmentos de la serpiente y elimina el último segmento si la serpiente no ha comido la comida.
        /// Genera una nueva posición para la comida si la cabeza de la serpiente alcanza la comida.
        /// </summary>

        private void MoverSerpiente(List<Point> serpienteActual, Direction direccionActual, Serpiente snake)
        {
            Point cabeza = serpienteActual[0];
            Point nuevaCabeza = new Point(cabeza.X, cabeza.Y);

            switch (direccionActual)
            {
                case Direction.Up:
                    
                    nuevaCabeza.Y--;
                    break;
                case Direction.Down:
                    nuevaCabeza.Y++;
                    break;
                case Direction.Left:
                    nuevaCabeza.X--;
                    break;
                case Direction.Right:
                    nuevaCabeza.X++;
                    break;
            }

            serpienteActual.Insert(0, nuevaCabeza);
            if (SerpienteTocoPowerUp(serpiente[0], positionAux)|| SerpienteTocoPowerUp(serpiente2[0], positionAux))
            {
                powerUpAux.ApplyEffect(snake);
                if (snake.Count == -1 && serpiente.Count > 1)
                {
                    serpiente.RemoveAt(serpiente.Count - 2);
                    snake.Count = 0;
                }
              
                PowerUpFactory factory;

                int powerUpType = random.Next(3); 

                switch (powerUpType)
                {
                    case 0:
                        factory = new SpeedPowerUpFactory();
                        break;
                    case 1:
                        factory = new SlownesPowerUpFactory();
                        break;
                    case 2:
                        factory = new ShortPowerUpFactory(); 
                        break;
                    default:
                        
                        factory = null;
                        break;
                }

                Point position = GetRandomGridPosition();
                IPowerUp powerUp = factory.CreatePowerUp(position);
                powerUpAux=powerUp;
                positionAux = position;
                




            }
            if (nuevaCabeza != comidita)
            {
                serpienteActual.RemoveAt(serpienteActual.Count - 1);

            }
            else
            {
               
                GenerarComidita(random);
                

            }
           
        }
        private Point GetRandomGridPosition()
        {
            Point po;

            po = new Point(random.Next(anchoTablero), random.Next(alturaTablero));

            return po;
        }

        private bool SerpienteTocoPowerUp(Point cabeza, Point powerUp)
        {
          
            return cabeza.X == powerUp.X && cabeza.Y == powerUp.Y;
        }
        /// <summary>
        /// Verifica si ha ocurrido una colisión de la cabeza de la serpiente con las paredes del tablero o con el cuerpo de la serpiente.
        /// Si la cabeza de la serpiente está fuera del tablero o choca con su propio cuerpo, finaliza el juego y muestra un mensaje de pérdida.
        /// </summary>

        private void revisarChoque(List<Point> serpienteActual, List<Point> otraSerpiente)
        {
            Point cabeza = serpienteActual[0];

            // Verifica colisión con los bordes del tablero
            if (cabeza.X < 0 || cabeza.X >= anchoTablero || cabeza.Y < 0 || cabeza.Y >= alturaTablero)
            {
                jugando = false;
                MessageBox.Show("¡Perdiste! La serpiente chocó con el borde.");
                return;
            }

            // Verifica colisión con sí misma
            for (int i = 1; i < serpienteActual.Count; i++)
            {
                if (cabeza == serpienteActual[i])
                {
                    jugando = false;
                    MessageBox.Show("¡Perdiste! La serpiente chocó consigo misma.");
                    return;
                }
            }

            // Verifica colisión con la otra serpiente
            foreach (Point segmento in otraSerpiente)
            {
                if (cabeza == segmento)
                {
                    jugando = false;
                    MessageBox.Show("¡Perdiste! Una serpiente chocó con la otra.");
                    return;
                }
            }
        }
        /// <summary>
        /// Procesa las teclas presionadas por el usuario y actualiza la dirección de movimiento de la serpiente en función de la tecla presionada.
        /// Si se presiona una tecla de dirección válida y no se está moviendo en la dirección opuesta, actualiza la dirección de la serpiente.
        /// </summary>
        /// <param name="msg">El mensaje que se va a procesar.</param>
        /// <param name="keyData">Las teclas que se han presionado.</param>
        /// <returns>true si el carácter se procesa en el método; de lo contrario, false.</returns>

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.W:
                    if (direccionJugador2 != Direction.Down)
                        
                    direccionJugador2 = Direction.Up;
                    break;
                case Keys.S:
                    if (direccionJugador2 != Direction.Up)
                        direccionJugador2 = Direction.Down;
                    break;
                case Keys.A:
                    if (direccionJugador2 != Direction.Right)
                        direccionJugador2 = Direction.Left;
                    break;
                case Keys.D:
                    if (direccionJugador2 != Direction.Left)
                        direccionJugador2 = Direction.Right;
                    break;
            }

            switch (keyData)
            {
                case Keys.Up:
                    if (direccion != Direction.Down)
                        direccion = Direction.Up;
                    break;
                case Keys.Down:
                    if (direccion != Direction.Up)
                        direccion = Direction.Down;
                    break;
                case Keys.Left:
                    if (direccion != Direction.Right)
                        direccion = Direction.Left;
                    break;
                case Keys.Right:
                    if (direccion != Direction.Left)
                        direccion = Direction.Right;
                    break;
              
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jugando == true)
            {
                jugando = false;
            }
            else
            {
                jugando = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jugando = false;
            this.Hide();
            MenuPrincipal juego =  new MenuPrincipal(snake, snake2);
            juego.FormClosed += (s, args) => this.Close();
            juego.Show();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
