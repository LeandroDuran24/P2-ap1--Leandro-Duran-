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
        Empleados empleado;
        public EmpleadosForm()
        {
            InitializeComponent();
            LlenarCombo();
            Limpiar();
        }
        private void EmpleadosForm_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            maskedTextBoxId.Clear();
            maskedTextBoxSueldo.Clear();
            textBoxNombres.Clear();
            errorProvider1.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dataGridViewRetencion.DataSource = null;
            empleado = new Empleados();
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
            guarda.RetencionId = Utilidades.TOINT(comboBoxRetencion.SelectedValue.ToString());
            return guarda;
        }

        public void LLenarData(Empleados nuevo)
        {
            dataGridViewRetencion.DataSource = null;
            dataGridViewRetencion.DataSource = nuevo.retencionList;
        }

        public void LlenarCombo()
        {
            List<Retenciones> lista = BLL.RetencionesBLL.GetListTodo();
            comboBoxRetencion.DataSource = lista;
            comboBoxRetencion.DisplayMember = "Descripcion";
            comboBoxRetencion.ValueMember = "RetencionId";

            if (comboBoxRetencion.Items.Count > 0)
                comboBoxRetencion.SelectedIndex = -1;
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

        private void AgregarRetencion_Click(object sender, EventArgs e)
        {
            Retenciones lista = new Retenciones();
            lista = (Retenciones)comboBoxRetencion.SelectedItem;
            empleado.retencionList.Add(lista);
            LLenarData(empleado);
        }


    }
}
