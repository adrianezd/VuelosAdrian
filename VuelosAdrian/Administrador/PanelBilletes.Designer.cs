namespace VuelosAdrian.Administrador
{
    partial class PanelBilletes
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbPersona = new System.Windows.Forms.Label();
            this.lbVueloIda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPersonas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboIda = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 292);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(533, 331);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(239, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Guardar Billete";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbPersona
            // 
            this.lbPersona.AutoSize = true;
            this.lbPersona.Location = new System.Drawing.Point(21, 36);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(58, 16);
            this.lbPersona.TabIndex = 4;
            this.lbPersona.Text = "Persona";
            // 
            // lbVueloIda
            // 
            this.lbVueloIda.AutoSize = true;
            this.lbVueloIda.Location = new System.Drawing.Point(21, 88);
            this.lbVueloIda.Name = "lbVueloIda";
            this.lbVueloIda.Size = new System.Drawing.Size(83, 16);
            this.lbVueloIda.TabIndex = 5;
            this.lbVueloIda.Text = "Vuelo de ida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vuelo de vuelta";
            // 
            // comboPersonas
            // 
            this.comboPersonas.FormattingEnabled = true;
            this.comboPersonas.Location = new System.Drawing.Point(120, 33);
            this.comboPersonas.Name = "comboPersonas";
            this.comboPersonas.Size = new System.Drawing.Size(121, 24);
            this.comboPersonas.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboIda);
            this.groupBox1.Controls.Add(this.lbPersona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboPersonas);
            this.groupBox1.Controls.Add(this.lbVueloIda);
            this.groupBox1.Location = new System.Drawing.Point(509, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Su vuelo es";
            // 
            // comboIda
            // 
            this.comboIda.FormattingEnabled = true;
            this.comboIda.Location = new System.Drawing.Point(120, 85);
            this.comboIda.Name = "comboIda";
            this.comboIda.Size = new System.Drawing.Size(121, 24);
            this.comboIda.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // PanelBilletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.listBox1);
            this.Name = "PanelBilletes";
            this.Text = "PanelBilletes";
            this.Load += new System.EventHandler(this.PanelBilletes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lbPersona;
        private System.Windows.Forms.Label lbVueloIda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPersonas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboIda;
    }
}