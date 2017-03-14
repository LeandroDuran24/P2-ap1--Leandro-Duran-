using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParcialTech.Consultas;
using ParcialTech.Registros;

namespace ParcialTech
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosForm em = new EmpleadosForm();
            em.Show();
        }

        

        private void tiposEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposEmailForm tf = new TiposEmailForm();
            tf.Show();
        }

       
        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEmpleados ce = new ConsultaEmpleados();
            ce.Show();
        }
    }
}
