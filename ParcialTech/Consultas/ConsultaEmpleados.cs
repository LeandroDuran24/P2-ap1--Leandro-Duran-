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

        public void Limpiar()
        {
            BuscartextBox.Clear();
            errorProvider1.Clear();
            comboBox1.Text = null;
            desdedateTimePicker.Value = DateTime.Today;
            hastadateTimePicker.Value = DateTime.Today;
        }

        public void LLenarCombo()
        {

            comboBox1.Items.Insert(0, "Nombres");
            comboBox1.Items.Insert(1, "Fecha");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombres";

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
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList(p => p.Nombres == BuscartextBox.Text);
                    
                }
            }
            else     
            {
               
                if (desdedateTimePicker.Value.Date < hastadateTimePicker.Value.Date)
                {
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList(p => p.FechaNacimiento >= desdedateTimePicker.Value.Date && p.FechaNacimiento <= hastadateTimePicker.Value.Date);

                    button1.Focus();
                }
                else
                {
                    MessageBox.Show("Poner intervalo de Fecha bien");
                }

            }
            Limpiar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void desdedateTimePicker_EnabledChanged(object sender, EventArgs e)
        {
         
        }

        private void hastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
