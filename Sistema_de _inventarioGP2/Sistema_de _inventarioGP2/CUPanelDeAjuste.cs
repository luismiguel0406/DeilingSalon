using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de__inventarioGP2
{
    public partial class CUPanelDeAjuste : UserControl
    {
        public CUPanelDeAjuste()
        {
            InitializeComponent();
        }

       

        private void panelreporteventa_Click(object sender, EventArgs e)
        {

        }

        private void panelusuario_Click(object sender, EventArgs e)
        {
            
        }

        private void CUPanelDeAjuste_Load(object sender, EventArgs e)
        {
            cUajustes1.Hide();
            cuusuarios1.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btdatosempresa_Click(object sender, EventArgs e)
        {
            cUajustes1.Show();
            cUajustes1.BringToFront();
        }

        private void btusuarioajuste_Click(object sender, EventArgs e)
        {
            cuusuarios1.Show();
            cuusuarios1.BringToFront();
        }
    }
}
