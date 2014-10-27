﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaHotel.Models;
using FrbaHotel.Database_Helper;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class ABMUsuario : Form
    {
        public ABMUsuario()
        {
            InitializeComponent();
        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            var usuariosBinding = new BindingList<Usuario>(EntityManager.getEntityManager().findAll<Usuario>());
            dataGridView1.DataSource = new BindingSource(usuariosBinding, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nextForm(new FrbaHotel.ABM_de_Usuario.AltaModificaiconUsuario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.deleteRecord(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.editRecord<Usuario, FrbaHotel.ABM_de_Usuario.AltaModificaiconUsuario>(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = -1;
            //listar
            //limpieza
        }

        
    }
}
