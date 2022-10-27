using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        };

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
            inicializarInterfaz();
        }
        private void inicializarInterfaz()
        {
            limpiarControles();                      // estado inicial de los controles de carga de datos
                                                     // estado inicial de los controles de consultas
            txtCantTurnos.Clear();
            txtAñoAntiguo.Clear();
            txtCantDominio.Clear();
        }
        private void limpiarControles()
        {
            // valores para el estado inicial de los controles de carga
            txtNroTurno.Clear();
            txtDominio.Clear();
            numAñoFabricacion.Value = 2021;
            txtTitular.Clear();
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
                txtDominio.Enabled = true;
            }
            else
            {
                txtDominio.Enabled = false;


            }

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validar los datos antes de ingresarlos al arreglo
            if (validarDatos())
            {
                //agregar los datos al arreglo en la posicion indicada por la variable "cantidad"
                turnos[Cantidad].NumeroTurno = int.Parse(txtNroTurno.Text);
                turnos[Cantidad].Dominio = txtDominio.Text;
                turnos[Cantidad].AnioFabricacion = int.Parse(numAñoFabricacion.Value.ToString());
                turnos[Cantidad].Titular = txtTitular.Text;
                //incrementar la cantidad de elementos cargados
                Cantidad++;
                //verificar si queda espacio en el arreglo
                if (Cantidad == MAX)
                {
                    MessageBox.Show("Se completo la capacidad de carga de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false;
                }
                limpiarControles();

            }
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text != "")
            {
                numAñoFabricacion.Enabled = true;
                txtTitular.Enabled = true;
            }
            else
            {
                numAñoFabricacion.Enabled = false;
                txtTitular.Enabled = false;
            }

        }

        private void numAñoFabricacion_ValueChanged(object sender, EventArgs e)
        {
            //if (numAñoFabricacion.Text >= 1950 && <= 2022)
            {
                numAñoFabricacion.Enabled = true;
            }
            //else
            {
                numAñoFabricacion.Enabled = false;
            }
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtTitular.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }


        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar)) //si es una minuscula entonces:
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); //convertir a mayuscula
            }
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) //si no es ni letra ni numero y es distinto a backspace entonces
            {
                e.Handled = true; //borrar tecla
            }

        }
        private bool validarDatos()

        {
            bool resultado = false; //valor a devolver si no se cumplen todas las condiciones 
            if (txtNroTurno.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")  //validar la existencia de datos a ingresar
            {
                if (txtDominio.Text.Length >= 6) //validar el contenido del dominio
                {
                    if (!buscarTurno(int.Parse(txtNroTurno.Text)))
                    {
                        resultado = true; //si todo esta bien devuelve verdadero
                    }

                    else
                    {
                        MessageBox.Show("El numero de Turno ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Debe completar los datos faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;


        }

        private bool buscarTurno(int numero) //funcion para buscar un numero de turno en elarreglo de turnos, recibe por parametro el numero a buscar, devuelve
                                             // verdadero si el numero existe en el arreglo y falso en caso contrario
        {
            bool existe = false; //valor inicial a devolver
            int pos = 0; //primera posicion de arreglo
            //recorrer el arreglo hasta la posicion que tenga datos cargados
            while (pos < Cantidad)
            {
                //comparar el numero buscado con el numero de arreglo
                if (numero == turnos[pos].NumeroTurno)
                {
                    existe = true; //indica que el numero fue encontrado
                    break; //sale del ciclo while
                }
            } pos++; //proxima posicion del arreglo
            return existe; //devuelve v o f
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // primera consulta: cantidad de turnos registrados
            // se obtiene directamente de la variable "cantidad"
            txtCantTurnos.Text = Cantidad.ToString();
            // segunda consulta: se debe recorrer el arreglo y determinar el menor valor del campo "anio de fabricacion"
            int menor = int.MaxValue; //mayor valor posible
            int pos;
            //recorrer el arreglo hasta la posicion de datos
            for (pos = 0; pos < Cantidad; pos++)
            {
                //comparar el valor del elemento en el arreglo
                if (turnos[pos].AnioFabricacion < menor)
                {
                    menor = turnos[pos].AnioFabricacion; //guarda el menor valor
                }
            }
            //mostrar el resultado
            txtAñoAntiguo.Text = menor.ToString();
            // tercera consulta: cantidad de vehiculos con dominio de 6 caracteres
            int contador = 0;
            //recorrer el arreglo hasta la posicion de datos
            for (pos = 0; pos < Cantidad; pos++)
            {
                //controlar si la longitud del dominio es 6
                if (turnos[pos].Dominio.Length == 6)
                {
                    contador++; 
                }
            }
            //mostrar el resultado
            txtCantDominio.Text = contador.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } }
