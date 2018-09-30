using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jefe : Persona
    {
        private DateTime fechaingreso;

        //Constructores

        public Jefe(string nombre, string apellido, short edad, string dni) : base(edad,nombre,apellido,dni)
        {
            DateTime hoy = DateTime.Today;
            this.fechaingreso = hoy;
        }

        public Jefe(string nombre, string apellido, short edad, string dni, DateTime ingreso) : this(nombre,apellido,edad,dni)
        {
            this.fechaingreso = ingreso;
        }


        /// <summary>
        /// propiedad que calcula la antiguedad en el puesto
        /// </summary>
        public int Antiguedad
        {
            get
            {
                //creo una fecha actual
                DateTime hoy = DateTime.Today;

                //creo un dias y a la fecha actual le resto la fecha de ingreso
                TimeSpan dias = hoy.Subtract(fechaingreso);

                //retorno los dias desde que entro al cargo
                return dias.Days;
            }
        }

        /// <summary>
        /// muestra los datos del jefe llamando al exponer datos de la base persona
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("*** JEFE ***");
            st.AppendLine(base.ExponerDatos());
            st.AppendLine("Dias en el cargo: " + this.Antiguedad);

            return st.ToString();
        }

        /// <summary>
        /// valida que el dni sea correcto, la base detecta si es jefe para implementar esta funcion
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        protected override bool ValidarDni(string dni)
        {
            if(dni.Length == 8 || dni.Length == 7)
            {
                for(int i = 0; i< dni.Length; i++)
                {
                    if(dni[i] < '0' || dni[i] > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


    }
}
