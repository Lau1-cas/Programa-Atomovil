
using Clase_6_ejercicio_progra.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Runtime.InteropServices;


namespace Clase_6_ejercicio_progra
{
    public partial class Form1 : Form
    {
        CLSAutomovil carrito;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonInicio_Click(object sender, EventArgs e)
        {
            //crear el carro
            carrito  = new CLSAutomovil("Meches",150);
    
           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ButtonEncender_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.EncenderMotor();
            label1.Text = respuesta;


        }

        private void ButtonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Acelerar();
            }
            else
            {
                MessageBox.Show ($"Lo lamento el carro {carrito.marca} esta apagado");
            }
      
        }

        private void ButtonFrenar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.frenar();
            }
            else
            {
                MessageBox.Show($"Lo lamento el carro {carrito.marca} esta apagado");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        WindowsMediaPlayer sonido;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido == null)
                {
                    sonido = new WindowsMediaPlayer();
                    sonido.URL = Application.StartupPath + @"\mp3\ChopinNocturno.mp3";
                    sonido.controls.play();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }



            SubMenu.Visible = true;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                sonido.controls.pause();

            }

            SubMenu.Visible = true;
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                double tiempo = sonido.controls.currentPosition;
                sonido.controls.currentPosition = tiempo;
                sonido.controls.play();
            }

            SubMenu.Visible = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (sonido != null)
            {
                sonido.controls.stop();
                sonido = null;
            }

            SubMenu.Visible = false;

        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        WindowsMediaPlayer sonido2;
        private void btnCancion2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido2 == null)
                {
                    sonido2 = new WindowsMediaPlayer();
                    sonido2.URL = Application.StartupPath + @"\mp3\LOSTINPARADISE.mp3";
                    sonido2.controls.play();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Submenu2.Visible = true;

        }


        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnPausar2_Click(object sender, EventArgs e)
        {
            if (sonido2 != null)
            {
                sonido2.controls.pause();

            }
            Submenu2.Visible = true;


        }

        private void btnContinuar2_Click(object sender, EventArgs e)
        {
            if (sonido2 != null)
            {
                double tiempo = sonido2.controls.currentPosition;
                sonido2.controls.currentPosition = tiempo;
                sonido2.controls.play();
            }
            Submenu2.Visible = true;
        }

        private void btnDetener2_Click(object sender, EventArgs e)
        {
            if (sonido2 != null)
            {
                sonido2.controls.stop();
                sonido2 = null;
            }
            Submenu2.Visible = false;

        }

        private void SubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        WindowsMediaPlayer sonido3;
        private void btnCancion3_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido3 == null)
                {
                    sonido3 = new WindowsMediaPlayer();
                    sonido3.URL = Application.StartupPath + @"\mp3\Dynamite.mp3";
                    sonido3.controls.play();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Submenu3.Visible = true;
        }

        private void btnPausar3_Click(object sender, EventArgs e)
        {
            if (sonido3 != null)
            {
                sonido3.controls.pause();

            }
            Submenu3.Visible = true;
        }

        private void btnContinuar3_Click(object sender, EventArgs e)
        {
            if (sonido3 != null)
            {
                double tiempo = sonido3.controls.currentPosition;
                sonido3.controls.currentPosition = tiempo;
                sonido3.controls.play();
            }
            Submenu3.Visible = true;
        }

        private void btnDetener3_Click(object sender, EventArgs e)
        {
            if (sonido3 != null)
            {
                sonido3.controls.stop();
                sonido3 = null;
            }
            Submenu3.Visible = false;
        }

        WindowsMediaPlayer sonido4;
        private void btnCancion4_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido4 == null)
                {
                    sonido4 = new WindowsMediaPlayer();
                    sonido4.URL = Application.StartupPath + @"\mp3\Silhouette.mp3";
                    sonido4.controls.play();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Submenu4.Visible = true;
        }

        private void btnPausar4_Click(object sender, EventArgs e)
        {
            if (sonido4 != null)
            {
                sonido4.controls.pause();

            }
            Submenu4.Visible = true;
        }

        private void btnContinuar4_Click(object sender, EventArgs e)
        {
            if (sonido4 != null)
            {
                double tiempo = sonido4.controls.currentPosition;
                sonido4.controls.currentPosition = tiempo;
                sonido4.controls.play();
            }
            Submenu4.Visible = true;
        }

        private void btnDetener4_Click(object sender, EventArgs e)
        {
            if (sonido4 != null)
            {
                sonido4.controls.stop();
                sonido4 = null;
            }
            Submenu4.Visible = false;
        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            labelVelocidad.Text = "0 K/H";
            string respuesta = carrito.ApagarMotor();
            label1.Text = respuesta;

        }
    }
}
