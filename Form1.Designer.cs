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
            this.button1 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1262, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1262, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velocidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textVelocidad
            // 
            this.textVelocidad.AutoSize = true;
            this.textVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVelocidad.Location = new System.Drawing.Point(736, 81);
            this.textVelocidad.Name = "textVelocidad";
            this.textVelocidad.Size = new System.Drawing.Size(27, 29);
            this.textVelocidad.TabIndex = 3;
            this.textVelocidad.Text = "0";
            this.textVelocidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // textNivel
            // 
            this.textNivel.AutoSize = true;
            this.textNivel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textNivel.Location = new System.Drawing.Point(681, 114);
            this.textNivel.Name = "textNivel";
            this.textNivel.Size = new System.Drawing.Size(27, 29);
            this.textNivel.TabIndex = 5;
            this.textNivel.Text = "0";
            this.textNivel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4sfff
            // 
            this.label4sfff.AutoSize = true;
            this.label4sfff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4sfff.Location = new System.Drawing.Point(598, 114);
            this.label4sfff.Name = "label4sfff";
            this.label4sfff.Size = new System.Drawing.Size(77, 29);
            this.label4sfff.TabIndex = 4;
            this.label4sfff.Tag = "d";
            this.label4sfff.Text = "Nivel:";
            this.label4sfff.Click += new System.EventHandler(this.label4_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ad.Location = new System.Drawing.Point(598, 144);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(224, 29);
            this.ad.TabIndex = 6;
            this.ad.Tag = "d";
            this.ad.Text = "Tamaño serpiente:";
            this.ad.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(598, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 7;
            this.label4.Tag = "d";
            this.label4.Text = "Score:";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // textTamSerpi
            // 
            this.textTamSerpi.AutoSize = true;
            this.textTamSerpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textTamSerpi.Location = new System.Drawing.Point(828, 144);
            this.textTamSerpi.Name = "textTamSerpi";
            this.textTamSerpi.Size = new System.Drawing.Size(27, 29);
            this.textTamSerpi.TabIndex = 8;
            this.textTamSerpi.Text = "0";
            // 
            // textPuntos
            // 
            this.textPuntos.AutoSize = true;
            this.textPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textPuntos.Location = new System.Drawing.Point(690, 181);
            this.textPuntos.Name = "textPuntos";
            this.textPuntos.Size = new System.Drawing.Size(27, 29);
            this.textPuntos.TabIndex = 9;
            this.textPuntos.Text = "0";
            // 
            // textTamSerpi2
            // 
            this.textTamSerpi2.AutoSize = true;
            this.textTamSerpi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textTamSerpi2.Location = new System.Drawing.Point(828, 210);
            this.textTamSerpi2.Name = "textTamSerpi2";
            this.textTamSerpi2.Size = new System.Drawing.Size(27, 29);
            this.textTamSerpi2.TabIndex = 11;
            this.textTamSerpi2.Text = "0";
            this.textTamSerpi2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(598, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 10;
            this.label3.Tag = "d";
            this.label3.Text = "Tamaño serpiente:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 689);
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
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

