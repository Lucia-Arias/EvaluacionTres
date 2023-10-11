using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AaAaAaA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btInicio_Click_1(object sender, EventArgs e)
        {
            gbInicio.Visible = true;
        }

        private void btIniciar_Click_1(object sender, EventArgs e)
        {
            if (tbCorreo.Text == "")
            {
                lbObligatorio1.Visible = true;
            }
            else if (tbCorreo.Text != "")
            {
                lbObligatorio1.Visible = false;
             
            }
 

            if (tbContraseña.Text == "")
            {
               lbObligatorio2.Visible = true;
            }
            else if (tbContraseña.Text != "")
            {
               lbObligatorio2.Visible = false; 
            }

            if (tbContraseña.Text != "" && tbCorreo.Text != "") 
            {
                gbCrear.Visible = false;
                gbInicio.Visible = false;
                btCrear.Visible = false;
                btIniciar.Visible = false;
                btInicio.Visible = false;
                lbBienvenido.Visible = true;
            }


        }

    }
}
