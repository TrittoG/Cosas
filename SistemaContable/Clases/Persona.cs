using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;
        private string apellido;
        private string dni;

        /// <summary>
        /// Unico Constructor que recive todos los parametros de la clase
        /// </summary>
        /// <param name="edad"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(short edad, string nombre, string apellido, string dni)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
        }

        /// <summary>
        /// propiedad de lectura/escritura para el dni, aqui dentro se valida el dni ingresado
        /// </summary>
        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if(ValidarDni(value))
                {
                    this.dni = value;
                }
            }

        }

        /// <summary>
        /// propiedad de solo lectura que devuelve el dni
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// propiedad de solo lectura que devuelve el apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// propiedad de solo lectura que devuelve la edad
        /// </summary>
        public short Edad
        {
            get
            {
                return this.edad;
            }
        }


        protected abstract bool ValidarDni(string dni);

        public virtual string ExponerDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("*******************************************");
            str.AppendLine("Nombre: " + this.Nombre);
            str.AppendLine("Apellido: " + this.Apellido);
            str.AppendLine("Edad: " + this.Edad + " Años");
            str.AppendLine("Dni: " + this.Dni);

            return str.ToString();
        }


       
    }
}
