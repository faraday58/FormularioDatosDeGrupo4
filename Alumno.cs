

using System;
using System.Runtime.InteropServices;

namespace FormularioDatosDeGrupo4
{
    class Alumno
    {
        #region Atributos
        private string nombre;
        private string numeroCuenta;
        private string materia;
        #endregion
        public Alumno(string nombre, string numeroCuenta, string materia)
        {
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            Materia = materia;
        }
        #region Propiedades
        public string Nombre { 
            get => nombre; 
            set
            {
                if( value == ""   )
                {
                    nombre = "Daniel";
                }
                else
                {
                    nombre = value;
                }
                
            }
                
        }
        public string NumeroCuenta { 
            get => numeroCuenta;
            set
            {
                if (value == "")
                {
                    numeroCuenta = GeneraNumeroCuenta();
                }
                else
                {
                    numeroCuenta = value;
                }
            }
        }
        public string Materia { 
            get => materia;
            set
            {
                if(value == ""  )
                {
                    materia = "Técnicas de Programación";
                }
                else
                {
                    materia = value;
                }
                
            }
        }
        #endregion
        public string GeneraNumeroCuenta()
        {
            string numerocuenta = "";
            Random aleatorio = new Random();
            for( int i=0; i<9; i++)
            {
                numerocuenta += aleatorio.Next(10);
            }
            return numerocuenta;

        }

    }
}
