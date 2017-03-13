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
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
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

        public bool ValidarCombo()
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "favor Llenar");
                return false;
            }
            return true;
        }

        public void LLenarCombo()
        {
            comboBox1.Items.Insert(0, "Id");
            comboBox1.Items.Insert(1, "Nombres");
            comboBox1.Items.Insert(2, "Fecha");
            comboBox1.Items.Insert(3, "Sueldo");
            comboBox1.Items.Insert(4, "Todos");
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
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList(p => p.EmpleadoId == Utilidades.TOINT(BuscartextBox.Text));
                }
            }
            else
            if (comboBox1.SelectedIndex == 1)
            {
                if (!Validar())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList(p => p.Nombres == BuscartextBox.Text);
                }
            }
            else
            if (comboBox1.SelectedIndex == 2)
            {
                if (desdedateTimePicker.Value.Date > hastadateTimePicker.Value.Date)
                {
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList(p => p.FechaNacimiento >= desdedateTimePicker.Value.Date && p.FechaNacimiento <= hastadateTimePicker.Value.Date);
                }

            }
            else
            if (comboBox1.SelectedIndex == 3)
            {
                if(!Validar())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                   
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList(p => p.Sueldo == Convert.ToDouble(BuscartextBox.Text));
                }
            }
            else
            {
                if (!ValidarCombo())
                {
                    dataGridView1.DataSource = BLL.RetencionesBLL.GetListTodo();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
