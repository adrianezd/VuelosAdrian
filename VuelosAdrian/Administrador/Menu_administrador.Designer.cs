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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btCrearAeropuertos = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.btVerBilletes = new System.Windows.Forms.Button();
            this.btModificarBillete = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbFichero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btVerBilletes.Click += new System.EventHandler(this.btVerBilletes_Click);
            // 
            // btModificarBillete
            // 
            this.btModificarBillete.Location = new System.Drawing.Point(99, 258);
            this.btModificarBillete.Name = "btModificarBillete";
            this.btModificarBillete.Size = new System.Drawing.Size(187, 32);
            this.btModificarBillete.TabIndex = 3;
            this.btModificarBillete.Text = "Modificar billetes";
            this.btModificarBillete.UseVisualStyleBackColor = true;
            this.btModificarBillete.Click += new System.EventHandler(this.btModificarBillete_Click);
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
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(351, 76);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(48, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(115, 76);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar Fichero";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(185, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 76);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbFichero
            // 
            this.tbFichero.Location = new System.Drawing.Point(48, 124);
            this.tbFichero.Name = "tbFichero";
            this.tbFichero.Size = new System.Drawing.Size(268, 22);
            this.tbFichero.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.tbFichero);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(178, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrir Archivo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos TXT(*.txt)|*.txt|Archivos DOC(*.doc)|*.doc";
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btModificarBillete);
            this.Controls.Add(this.btVerBilletes);
            this.Controls.Add(this.btAddCliente);
            this.Controls.Add(this.btCrearAeropuertos);
            this.Name = "Menu_administrador";
            this.Text = "Menu_administrador";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrearAeropuertos;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Button btVerBilletes;
        private System.Windows.Forms.Button btModificarBillete;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbFichero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}