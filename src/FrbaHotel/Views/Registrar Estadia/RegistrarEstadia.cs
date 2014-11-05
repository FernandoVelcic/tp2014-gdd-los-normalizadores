﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel;
using FrbaHotel.Database_Helper;
using FrbaHotel.Models.Exceptions;
using FrbaHotel.Models;
using System.Data.SqlClient;
using FrbaHotel.Views.Registrar_Estadia;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void onCheckIn(object sender, EventArgs e)
        {
            try
            {
                recopilarDatos("checkIn");

            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void onCheckout(object sender, EventArgs e)
        {
            try
            {
                recopilarDatos("checkOut");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void recopilarDatos(String operacion)
        {

            try
            {
                if(txt_NroReserva.Text!="")
                   {
                        int nroReserva = int.Parse(txt_NroReserva.Text); 
                        Reserva reserva = EntityManager.getEntityManager().findBy<Reserva>("reservas.id", nroReserva.ToString());
                        if(reserva==null)
                             {
                                    MessageBox.Show("Por favor, ingrese un número de reserva correcto.");
                                    return; 
                             }
                    }
            }
            catch (FormatException e)
            {
                throw new ValidationException("Por favor, seleccione un numero de reserva valida.");
            }
            catch (NullReferenceException ex)
            {
                throw new ValidationException("La reserva seleccionada no existe");
            }
           
            String fecha = datepicker.Value.ToString();
            string usuario = txt_Usuario.Text;
            
            if(operacion=="checkIn" && txt_NroReserva.Text!=""){
                int nroReserva1 = int.Parse(txt_NroReserva.Text);
                Reserva reservain = EntityManager.getEntityManager().findBy<Reserva>("reservas.id", nroReserva1.ToString());
                if (DateTime.Compare(DateTime.Parse(fecha).Date, DateTime.Parse(reservain.fecha_inicio).Date) == 0)
                {
                            reservain.reserva_estado = 6;

                            Estadia estadia = new Estadia();
                            estadia.fecha_llegada = fecha;
                            estadia.reserva = reservain;

                            try
                                {
                                    reservain.save();
                                    estadia.save();
                                }
                            catch (ValidationException exception)
                                {
                                    MessageBox.Show(exception.Message);
                                    return;
                                }
                            catch (SqlException exception)
                                {
                                    MessageBox.Show(exception.Message);
                                    return;
                                }
                            MessageBox.Show("La estadía ha sido validada");
                            Navigator.nextForm(this, new FrbaHotel.Views.Registrar_Estadia.Ingreso(reservain));
                }
                else if (DateTime.Compare(DateTime.Parse(fecha).Date,DateTime.Parse(reservain.fecha_inicio).Date)!=0)
                    {
                        MessageBox.Show("El resultado fue" + DateTime.Compare(DateTime.Parse(fecha).Date, DateTime.Parse(reservain.fecha_inicio).Date));
                        MessageBox.Show("La fecha ingresada no es igual a la reservada");
                    }
            }
            else if(operacion=="checkOut" && txt_NroReserva.Text!="") {
                
                int nroReserva1 = int.Parse(txt_NroReserva.Text);
                Estadia estadiaout = EntityManager.getEntityManager().findBy<Estadia>("reserva_id", nroReserva1.ToString());

                estadiaout.cant_noches = int.Parse( DateTime.Parse(fecha).Subtract(DateTime.Parse(estadiaout.fecha_llegada)).ToString());

                try
                {
                    estadiaout.save();
                }
                catch (ValidationException exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
                
                Navigator.nextForm(this, new FrbaHotel.Registrar_Consumible.Form1(estadiaout.reserva.regimen));
            } else 
            {
                MessageBox.Show("Debe ingresar un numero de reserva válido para poder operar");
            }
        }
    }
}
