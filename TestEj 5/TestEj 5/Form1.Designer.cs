﻿namespace TestEj_5
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
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.rdbFecha2 = new System.Windows.Forms.RadioButton();
            this.rdbFecha1 = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gpbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.txtDia);
            this.gpbFecha.Controls.Add(this.label1);
            this.gpbFecha.Controls.Add(this.txtMes);
            this.gpbFecha.Controls.Add(this.label2);
            this.gpbFecha.Controls.Add(this.label3);
            this.gpbFecha.Controls.Add(this.txtAnio);
            this.gpbFecha.Location = new System.Drawing.Point(104, 32);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(200, 100);
            this.gpbFecha.TabIndex = 13;
            this.gpbFecha.TabStop = false;
            this.gpbFecha.Text = "Fecha";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(17, 54);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(41, 20);
            this.txtDia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(76, 54);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(41, 20);
            this.txtMes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(140, 54);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(41, 20);
            this.txtAnio.TabIndex = 4;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(310, 40);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // rdbFecha2
            // 
            this.rdbFecha2.AutoSize = true;
            this.rdbFecha2.Location = new System.Drawing.Point(23, 84);
            this.rdbFecha2.Name = "rdbFecha2";
            this.rdbFecha2.Size = new System.Drawing.Size(64, 17);
            this.rdbFecha2.TabIndex = 11;
            this.rdbFecha2.TabStop = true;
            this.rdbFecha2.Text = "Fecha 2";
            this.rdbFecha2.UseVisualStyleBackColor = true;
            this.rdbFecha2.CheckedChanged += new System.EventHandler(this.rdbFecha2_CheckedChanged);
            // 
            // rdbFecha1
            // 
            this.rdbFecha1.AutoSize = true;
            this.rdbFecha1.Location = new System.Drawing.Point(23, 46);
            this.rdbFecha1.Name = "rdbFecha1";
            this.rdbFecha1.Size = new System.Drawing.Size(64, 17);
            this.rdbFecha1.TabIndex = 10;
            this.rdbFecha1.TabStop = true;
            this.rdbFecha1.Text = "Fecha 1";
            this.rdbFecha1.UseVisualStyleBackColor = true;
            this.rdbFecha1.CheckedChanged += new System.EventHandler(this.rdbFecha1_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(310, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 165);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.rdbFecha2);
            this.Controls.Add(this.rdbFecha1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RadioButton rdbFecha2;
        private System.Windows.Forms.RadioButton rdbFecha1;
        private System.Windows.Forms.Button btnModificar;
    }
}

