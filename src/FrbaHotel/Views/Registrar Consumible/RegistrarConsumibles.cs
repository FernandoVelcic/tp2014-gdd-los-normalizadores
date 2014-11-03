﻿using FrbaHotel.Database_Helper;
using FrbaHotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class Form1 : Form
    {
        Regimen regimen;

        public Form1(Regimen r)
        {
            regimen = r;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.cargarConsumibles();
            
            BindingSource consumibles_binding = new BindingSource();
            consumibles_binding.DataSource = EntityManager.getEntityManager().findAll<Consumible>();
            comboBox1.DataSource = consumibles_binding;
            comboBox1.Text = "";

            textBox5.Text = regimen.descripcion;

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modificar el que esta seleccionado en el datagrid
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ConsumibleEstadia consumible_estadia = new ConsumibleEstadia();

            int unidades = int.Parse(textBox4.Text);    //chequear si va, para mi deberia, pero en la tabla no está
            Consumible consumible_seleccionado = comboBox1.SelectedItem as Consumible;

            consumible_estadia.regimen.codigo = regimen.codigo;
            consumible_estadia.consumible.codigo = consumible_seleccionado.codigo;
            consumible_estadia.unidades = unidades;

            consumible_estadia.save();
            this.cargarConsumibles();
         }

        private void cargarConsumibles()
        {
            List<ConsumibleEstadia> consumiblesEstadia = new List<ConsumibleEstadia>(EntityManager.getEntityManager().findAllBy<ConsumibleEstadia>("estadia_id", regimen.id.ToString()));

            BindingList<ConsumibleUnidades> consumibleUnidadesBinding = new BindingList<ConsumibleUnidades>();
            foreach (ConsumibleEstadia consumibleEstadia in consumiblesEstadia)
            {
                ConsumibleUnidades consumibleUnidades = new ConsumibleUnidades();

                consumibleUnidades.codigo = consumibleEstadia.consumible.codigo;
                consumibleUnidades.descripcion = consumibleEstadia.consumible.descripcion;
                consumibleUnidades.precio = consumibleEstadia.consumible.precio;
                consumibleUnidades.unidades = consumibleEstadia.unidades;

                consumibleUnidadesBinding.Add(consumibleUnidades);
            }
            dataGridView1.DataSource = new BindingSource(consumibleUnidadesBinding, null);
        }
    }
}
