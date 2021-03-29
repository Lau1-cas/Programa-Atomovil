using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_ejercicio_progra.Clases
{
    class CLSAutomovil
    {
        public string marca { get; }
        public int vel_max { get; }
        private int velocidadActual { get; set; }

        private int frenarCarro { get;  }

        private bool encendido = false;

        private string color { get; set; }

        private bool Apagado = false;

        public string Acelerar()
        {
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "Usted llegó a la velocidad Maxima";
            }
            else
            {
                return $"Vas a {velocidadActual} K/H";

            }

        }

        public string frenar()
        {
            velocidadActual = velocidadActual - 10;
            if (velocidadActual <= 0)
            {
                return "Usted a frenado por completo";
            }
            else
            {
                return $"Vas a {velocidadActual} K/H";
            }
        }


        public bool EstaEncendido()
        {
            return encendido;
        }
        public CLSAutomovil(string marcaCarro,int velocidadMx)
        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;
        }

        public string EncenderMotor()
        {

            if (encendido)
            {
                return "El carro ya esta encendido";
            }
            else
            {
                this.encendido = true;
                velocidadActual = 0;
                return "¡Listo! Carro Encendido";
            }

        }
        public bool EstaApagado()
        {
            return Apagado;
        }
           public string ApagarMotor()
            {
           
            if(Apagado){

                return "carro ya esta apagado";
            }

            else
            {
                encendido = false;
                velocidadActual = 0;
                return "Carro apagado";
            }

            }
        }
    }

