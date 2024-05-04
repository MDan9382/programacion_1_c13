using programacion_1.formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            // MessageBox.Show("bienvenido");

        }

        public int intentos = 2;

        private void buttoningresar_Click(object sender, EventArgs e)
        {
            string usr = textBoxusuario.Text.ToLower();
            string ctr = textBoxcontra.Text.ToLower();
            textBoxusuario.Clear();
            textBoxcontra.Clear();

            
            if (intentos > 0)
            {

                if (usr.Equals("") || ctr.Equals(""))
                {
                    MessageBox.Show("no pude dejar campos vacios");
                }
                else
                {
                    if (usr.Equals("admin") && ctr.Equals("admin"))
                    {
                        Frm_registro reg1 = new Frm_registro();
                        reg1.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show($"incorrecto, quedan {intentos} intentos");
                        intentos--; 

                    }

                }
            }
            else
            {
                MessageBox.Show("se han acabado los intentos disponibles");
                buttoningresar.Enabled = false;
            }
        }
    }
}
