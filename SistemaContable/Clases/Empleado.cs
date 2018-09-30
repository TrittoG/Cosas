using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado : Persona
    {
        private Cargo cargo;
        private string legajo;
        private string direccion;

        public Empleado(string nombre, string apellido, short edad, string dni, Cargo cargo, string legajo, string direccion) : base(edad, nombre,apellido,dni)
        {
            this.cargo = cargo;
            this.legajo = legajo;
            this.direccion = direccion;
        }

        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
        }

        public string Legajo
        {
            get
            {
                return this.legajo;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }

        }

        protected override bool ValidarDni(string dni)
        {
            if (dni.Length == 8 || dni.Length == 7)
            {
                for (int i = 0; i < dni.Length; i++)
                {
                    if (dni[i] < '0' || dni[i] > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override string ExponerDatos()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("***empleado***");
            st.AppendLine(base.ExponerDatos());
            st.AppendLine("Cargo: " + this.Cargo.ToString());
            st.AppendLine("Legajo: " + this.Legajo);
            st.AppendLine("Direccion: " + this.Direccion);

            return st.ToString();
        }
    }
}
