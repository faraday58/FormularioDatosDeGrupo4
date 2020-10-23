

using System;

namespace FormularioDatosDeGrupo4
{
    class Alumno
    {
        private string nombre;
        private string numeroCuenta;
        private string materia;

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
        public string Materia { get => materia; set => materia = value; }

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
