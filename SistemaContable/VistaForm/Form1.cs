using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empresa nuevaEmpresa;
        Jefe nuevoJefe;
        Empleado nuevoEmpleado;

        private void btnCreaerEmpresa_Click(object sender, EventArgs e)
        {
            nuevaEmpresa = new Empresa(nuevoJefe, txtNombreEmpresa.Text);

            btnCreaerEmpresa.Visible = false;
            
        }

        private void btnJefe_Click(object sender, EventArgs e)
        {
            nuevoJefe = new Jefe(txtNombreJefe.Text, txtApellidoJefe.Text, (short)numericEdadJefe.Value, txtDniJefe.Text,dateTimePickerIngresoJefe.Value);

        }

        private void btnInfoEmpresa_Click(object sender, EventArgs e)
        {
            richTextBoxEmpresa.Text = (string)nuevaEmpresa ;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Cargo carguito;
            Enum.TryParse<Cargo>(comboBoxCargo.SelectedValue.ToString(), out carguito);

            nuevoEmpleado = new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, (short)numericUpDownEdadEmpleado.Value, txtDniEmpleado.Text, carguito, txtLegajoEmpleado.Text, txtDireccionEmpleado.Text);
            txtNombreEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtDireccionEmpleado.Text = "";
            txtDniEmpleado.Text = "";
            txtLegajoEmpleado.Text = "";
            numericUpDownEdadEmpleado.Value = 18;

            nuevaEmpresa = nuevaEmpresa + nuevoEmpleado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCargo.DataSource = Enum.GetValues(typeof(Cargo));
        }

        private void btnInfoEmpleados_Click(object sender, EventArgs e)
        {
            if(nuevaEmpresa == nuevoEmpleado)
            richTextBoxEmpleados.Text = richTextBoxEmpleados.Text + nuevoEmpleado.ExponerDatos();
            
        }

        private void richTextBoxEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
