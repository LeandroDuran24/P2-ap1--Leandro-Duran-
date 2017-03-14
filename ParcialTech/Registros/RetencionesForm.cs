using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entidades;

namespace ParcialTech.Registros
{
    public partial class RetencionesForm : Form
    {
        public RetencionesForm()
        {
            InitializeComponent();
        }

        private void RetencionesForm_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            textBoxDescripcion.Clear();
            errorProvider1.Clear();
            maskedTextBoxId.Clear();
            maskedTextBoxValor.Clear();

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                errorProvider1.SetError(textBoxDescripcion, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(maskedTextBoxValor.Text))
            {
                errorProvider1.SetError(maskedTextBoxValor, "Favor Llenar");
                return false;
            }
            return true;

        }

        public Retenciones LlenarCampos()
        {
            var lleno = new Retenciones();
            lleno.RetencionId = Utilidades.TOINT(maskedTextBoxId.Text);
            lleno.Descripcion = textBoxDescripcion.Text;
            lleno.Valor = Utilidades.TOINT(maskedTextBoxValor.Text);
            return lleno;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);
            Retenciones eliminar = BLL.RetencionesBLL.Buscar(p => p.RetencionId == id);

            if (eliminar != null)
            {
                BLL.RetencionesBLL.Eliminar(eliminar);
                MessageBox.Show("Correcto");

            }
            else

                MessageBox.Show("Error");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;
            var guardo = new Retenciones();
            if (!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                guardo = LlenarCampos();
                if (id != guardo.RetencionId)
                {
                    BLL.RetencionesBLL.Mofidicar(guardo);
                    MessageBox.Show("Modificado");

                }
                else
                {
                    BLL.RetencionesBLL.Guardar(guardo);
                    MessageBox.Show("Correcto");
                }
                Limpiar();
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);
            Retenciones busca = BLL.RetencionesBLL.Buscar((p => p.RetencionId == id));

            if (busca != null)
            {
                textBoxDescripcion.Text = busca.Descripcion;
                maskedTextBoxValor.Text = Convert.ToString(busca.Valor);
                MessageBox.Show("Correcto");

            }
            else

            {
                MessageBox.Show("No existe");
            }

        }
    }
}
