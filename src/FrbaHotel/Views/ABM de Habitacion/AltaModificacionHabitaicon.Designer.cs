﻿namespace FrbaHotel.ABM_de_Habitacion
{
    partial class AltaModificacionHabitacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Frente = new System.Windows.Forms.ComboBox();
            this.txt_Piso = new System.Windows.Forms.TextBox();
            this.cmb_TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.cmb_Hotel = new System.Windows.Forms.ComboBox();
            this.txt_NroHabitacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_Inactivo = new System.Windows.Forms.RadioButton();
            this.radio_Activo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmb_Frente);
            this.groupBox1.Controls.Add(this.txt_Piso);
            this.groupBox1.Controls.Add(this.cmb_TipoHabitacion);
            this.groupBox1.Controls.Add(this.cmb_Hotel);
            this.groupBox1.Controls.Add(this.txt_NroHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la habitación";
            // 
            // cmb_Frente
            // 
            this.cmb_Frente.FormattingEnabled = true;
            this.cmb_Frente.Location = new System.Drawing.Point(166, 124);
            this.cmb_Frente.Name = "cmb_Frente";
            this.cmb_Frente.Size = new System.Drawing.Size(121, 21);
            this.cmb_Frente.TabIndex = 13;
            // 
            // txt_Piso
            // 
            this.txt_Piso.Location = new System.Drawing.Point(166, 98);
            this.txt_Piso.Name = "txt_Piso";
            this.txt_Piso.Size = new System.Drawing.Size(121, 20);
            this.txt_Piso.TabIndex = 12;
            // 
            // cmb_TipoHabitacion
            // 
            this.cmb_TipoHabitacion.FormattingEnabled = true;
            this.cmb_TipoHabitacion.Location = new System.Drawing.Point(166, 153);
            this.cmb_TipoHabitacion.Name = "cmb_TipoHabitacion";
            this.cmb_TipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoHabitacion.TabIndex = 9;
            // 
            // cmb_Hotel
            // 
            this.cmb_Hotel.FormattingEnabled = true;
            this.cmb_Hotel.Location = new System.Drawing.Point(166, 66);
            this.cmb_Hotel.Name = "cmb_Hotel";
            this.cmb_Hotel.Size = new System.Drawing.Size(121, 21);
            this.cmb_Hotel.TabIndex = 7;
            // 
            // txt_NroHabitacion
            // 
            this.txt_NroHabitacion.Location = new System.Drawing.Point(166, 40);
            this.txt_NroHabitacion.Name = "txt_NroHabitacion";
            this.txt_NroHabitacion.Size = new System.Drawing.Size(121, 20);
            this.txt_NroHabitacion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de habitacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Piso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Habitación:";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(297, 284);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(144, 45);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.onGuardar);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 285);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(156, 44);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.onVolver);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_Inactivo);
            this.groupBox2.Controls.Add(this.radio_Activo);
            this.groupBox2.Location = new System.Drawing.Point(39, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 66);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado:";
            // 
            // radio_Inactivo
            // 
            this.radio_Inactivo.AutoSize = true;
            this.radio_Inactivo.Location = new System.Drawing.Point(191, 33);
            this.radio_Inactivo.Name = "radio_Inactivo";
            this.radio_Inactivo.Size = new System.Drawing.Size(72, 17);
            this.radio_Inactivo.TabIndex = 8;
            this.radio_Inactivo.TabStop = true;
            this.radio_Inactivo.Text = "No Activo";
            this.radio_Inactivo.UseVisualStyleBackColor = true;
            // 
            // radio_Activo
            // 
            this.radio_Activo.AutoSize = true;
            this.radio_Activo.Location = new System.Drawing.Point(66, 33);
            this.radio_Activo.Name = "radio_Activo";
            this.radio_Activo.Size = new System.Drawing.Size(55, 17);
            this.radio_Activo.TabIndex = 7;
            this.radio_Activo.TabStop = true;
            this.radio_Activo.Text = "Activo";
            this.radio_Activo.UseVisualStyleBackColor = true;
            // 
            // AltaModificacionHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(455, 341);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaModificacionHabitacion";
            this.Text = "ABM de Habitacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_TipoHabitacion;
        private System.Windows.Forms.ComboBox cmb_Hotel;
        private System.Windows.Forms.TextBox txt_NroHabitacion;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.ComboBox cmb_Frente;
        private System.Windows.Forms.TextBox txt_Piso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_Inactivo;
        private System.Windows.Forms.RadioButton radio_Activo;
    }
}