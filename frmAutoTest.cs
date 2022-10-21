using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPozzoSp3
{
    public partial class frmAutoTest : Form
    {
 
       
            public int NumeroTurno;
            public string Dominio;
            public int AnioFabricacion;
            public string Titular;
        

        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void frmAutoTest_Load(object sender, EventArgs e)
        {

        }

        private void txtNroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar)) // se borrarán las teclas fuera del rango '0' al '9' menos todos las teclas que sean controles.
{
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtNroTurno_TextChanged(object sender, EventArgs e)
        {



         }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            NumeroTurno = int.Parse(txtNroTurno.Text);
            Dominio = txtDominio.Text;
            AnioFabricacion = Convert.ToInt32(numAñoFabricacion.Value);
            Titular = txtTitular.Text;

            MessageBox.Show("Registro exitoso");
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtNroTurno.Text != "")
            {
                txtDominio.Enabled = true;
            }
            else
            {
                txtDominio.Enabled = false;
            }

        }

        private void numAñoFabricacion_ValueChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text != "")
            {
                numAñoFabricacion.Enabled = true;
            }
            else
            {
                numAñoFabricacion.Enabled = false;
            }
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (numAñoFabricacion.Value != 0)
            {
                txtTitular.Enabled = true;
            }
            else
               
        }
    }   

}
