namespace VuelosAdrian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cBoxIda = new System.Windows.Forms.ComboBox();
            this.cBoxVuelta = new System.Windows.Forms.ComboBox();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.btSelectVuelta = new System.Windows.Forms.Button();
            this.monthCalendarIda = new System.Windows.Forms.MonthCalendar();
            this.lbVueloOrSelected = new System.Windows.Forms.Label();
            this.lbVueloDestSelected = new System.Windows.Forms.Label();
            this.lbFechaIda = new System.Windows.Forms.Label();
            this.monthCalendarVuelta = new System.Windows.Forms.MonthCalendar();
            this.lbFechaVuelta = new System.Windows.Forms.Label();
            this.btComprar = new System.Windows.Forms.Button();
            this.lbCalendarVuelta = new System.Windows.Forms.Label();
            this.lbCalendarIda = new System.Windows.Forms.Label();
            this.lbCompraHecha = new System.Windows.Forms.Label();
            this.btAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxIda
            // 
            this.cBoxIda.FormattingEnabled = true;
            this.cBoxIda.Location = new System.Drawing.Point(93, 40);
            this.cBoxIda.Name = "cBoxIda";
            this.cBoxIda.Size = new System.Drawing.Size(121, 24);
            this.cBoxIda.TabIndex = 0;
            this.cBoxIda.SelectedIndexChanged += new System.EventHandler(this.cBoxIda_SelectedIndexChanged);
            this.cBoxIda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBoxIda_MouseClick);
            // 
            // cBoxVuelta
            // 
            this.cBoxVuelta.FormattingEnabled = true;
            this.cBoxVuelta.Location = new System.Drawing.Point(278, 40);
            this.cBoxVuelta.Name = "cBoxVuelta";
            this.cBoxVuelta.Size = new System.Drawing.Size(121, 24);
            this.cBoxVuelta.TabIndex = 1;
            this.cBoxVuelta.SelectedIndexChanged += new System.EventHandler(this.cBoxVuelta_SelectedIndexChanged);
            this.cBoxVuelta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBoxVuelta_MouseClick);
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Location = new System.Drawing.Point(90, 12);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(47, 16);
            this.lbOrigen.TabIndex = 2;
            this.lbOrigen.Text = "Origen";
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(275, 12);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(53, 16);
            this.lbDestino.TabIndex = 3;
            this.lbDestino.Text = "Destino";
            // 
            // btSelectVuelta
            // 
            this.btSelectVuelta.Location = new System.Drawing.Point(461, 36);
            this.btSelectVuelta.Name = "btSelectVuelta";
            this.btSelectVuelta.Size = new System.Drawing.Size(217, 31);
            this.btSelectVuelta.TabIndex = 4;
            this.btSelectVuelta.Text = "Seleccionar vuelo de vuelta";
            this.btSelectVuelta.UseVisualStyleBackColor = true;
            this.btSelectVuelta.Click += new System.EventHandler(this.btSelectVuelta_Click);
            // 
            // monthCalendarIda
            // 
            this.monthCalendarIda.Location = new System.Drawing.Point(93, 107);
            this.monthCalendarIda.MaxSelectionCount = 1;
            this.monthCalendarIda.Name = "monthCalendarIda";
            this.monthCalendarIda.TabIndex = 5;
            this.monthCalendarIda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarIda_DateChanged);
            // 
            // lbVueloOrSelected
            // 
            this.lbVueloOrSelected.AutoSize = true;
            this.lbVueloOrSelected.Location = new System.Drawing.Point(122, 341);
            this.lbVueloOrSelected.Name = "lbVueloOrSelected";
            this.lbVueloOrSelected.Size = new System.Drawing.Size(193, 16);
            this.lbVueloOrSelected.TabIndex = 6;
            this.lbVueloOrSelected.Text = "Vuelo de origen seleccionado: ";
            // 
            // lbVueloDestSelected
            // 
            this.lbVueloDestSelected.AutoSize = true;
            this.lbVueloDestSelected.Location = new System.Drawing.Point(122, 368);
            this.lbVueloDestSelected.Name = "lbVueloDestSelected";
            this.lbVueloDestSelected.Size = new System.Drawing.Size(191, 16);
            this.lbVueloDestSelected.TabIndex = 7;
            this.lbVueloDestSelected.Text = "Vuelo de vuelta seleccionado: ";
            // 
            // lbFechaIda
            // 
            this.lbFechaIda.AutoSize = true;
            this.lbFechaIda.Location = new System.Drawing.Point(474, 341);
            this.lbFechaIda.Name = "lbFechaIda";
            this.lbFechaIda.Size = new System.Drawing.Size(111, 16);
            this.lbFechaIda.TabIndex = 8;
            this.lbFechaIda.Text = "Con fecha de ida:";
            // 
            // monthCalendarVuelta
            // 
            this.monthCalendarVuelta.Location = new System.Drawing.Point(436, 107);
            this.monthCalendarVuelta.MaxSelectionCount = 1;
            this.monthCalendarVuelta.Name = "monthCalendarVuelta";
            this.monthCalendarVuelta.TabIndex = 9;
            this.monthCalendarVuelta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarVuelta_DateChanged);
            // 
            // lbFechaVuelta
            // 
            this.lbFechaVuelta.AutoSize = true;
            this.lbFechaVuelta.Location = new System.Drawing.Point(474, 368);
            this.lbFechaVuelta.Name = "lbFechaVuelta";
            this.lbFechaVuelta.Size = new System.Drawing.Size(128, 16);
            this.lbFechaVuelta.TabIndex = 10;
            this.lbFechaVuelta.Text = "Con fecha de vuelta:";
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(320, 406);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(131, 55);
            this.btComprar.TabIndex = 11;
            this.btComprar.Text = "Comprar Billete";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // lbCalendarVuelta
            // 
            this.lbCalendarVuelta.AutoSize = true;
            this.lbCalendarVuelta.Location = new System.Drawing.Point(405, 82);
            this.lbCalendarVuelta.Name = "lbCalendarVuelta";
            this.lbCalendarVuelta.Size = new System.Drawing.Size(103, 16);
            this.lbCalendarVuelta.TabIndex = 13;
            this.lbCalendarVuelta.Text = "Fecha de vuelta";
            // 
            // lbCalendarIda
            // 
            this.lbCalendarIda.AutoSize = true;
            this.lbCalendarIda.Location = new System.Drawing.Point(100, 82);
            this.lbCalendarIda.Name = "lbCalendarIda";
            this.lbCalendarIda.Size = new System.Drawing.Size(86, 16);
            this.lbCalendarIda.TabIndex = 12;
            this.lbCalendarIda.Text = "Fecha de ida";
            // 
            // lbCompraHecha
            // 
            this.lbCompraHecha.AutoSize = true;
            this.lbCompraHecha.Location = new System.Drawing.Point(109, 473);
            this.lbCompraHecha.Name = "lbCompraHecha";
            this.lbCompraHecha.Size = new System.Drawing.Size(0, 16);
            this.lbCompraHecha.TabIndex = 14;
            // 
            // btAdmin
            // 
            this.btAdmin.Location = new System.Drawing.Point(713, 498);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(75, 23);
            this.btAdmin.TabIndex = 15;
            this.btAdmin.Text = "admin";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.lbCompraHecha);
            this.Controls.Add(this.lbCalendarVuelta);
            this.Controls.Add(this.lbCalendarIda);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.lbFechaVuelta);
            this.Controls.Add(this.monthCalendarVuelta);
            this.Controls.Add(this.lbFechaIda);
            this.Controls.Add(this.lbVueloDestSelected);
            this.Controls.Add(this.lbVueloOrSelected);
            this.Controls.Add(this.monthCalendarIda);
            this.Controls.Add(this.btSelectVuelta);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.lbOrigen);
            this.Controls.Add(this.cBoxVuelta);
            this.Controls.Add(this.cBoxIda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AerolineasAdrian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxIda;
        private System.Windows.Forms.ComboBox cBoxVuelta;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Button btSelectVuelta;
        private System.Windows.Forms.MonthCalendar monthCalendarIda;
        private System.Windows.Forms.Label lbVueloOrSelected;
        private System.Windows.Forms.Label lbVueloDestSelected;
        private System.Windows.Forms.Label lbFechaIda;
        private System.Windows.Forms.MonthCalendar monthCalendarVuelta;
        private System.Windows.Forms.Label lbFechaVuelta;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Label lbCalendarVuelta;
        private System.Windows.Forms.Label lbCalendarIda;
        private System.Windows.Forms.Label lbCompraHecha;
        private System.Windows.Forms.Button btAdmin;
    }
}

