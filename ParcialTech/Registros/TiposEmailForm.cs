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
    public partial class TiposEmailForm : Form
    {
        public TiposEmailForm()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            textBoxDescripcion.Clear();
            errorProvider1.Clear();
            maskedTextBoxId.Clear();

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                errorProvider1.SetError(textBoxDescripcion, "Favor Llenar");
                return false;
            }

            return true;

        }

        public TiposEmail LlenarCampos()
        {
            var lleno = new TiposEmail();
            lleno.TipoId = Utilidades.TOINT(maskedTextBoxId.Text);
            lleno.Descripcion = textBoxDescripcion.Text;

            return lleno;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);
            TiposEmail busca = BLL.TiposEmailBLL.Buscar((p => p.TipoId == id));

            if (busca != null)
            {
                textBoxDescripcion.Text = busca.Descripcion;
                MessageBox.Show("Correcto");

            }
            else

            {
                MessageBox.Show("No existe");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;
            var guardo = new TiposEmail();
            if (!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                guardo = LlenarCampos();
                if (id != guardo.TipoId)
                {
                    BLL.TiposEmailBLL.Mofidicar(guardo);
                    MessageBox.Show("Modificado");

                }
                else
                {
                    BLL.TiposEmailBLL.Guardar(guardo);
                    MessageBox.Show("Correcto");
                }
                Limpiar();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(maskedTextBoxId.Text);
            TiposEmail eliminar = BLL.TiposEmailBLL.Buscar(p => p.TipoId == id);

            if (eliminar != null)
            {
                BLL.TiposEmailBLL.Eliminar(eliminar);
                MessageBox.Show("Correcto");

            }
            else

                MessageBox.Show("Error");
        }
    }
}
