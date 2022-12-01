namespace VuelosAdrian
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.btLoguear = new System.Windows.Forms.Button();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoguear
            // 
            this.btLoguear.Location = new System.Drawing.Point(77, 179);
            this.btLoguear.Name = "btLoguear";
            this.btLoguear.Size = new System.Drawing.Size(236, 23);
            this.btLoguear.TabIndex = 0;
            this.btLoguear.Text = "Entrar";
            this.btLoguear.UseVisualStyleBackColor = true;
            this.btLoguear.Click += new System.EventHandler(this.btLoguear_Click);
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(77, 58);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(27, 16);
            this.lbDni.TabIndex = 1;
            this.lbDni.Text = "Dni";
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Location = new System.Drawing.Point(74, 118);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(76, 16);
            this.lbContra.TabIndex = 2;
            this.lbContra.Text = "Contraseña";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(211, 58);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 22);
            this.tbDni.TabIndex = 3;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(213, 118);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(100, 22);
            this.tbContrasena.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VuelosAdrian.Properties.Resources._695940657_226470021_1706x960;
            this.pictureBox1.InitialImage = global::VuelosAdrian.Properties.Resources._695940657_226470021_1706x9601;
            this.pictureBox1.Location = new System.Drawing.Point(37, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.btLoguear);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoguear;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}