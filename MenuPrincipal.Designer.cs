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
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.br)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_personalizarSerp
            // 
            this.btn_personalizarSerp.Location = new System.Drawing.Point(32, 161);
            this.btn_personalizarSerp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_personalizarSerp.Name = "btn_personalizarSerp";
            this.btn_personalizarSerp.Size = new System.Drawing.Size(237, 41);
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
            this.br.Location = new System.Drawing.Point(307, 14);
            this.br.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(528, 366);
            this.br.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.br.TabIndex = 3;
            this.br.TabStop = false;
            this.br.Click += new System.EventHandler(this.br_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Score";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(844, 404);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.br);
            this.Controls.Add(this.btn_personalizarSerp);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button5;
    }
}