using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Consultas
{
    public partial class ConsultaTipos : Form
    {
        public ConsultaTipos()
        {
            InitializeComponent();
            LLenarCombo();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(BuscartextBox.Text))
            {
                errorProvider1.SetError(BuscartextBox, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Favor Llenar");
                return false;
            }
            return true;
        }

        public void LLenarCombo()
        {
            comboBox1.Items.Insert(0, "Id");
            comboBox1.Items.Insert(1, "Descripcion");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Id";

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = -1;

        }

        public void Seleccionar()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (!Validar())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.RetencionesBLL.GetList(p => p.RetencionesId == Utilidades.TOINT(BuscartextBox.Text));
                }
            }
            else

            {
                if (!Validar())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.RetencionesBLL.GetList(p => p.Descripcion == BuscartextBox.Text);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
