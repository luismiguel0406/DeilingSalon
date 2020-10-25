using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistema_de__inventarioGP2
{
    public partial class CUgestion_empleados : UserControl
    {
        public CUgestion_empleados()
        {
            InitializeComponent();
        }
        

        private void llbdatos_empleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cuDatosempleado2.BringToFront();
        }

        private void llbsueldos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cUsueldos_e_ingresos1.BringToFront();
        }
    }
}

