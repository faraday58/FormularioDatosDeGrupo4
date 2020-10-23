using System;
using System.Windows.Forms;

namespace FormularioDatosDeGrupo4
{
    public partial class Form1 : Form
    {
        Alumno[] alumnos;
        int indice;
        public Form1()
        {
            InitializeComponent();
            alumnos = new Alumno[3];
        }

        public int Indice { 
            get => indice;
            set
            {
                if(value >=3)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombreAlumno.Text;
            string numeroCuenta = txtbNumeroCuenta.Text;
            string materia = txtbMateria.Text;
            alumnos[Indice++] = new Alumno(nombre, numeroCuenta, materia);
            MessageBox.Show("Alumno agregado");
            txtbNombreAlumno.Clear();
            txtbNumeroCuenta.Clear();
            txtbMateria.Clear();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {

                txtbNombreAlumno.Text = alumnos[Indice].Nombre;
                txtbNumeroCuenta.Text = alumnos[Indice].NumeroCuenta;
                txtbMateria.Text = alumnos[Indice].Materia;
                Indice++;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No se tienen registrados suficientes alumnos");
            }
        }
    }

}
