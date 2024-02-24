namespace SnakeGame
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_personalizarSerp = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.br = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.br)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_personalizarSerp
            // 
            this.btn_personalizarSerp.Location = new System.Drawing.Point(24, 157);
            this.btn_personalizarSerp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_personalizarSerp.Name = "btn_personalizarSerp";
            this.btn_personalizarSerp.Size = new System.Drawing.Size(178, 61);
            this.btn_personalizarSerp.TabIndex = 1;
            this.btn_personalizarSerp.Text = "Personalizar Serpiente";
            this.btn_personalizarSerp.UseVisualStyleBackColor = true;
            this.btn_personalizarSerp.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.GreenYellow;
            this.colorDialog2.FullOpen = true;
            // 
            // br
            // 
            this.br.Image = ((System.Drawing.Image)(resources.GetObject("br.Image")));
            this.br.InitialImage = ((System.Drawing.Image)(resources.GetObject("br.InitialImage")));
            this.br.Location = new System.Drawing.Point(230, 11);
            this.br.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(396, 297);
            this.br.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.br.TabIndex = 3;
            this.br.TabStop = false;
            this.br.Click += new System.EventHandler(this.br_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(633, 328);
            this.Controls.Add(this.br);
            this.Controls.Add(this.btn_personalizarSerp);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.br)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_personalizarSerp;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.PictureBox br;
    }
}