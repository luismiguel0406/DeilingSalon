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
    public partial class CUrecordatorios : UserControl
    {
        public CUrecordatorios()
        {
            InitializeComponent();
        }

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CUrecordatorios cr = new CUrecordatorios();
            cr.Width = 35;

            if (this.Width==35)
            {
                cr.Width = 488;
            } 
        }
        public DataTable cargarrecordatorios()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT RECORDATORIO FROM RECORDATORIOS";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();
                
            }
            catch (Exception)
            {

                
            }

           
            return Tabla;

        }
        private void CUrecordatorios_Load(object sender, EventArgs e)
        {

            dgvrecordatorios.DataSource = cargarrecordatorios();
           
        }
    }
}
