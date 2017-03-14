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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void retencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetencionesForm rt = new RetencionesForm();
            rt.Show(); 
        }

        private void tiposEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposEmailForm t = new TiposEmailForm();
            t.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosForm em = new EmpleadosForm();
            em.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEmpleados ce = new ConsultaEmpleados();
            ce.Show();
        }
    }
}
