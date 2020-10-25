using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de__inventarioGP2
{
    public partial class CUReportes : UserControl
    {
        public CUReportes()
        {
            InitializeComponent();
        }

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql
        

        private void CUReportes_Load(object sender, EventArgs e)
        {
            //dgvReporte.DataSource = cargartablareportes();
        }

        private void llbventasdeldia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cUcuadrediario1.BringToFront();
        }

        private void llbcuadremensual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cUcuadremensual1.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cUcreditos2.BringToFront();
        }

       
    }
}
