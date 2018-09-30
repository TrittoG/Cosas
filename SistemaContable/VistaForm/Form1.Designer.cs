namespace VistaForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxEmpresa = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreaerEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreJefe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellidoJefe = new System.Windows.Forms.TextBox();
            this.dateTimePickerIngresoJefe = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDniJefe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxEmpleados = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.txtLegajoEmpleado = new System.Windows.Forms.TextBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnInfoEmpresa = new System.Windows.Forms.Button();
            this.btnInfoEmpleados = new System.Windows.Forms.Button();
            this.btnJefe = new System.Windows.Forms.Button();
            this.numericEdadJefe = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEdadEmpleado = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdadJefe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdadEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInfoEmpresa);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtNombreEmpresa);
            this.tabPage1.Controls.Add(this.btnCreaerEmpresa);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBoxEmpresa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empresa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInfoEmpleados);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.richTextBoxEmpleados);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxEmpresa
            // 
            this.richTextBoxEmpresa.Location = new System.Drawing.Point(388, 24);
            this.richTextBoxEmpresa.Name = "richTextBoxEmpresa";
            this.richTextBoxEmpresa.Size = new System.Drawing.Size(415, 385);
            this.richTextBoxEmpresa.TabIndex = 0;
            this.richTextBoxEmpresa.Text = "";
            this.richTextBoxEmpresa.TextChanged += new System.EventHandler(this.richTextBoxEmpresa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la empresa";
            // 
            // btnCreaerEmpresa
            // 
            this.btnCreaerEmpresa.Location = new System.Drawing.Point(21, 386);
            this.btnCreaerEmpresa.Name = "btnCreaerEmpresa";
            this.btnCreaerEmpresa.Size = new System.Drawing.Size(49, 23);
            this.btnCreaerEmpresa.TabIndex = 8;
            this.btnCreaerEmpresa.Text = "Crear";
            this.btnCreaerEmpresa.UseVisualStyleBackColor = true;
            this.btnCreaerEmpresa.Click += new System.EventHandler(this.btnCreaerEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 867;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(151, 43);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(170, 20);
            this.txtNombreEmpresa.TabIndex = 1;
            // 
            // txtNombreJefe
            // 
            this.txtNombreJefe.Location = new System.Drawing.Point(100, 25);
            this.txtNombreJefe.Name = "txtNombreJefe";
            this.txtNombreJefe.Size = new System.Drawing.Size(200, 20);
            this.txtNombreJefe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericEdadJefe);
            this.groupBox1.Controls.Add(this.btnJefe);
            this.groupBox1.Controls.Add(this.txtDniJefe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePickerIngresoJefe);
            this.groupBox1.Controls.Add(this.txtApellidoJefe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreJefe);
            this.groupBox1.Location = new System.Drawing.Point(21, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 254);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JEFE";
            // 
            // txtApellidoJefe
            // 
            this.txtApellidoJefe.Location = new System.Drawing.Point(100, 66);
            this.txtApellidoJefe.Name = "txtApellidoJefe";
            this.txtApellidoJefe.Size = new System.Drawing.Size(200, 20);
            this.txtApellidoJefe.TabIndex = 3;
            // 
            // dateTimePickerIngresoJefe
            // 
            this.dateTimePickerIngresoJefe.Location = new System.Drawing.Point(100, 191);
            this.dateTimePickerIngresoJefe.Name = "dateTimePickerIngresoJefe";
            this.dateTimePickerIngresoJefe.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIngresoJefe.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DNI";
            // 
            // txtDniJefe
            // 
            this.txtDniJefe.Location = new System.Drawing.Point(100, 147);
            this.txtDniJefe.Name = "txtDniJefe";
            this.txtDniJefe.Size = new System.Drawing.Size(200, 20);
            this.txtDniJefe.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownEdadEmpleado);
            this.groupBox2.Controls.Add(this.btnAgregarEmpleado);
            this.groupBox2.Controls.Add(this.txtLegajoEmpleado);
            this.groupBox2.Controls.Add(this.comboBoxCargo);
            this.groupBox2.Controls.Add(this.txtDireccionEmpleado);
            this.groupBox2.Controls.Add(this.txtDniEmpleado);
            this.groupBox2.Controls.Add(this.txtApellidoEmpleado);
            this.groupBox2.Controls.Add(this.txtNombreEmpleado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(37, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleados Datos";
            // 
            // richTextBoxEmpleados
            // 
            this.richTextBoxEmpleados.Location = new System.Drawing.Point(37, 216);
            this.richTextBoxEmpleados.Name = "richTextBoxEmpleados";
            this.richTextBoxEmpleados.Size = new System.Drawing.Size(747, 186);
            this.richTextBoxEmpleados.TabIndex = 1;
            this.richTextBoxEmpleados.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Empleados Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Edad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cargo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(333, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Legajo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Direccion";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(112, 12);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(120, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(112, 45);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(120, 20);
            this.txtApellidoEmpleado.TabIndex = 2;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.Location = new System.Drawing.Point(112, 81);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(120, 20);
            this.txtDniEmpleado.TabIndex = 9;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(112, 110);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(120, 20);
            this.txtDireccionEmpleado.TabIndex = 10;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(391, 43);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargo.TabIndex = 12;
            // 
            // txtLegajoEmpleado
            // 
            this.txtLegajoEmpleado.Location = new System.Drawing.Point(391, 81);
            this.txtLegajoEmpleado.Name = "txtLegajoEmpleado";
            this.txtLegajoEmpleado.Size = new System.Drawing.Size(121, 20);
            this.txtLegajoEmpleado.TabIndex = 13;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(558, 45);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(156, 56);
            this.btnAgregarEmpleado.TabIndex = 14;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnInfoEmpresa
            // 
            this.btnInfoEmpresa.Location = new System.Drawing.Point(99, 360);
            this.btnInfoEmpresa.Name = "btnInfoEmpresa";
            this.btnInfoEmpresa.Size = new System.Drawing.Size(270, 49);
            this.btnInfoEmpresa.TabIndex = 9;
            this.btnInfoEmpresa.Text = "Mostrar Informacion de la Empresa";
            this.btnInfoEmpresa.UseVisualStyleBackColor = true;
            this.btnInfoEmpresa.Click += new System.EventHandler(this.btnInfoEmpresa_Click);
            // 
            // btnInfoEmpleados
            // 
            this.btnInfoEmpleados.Location = new System.Drawing.Point(123, 193);
            this.btnInfoEmpleados.Name = "btnInfoEmpleados";
            this.btnInfoEmpleados.Size = new System.Drawing.Size(260, 20);
            this.btnInfoEmpleados.TabIndex = 3;
            this.btnInfoEmpleados.Text = "Mostrar Informacion de Empleados";
            this.btnInfoEmpleados.UseVisualStyleBackColor = true;
            this.btnInfoEmpleados.Click += new System.EventHandler(this.btnInfoEmpleados_Click);
            // 
            // btnJefe
            // 
            this.btnJefe.Location = new System.Drawing.Point(20, 225);
            this.btnJefe.Name = "btnJefe";
            this.btnJefe.Size = new System.Drawing.Size(308, 23);
            this.btnJefe.TabIndex = 7;
            this.btnJefe.Text = "Agregar Jefe";
            this.btnJefe.UseVisualStyleBackColor = true;
            this.btnJefe.Click += new System.EventHandler(this.btnJefe_Click);
            // 
            // numericEdadJefe
            // 
            this.numericEdadJefe.Location = new System.Drawing.Point(100, 105);
            this.numericEdadJefe.Name = "numericEdadJefe";
            this.numericEdadJefe.Size = new System.Drawing.Size(200, 20);
            this.numericEdadJefe.TabIndex = 4;
            // 
            // numericUpDownEdadEmpleado
            // 
            this.numericUpDownEdadEmpleado.Location = new System.Drawing.Point(391, 12);
            this.numericUpDownEdadEmpleado.Name = "numericUpDownEdadEmpleado";
            this.numericUpDownEdadEmpleado.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEdadEmpleado.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdadJefe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdadEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNombreJefe;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreaerEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxEmpresa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellidoJefe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngresoJefe;
        private System.Windows.Forms.TextBox txtDniJefe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLegajoEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnInfoEmpresa;
        private System.Windows.Forms.Button btnInfoEmpleados;
        private System.Windows.Forms.Button btnJefe;
        private System.Windows.Forms.NumericUpDown numericEdadJefe;
        private System.Windows.Forms.NumericUpDown numericUpDownEdadEmpleado;
    }
}

