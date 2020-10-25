using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Gestion_de_seguridad;
using System.Net.Mail;
using System.Net;

namespace Sistema_de__inventarioGP2
{
    public partial class correo : Form
    {
        public correo()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ServicioDeCcorreo = new Capa_Gestion_de_seguridad.ServicioDeCorreo();
            ServicioDeCcorreo.enviardecorreo(txtasunto.Text,txtcontenido.Text,txtcorreoreceptor.Text);

        }
    }
}
