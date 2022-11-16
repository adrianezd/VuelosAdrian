namespace VuelosAdrian
{
    partial class Menu_administrador
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
            this.btCrearAeropuertos = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.btVerBilletes = new System.Windows.Forms.Button();
            this.btModificarBillete = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCrearAeropuertos
            // 
            this.btCrearAeropuertos.Location = new System.Drawing.Point(99, 86);
            this.btCrearAeropuertos.Name = "btCrearAeropuertos";
            this.btCrearAeropuertos.Size = new System.Drawing.Size(187, 39);
            this.btCrearAeropuertos.TabIndex = 0;
            this.btCrearAeropuertos.Text = "Crear aeropuertos";
            this.btCrearAeropuertos.UseVisualStyleBackColor = true;
            this.btCrearAeropuertos.Click += new System.EventHandler(this.btCrearAeropuertos_Click);
            // 
            // btAddCliente
            // 
            this.btAddCliente.Location = new System.Drawing.Point(99, 145);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(187, 33);
            this.btAddCliente.TabIndex = 1;
            this.btAddCliente.Text = "Anadir Cliente";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // btVerBilletes
            // 
            this.btVerBilletes.Location = new System.Drawing.Point(99, 199);
            this.btVerBilletes.Name = "btVerBilletes";
            this.btVerBilletes.Size = new System.Drawing.Size(187, 34);
            this.btVerBilletes.TabIndex = 2;
            this.btVerBilletes.Text = "Ver billetes";
            this.btVerBilletes.UseVisualStyleBackColor = true;
            // 
            // btModificarBillete
            // 
            this.btModificarBillete.Location = new System.Drawing.Point(99, 258);
            this.btModificarBillete.Name = "btModificarBillete";
            this.btModificarBillete.Size = new System.Drawing.Size(187, 32);
            this.btModificarBillete.TabIndex = 3;
            this.btModificarBillete.Text = "Modificar billetes";
            this.btModificarBillete.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(99, 310);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(187, 38);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir de la aplicacion";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btModificarBillete);
            this.Controls.Add(this.btVerBilletes);
            this.Controls.Add(this.btAddCliente);
            this.Controls.Add(this.btCrearAeropuertos);
            this.Name = "Menu_administrador";
            this.Text = "Menu_administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrearAeropuertos;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Button btVerBilletes;
        private System.Windows.Forms.Button btModificarBillete;
        private System.Windows.Forms.Button btSalir;
    }
}