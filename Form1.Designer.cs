namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textVelocidad = new System.Windows.Forms.Label();
            this.textNivel = new System.Windows.Forms.Label();
            this.label4sfff = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTamSerpi = new System.Windows.Forms.Label();
            this.textPuntos = new System.Windows.Forms.Label();
            this.textTamSerpi2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textVelocidad2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver al Menu Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velocidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textVelocidad
            // 
            this.textVelocidad.AutoSize = true;
            this.textVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVelocidad.Location = new System.Drawing.Point(552, 66);
            this.textVelocidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textVelocidad.Name = "textVelocidad";
            this.textVelocidad.Size = new System.Drawing.Size(23, 25);
            this.textVelocidad.TabIndex = 3;
            this.textVelocidad.Text = "0";
            this.textVelocidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // textNivel
            // 
            this.textNivel.AutoSize = true;
            this.textNivel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textNivel.Location = new System.Drawing.Point(511, 267);
            this.textNivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNivel.Name = "textNivel";
            this.textNivel.Size = new System.Drawing.Size(23, 25);
            this.textNivel.TabIndex = 5;
            this.textNivel.Text = "0";
            this.textNivel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4sfff
            // 
            this.label4sfff.AutoSize = true;
            this.label4sfff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4sfff.Location = new System.Drawing.Point(448, 267);
            this.label4sfff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4sfff.Name = "label4sfff";
            this.label4sfff.Size = new System.Drawing.Size(61, 25);
            this.label4sfff.TabIndex = 4;
            this.label4sfff.Tag = "d";
            this.label4sfff.Text = "Nivel:";
            this.label4sfff.Click += new System.EventHandler(this.label4_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ad.Location = new System.Drawing.Point(448, 89);
            this.ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(176, 25);
            this.ad.TabIndex = 6;
            this.ad.Tag = "d";
            this.ad.Text = "Tamaño serpiente:";
            this.ad.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(448, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 7;
            this.label4.Tag = "d";
            this.label4.Text = "Score:";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // textTamSerpi
            // 
            this.textTamSerpi.AutoSize = true;
            this.textTamSerpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textTamSerpi.Location = new System.Drawing.Point(621, 89);
            this.textTamSerpi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textTamSerpi.Name = "textTamSerpi";
            this.textTamSerpi.Size = new System.Drawing.Size(23, 25);
            this.textTamSerpi.TabIndex = 8;
            this.textTamSerpi.Text = "0";
            // 
            // textPuntos
            // 
            this.textPuntos.AutoSize = true;
            this.textPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textPuntos.Location = new System.Drawing.Point(518, 298);
            this.textPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textPuntos.Name = "textPuntos";
            this.textPuntos.Size = new System.Drawing.Size(23, 25);
            this.textPuntos.TabIndex = 9;
            this.textPuntos.Text = "0";
            // 
            // textTamSerpi2
            // 
            this.textTamSerpi2.AutoSize = true;
            this.textTamSerpi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textTamSerpi2.Location = new System.Drawing.Point(621, 171);
            this.textTamSerpi2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textTamSerpi2.Name = "textTamSerpi2";
            this.textTamSerpi2.Size = new System.Drawing.Size(23, 25);
            this.textTamSerpi2.TabIndex = 11;
            this.textTamSerpi2.Text = "0";
            this.textTamSerpi2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(448, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 10;
            this.label3.Tag = "d";
            this.label3.Text = "Tamaño serpiente:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textVelocidad2
            // 
            this.textVelocidad2.AutoSize = true;
            this.textVelocidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVelocidad2.Location = new System.Drawing.Point(552, 194);
            this.textVelocidad2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textVelocidad2.Name = "textVelocidad2";
            this.textVelocidad2.Size = new System.Drawing.Size(23, 25);
            this.textVelocidad2.TabIndex = 13;
            this.textVelocidad2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Velocidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(448, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 14;
            this.label2.Tag = "d";
            this.label2.Text = "SERPIENTE #2";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(448, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 15;
            this.label6.Tag = "d";
            this.label6.Text = "SERPIENTE #1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 560);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textVelocidad2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTamSerpi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPuntos);
            this.Controls.Add(this.textTamSerpi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.textNivel);
            this.Controls.Add(this.label4sfff);
            this.Controls.Add(this.textVelocidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textVelocidad;
        private System.Windows.Forms.Label textNivel;
        private System.Windows.Forms.Label label4sfff;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textTamSerpi;
        private System.Windows.Forms.Label textPuntos;
        private System.Windows.Forms.Label textTamSerpi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textVelocidad2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

