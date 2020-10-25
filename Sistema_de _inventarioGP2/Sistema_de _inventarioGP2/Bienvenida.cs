using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Gestion_de_seguridad;

namespace Sistema_de__inventarioGP2
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
        int vista = 0;
        private void Bienvenida_Load(object sender, EventArgs e)
        {
            lblbienvenida.Text = (cachelogin.nombre+" "+cachelogin.apellido).ToLowerInvariant();
            this.Opacity = 0.0;
            tmaparecer.Start();
            
            
        }

        private void tmaparecer_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1) this.Opacity += 0.05;
            vista += 1;
            if (vista==100)
            {
                tmaparecer.Stop();
                tmdesaparecer.Start();
            }

        }

        private void tmdesaparecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity== 0)
            {
                tmdesaparecer.Stop();
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
