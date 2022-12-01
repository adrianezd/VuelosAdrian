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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_administrador));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCrearAeropuertos
            // 
            this.btCrearAeropuertos.Location = new System.Drawing.Point(27, 43);
            this.btCrearAeropuertos.Name = "btCrearAeropuertos";
            this.btCrearAeropuertos.Size = new System.Drawing.Size(187, 34);
            this.btCrearAeropuertos.TabIndex = 0;
            this.btCrearAeropuertos.Text = "Crear aeropuertos";
            this.btCrearAeropuertos.UseVisualStyleBackColor = true;
            this.btCrearAeropuertos.Click += new System.EventHandler(this.btCrearAeropuertos_Click);
            // 
            // btAddCliente
            // 
            this.btAddCliente.Location = new System.Drawing.Point(27, 93);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(187, 34);
            this.btAddCliente.TabIndex = 1;
            this.btAddCliente.Text = "Anadir Cliente";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // btVerBilletes
            // 
            this.btVerBilletes.Location = new System.Drawing.Point(27, 147);
            this.btVerBilletes.Name = "btVerBilletes";
            this.btVerBilletes.Size = new System.Drawing.Size(187, 34);
            this.btVerBilletes.TabIndex = 2;
            this.btVerBilletes.Text = "Ver billetes";
            this.btVerBilletes.UseVisualStyleBackColor = true;
            this.btVerBilletes.Click += new System.EventHandler(this.btVerBilletes_Click);
            // 
            // btModificarBillete
            // 
            this.btModificarBillete.Location = new System.Drawing.Point(27, 199);
            this.btModificarBillete.Name = "btModificarBillete";
            this.btModificarBillete.Size = new System.Drawing.Size(187, 34);
            this.btModificarBillete.TabIndex = 3;
            this.btModificarBillete.Text = "Modificar billetes";
            this.btModificarBillete.UseVisualStyleBackColor = true;
            this.btModificarBillete.Click += new System.EventHandler(this.btModificarBillete_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(27, 251);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(187, 34);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir de la aplicacion";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(321, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(366, 323);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(48, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(157, 76);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar Fichero";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 76);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar fichero";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbFichero
            // 
            this.tbFichero.Location = new System.Drawing.Point(48, 124);
            this.tbFichero.Name = "tbFichero";
            this.tbFichero.Size = new System.Drawing.Size(329, 22);
            this.tbFichero.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.tbFichero);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(119, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrir Archivo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos TXT(*.txt)|*.txt|Archivos DOC(*.doc)|*.doc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCrearAeropuertos);
            this.groupBox2.Controls.Add(this.btAddCliente);
            this.groupBox2.Controls.Add(this.btSalir);
            this.groupBox2.Controls.Add(this.btVerBilletes);
            this.groupBox2.Controls.Add(this.btModificarBillete);
            this.groupBox2.Location = new System.Drawing.Point(27, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 333);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de admin";
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_administrador";
            this.Text = "Menu_administrador";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
    }
}