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
using System.Runtime.InteropServices;
using Capa_Gestion_de_seguridad;



namespace Sistema_de__inventarioGP2
{
    public partial class CUInforme : UserControl
    {
        public CUInforme()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void ResumenGenerado()
        {

            lblvalortotalventas.Text = VariablesReporte.valortotal.ToString("c");
            lblcomisionestotales.Text = VariablesReporte.comisiontotal.ToString("c");
            lblgananciatotal.Text = VariablesReporte.gananciatotal.ToString("c");
            lblgastostotales.Text = VariablesReporte.gastostotales.ToString("c");
            lblventasefectivo.Text = VariablesReporte.totalefectivo.ToString("c");
            lblventastarjeta.Text = VariablesReporte.totaltarjeta.ToString("c");
            lblventascredito.Text = VariablesReporte.totalcredito.ToString("c");



        }

        private void pbcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void CUInforme_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CUInforme_VisibleChanged(object sender, EventArgs e)
        {
            ResumenGenerado();
        }
    }
}
