﻿namespace VuelosAdrian
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
            this.btLoguear = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
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
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(77, 58);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
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
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(211, 58);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(213, 118);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(100, 22);
            this.tbContrasena.TabIndex = 4;
            this.tbContrasena.TextChanged += new System.EventHandler(this.tbContrasena_TextChanged);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 230);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btLoguear);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoguear;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContrasena;
    }
}