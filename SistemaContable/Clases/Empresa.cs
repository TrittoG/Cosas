using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empresa
    {
        private List<Empleado> empleados;
        private Jefe jefe;
        private string nombreEmpresa;

        private Empresa()
        {
            this.empleados = new List<Empleado>();
        }

        public Empresa(Jefe jefe, string nombre) :this()
        {
            this.jefe = jefe;
            this.nombreEmpresa = nombre;
        }

        public string NombreEmpresa
        {
            get
            {
                return this.nombreEmpresa;
            }
        }

        public static explicit operator string(Empresa e)
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine("*** Nombre De la Empresa: " + e.NombreEmpresa + " ***");
            st.AppendLine(e.jefe.ExponerDatos());

            st.AppendLine("");
            foreach(Empleado em in e.empleados)
            {
                st.AppendLine(em.ExponerDatos());
            }

            return st.ToString();
        }

        public static bool operator ==(Empresa e, Empleado em)
        {
            foreach(Empleado emple in e.empleados)
            {
                if(emple.Dni == em.Dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Empresa e, Empleado em)
        {
            return !(e == em);
        }

        public static Empresa operator +(Empresa e, Empleado em)
        {
            if(e != em)
            {
                e.empleados.Add(em);
                return e;
            }
            return e;
        }   
    }
}
