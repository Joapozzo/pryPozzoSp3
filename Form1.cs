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
        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AnioFabricacion;
            public string Titular;
        }
        // constante para la cantidad total de elementos del arreglo
        const int MAX = 50;
        // declaración del arreglo unidimensional de 50 elementos
        public TURNO[] turnos;
        // variable para controlar la cantidad de elementos cargados
        public int Cantidad = 0;

        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void frmAutoTest_Load(object sender, EventArgs e)
        {
            // creación del arreglo
            turnos = new TURNO[MAX];
            // inicializar la variable que controla la cantidad de elementos cargados
            Cantidad = 0;
            // establecer el estado inicial de todos los componentes de la interfaz
            //inicializarInterfaz();
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
            if (txtNroTurno.Text != "")
            {
                txtDominio.Text enabled = true;
            }
        }
    }
}
