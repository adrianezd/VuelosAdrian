namespace VuelosAdrian
{
    partial class Menu_cliente
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
            this.btComprarBillete = new System.Windows.Forms.Button();
            this.btVervuelo = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btComprarBillete
            // 
            this.btComprarBillete.Location = new System.Drawing.Point(49, 72);
            this.btComprarBillete.Name = "btComprarBillete";
            this.btComprarBillete.Size = new System.Drawing.Size(247, 23);
            this.btComprarBillete.TabIndex = 0;
            this.btComprarBillete.Text = "Comprar billete";
            this.btComprarBillete.UseVisualStyleBackColor = true;
            this.btComprarBillete.Click += new System.EventHandler(this.btComprarBillete_Click);
            // 
            // btVervuelo
            // 
            this.btVervuelo.Location = new System.Drawing.Point(45, 32);
            this.btVervuelo.Name = "btVervuelo";
            this.btVervuelo.Size = new System.Drawing.Size(166, 23);
            this.btVervuelo.TabIndex = 1;
            this.btVervuelo.Text = "Ver mi vuelo";
            this.btVervuelo.UseVisualStyleBackColor = true;
            // 
            // btHistorico
            // 
            this.btHistorico.Location = new System.Drawing.Point(49, 292);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(228, 23);
            this.btHistorico.TabIndex = 2;
            this.btHistorico.Text = "Ver histórico";
            this.btHistorico.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(49, 356);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(228, 23);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir de la aplicación";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.btVervuelo);
            this.groupBox1.Location = new System.Drawing.Point(49, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mi vuelo";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(45, 75);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(166, 22);
            this.tbID.TabIndex = 2;
            // 
            // Menu_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btComprarBillete);
            this.Name = "Menu_cliente";
            this.Text = "Menu_cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btComprarBillete;
        private System.Windows.Forms.Button btVervuelo;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbID;
    }
}