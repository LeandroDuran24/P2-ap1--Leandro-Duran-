using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace ParcialTech.Registros
{
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            maskedTextBoxId.Clear();
            maskedTextBoxSueldo.Clear();
            textBoxNombres.Clear();
            errorProvider1.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }


        public bool Validar()
        {
            if (string.IsNullOrEmpty(maskedTextBoxSueldo.Text))
            {
                errorProvider1.SetError(maskedTextBoxSueldo, "Favor Llenar");
                return false;
            }
            if (string.IsNullOrEmpty(textBoxNombres.Text))
            {
                errorProvider1.SetError(textBoxNombres, "Favor Llenar");
                return false;
            }
            return true;
        }

        public Empleados LlenarCampos()
        {
            Empleados guarda = new Empleados();
            guarda.EmpleadoId = Utilidades.TOINT(maskedTextBoxId.Text);
            guarda.Nombres = textBoxNombres.Text;
            guarda.FechaNacimiento = dateTimePicker1.Value;
            guarda.Sueldo = Utilidades.TOINT(maskedTextBoxSueldo.Text);
            return guarda;
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;
            var guardo = new Empleados();
            if (!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                guardo = LlenarCampos();
                if (id != guardo.EmpleadoId)
                {
                    BLL.EmpleadosBLL.Mofidicar(guardo);
                    MessageBox.Show("Modificado");

                }
                else
                {
                    BLL.EmpleadosBLL.Guardar(guardo);
                    MessageBox.Show("Correcto");
                }
                Limpiar();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);
            Empleados eliminar = BLL.EmpleadosBLL.Buscar(p => p.EmpleadoId == id);

            if (eliminar != null)
            {
                BLL.EmpleadosBLL.Eliminar(eliminar);
                MessageBox.Show("Correcto");

            }
            else

                MessageBox.Show("Error");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);



            Empleados busca = BLL.EmpleadosBLL.Buscar((p => p.EmpleadoId == id));

            if (busca != null)
            {
                textBoxNombres.Text = busca.Nombres;
                maskedTextBoxSueldo.Text = Convert.ToString(busca.Sueldo);
                MessageBox.Show("Correcto");

            }
            else

            {
                MessageBox.Show("No existe");
            }


        }
    }
}
