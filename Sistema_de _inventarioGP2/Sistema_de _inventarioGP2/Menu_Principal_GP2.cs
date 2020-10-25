using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//mover el formulario
using System.Data.SqlClient;//servicios sql
using System.IO;
using Capa_Gestion_de_seguridad;

namespace Sistema_de__inventarioGP2
{
    public partial class Menu_Principal_GP2 : Form
    {
        public Menu_Principal_GP2()
        {
            InitializeComponent();
        }

      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);


        
        private static Menu_Principal_GP2 instancia = null;
        public static Menu_Principal_GP2 obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new Menu_Principal_GP2();

            }
            return instancia;
        }

        //variables sql
        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();



        //variable para que el menu aparezca lentamente
        int vista = 0;

        public void Notificacion(){
            try
            {
                int personas = 0;

                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM CLIENTES WHERE CUMPLEAÑOS ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                personas = Tabla.Rows.Count;
                ConBD.cerrarconexion();
                lblnotificacion.Text = personas.ToString();
            }
            catch (Exception)
            {

                return;
            }
            

        }
        public void privilegios()
        {
            if (cachelogin.privilegios=="Standar")
            {
                btpanelajuste.Enabled = false;
                Btproveedores.Enabled = false;
                Btinventario.Enabled = false;
                Btreportes.Enabled = true;
                btgestionempleados.Enabled = false;
                btservicios.Enabled = false;

            }

        }
               

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Cerrar Sesion?" , "Cerrar Sesion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning ) == DialogResult.Yes)
            {
              //  this.Dispose();// se agrego este dispose
                this.Close();

                LoginGP2 Flogin = new LoginGP2();
                Flogin.Show();

            }


        }

        private void Menu_Principal_GP2_Load(object sender, EventArgs e)
        {
            datosusuario();
            this.Opacity = 0.0;
            tmaparecermenu.Start();
            Notificacion();
            privilegios();
            ocultartodos();
            
                      
        }
        private void datosusuario()
        {
            lblnombreusuario.Text = cachelogin.nombre + " " + cachelogin.apellido;
            lblcargo.Text = cachelogin.cargo;
            lblprivilegios.Text = cachelogin.privilegios;
            
        }


       
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // algunos efectos para cuando el mouse pase por encima
        private void Btfacturacion_MouseMove(object sender, MouseEventArgs e)
        {//boton ventas
            Btventas.BackColor = Color.White;
            Btventas.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void Btclientes_MouseMove(object sender, MouseEventArgs e)
        {
            Btclientes.BackColor = Color.White;
            Btclientes.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void Btinventario_MouseMove(object sender, MouseEventArgs e)
        {
            Btinventario.BackColor = Color.White;
            Btinventario.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void Btproveedores_MouseMove(object sender, MouseEventArgs e)
        {
            Btproveedores.BackColor = Color.White;
            Btproveedores.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void Btfacturacion_MouseLeave(object sender, EventArgs e)
        {//boton ventas
            Btventas.ForeColor = Color.White;
            Btventas.BackColor = Color.FromArgb(255, 200, 33);
        }

        private void Btproveedores_MouseLeave(object sender, EventArgs e)
        {
            Btproveedores.ForeColor = Color.White;
            Btproveedores.BackColor = Color.FromArgb(255, 200, 33);
        }

        private void Btclientes_MouseLeave(object sender, EventArgs e)
        {
            Btclientes.ForeColor = Color.White;
            Btclientes.BackColor = Color.FromArgb(255, 200, 33);
        }

        private void Btinventario_MouseLeave(object sender, EventArgs e)
        {
            Btinventario.ForeColor = Color.White;
            Btinventario.BackColor = Color.FromArgb(255, 200, 33);
        }

       
        private void Btreportes_MouseMove(object sender, MouseEventArgs e)
        {
            Btreportes.BackColor = Color.White;
            Btreportes.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void Btreportes_MouseLeave(object sender, EventArgs e)
        {
            Btreportes.ForeColor = Color.White;
            Btreportes.BackColor = Color.FromArgb(255, 200, 33);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void tmaparecermenu_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            vista += 1;
            if (vista == 100)
            {
                tmaparecermenu.Stop();
                
            }

        }

        private void Btreportes_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = Btreportes.Top;
            cuReportes1.Show();
            cuReportes1.BringToFront();
          
            
          
            //System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
                

                      
        private void bgestionempleados_MouseMove(object sender, MouseEventArgs e)
        {
            btgestionempleados.BackColor = Color.White;
            btgestionempleados.ForeColor= Color.FromArgb(255, 200, 33);
        }

        private void bgestionempleados_MouseLeave(object sender, EventArgs e)
        {
            btgestionempleados.ForeColor = Color.White;
            btgestionempleados.BackColor = Color.FromArgb(255, 200, 33);
        }

       
      
        private void Btventas_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible==false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = Btventas.Top;
            cUfacturacion1.Show();
            cUfacturacion1.BringToFront();
        }

        private void Btinventario_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = Btinventario.Top;
            cUinventario2.Show();
            cUinventario2.BringToFront();
        }

        private void Btclientes_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = Btclientes.Top;
            cUclientes2.Show();
            cUclientes2.BringToFront();
        }

        private void btservicios_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = btservicios.Top;
            cuServicios1.Show();
            cuServicios1.BringToFront();
        }

    
        private void Btproveedores_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = Btproveedores.Top;
            cUproveedores2.Show();
            cUproveedores2.BringToFront();
        }

        private void Menu_Principal_GP2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Principal_GP2.instancia = null;
        }

        private void btgestionempleados_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = btgestionempleados.Top;
            cUgestion_empleados1.Show();
            cUgestion_empleados1.BringToFront();
        }

       

        private void btservicios_MouseMove(object sender, MouseEventArgs e)
        {
            btservicios.BackColor = Color.White;
            btservicios.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void btservicios_MouseLeave(object sender, EventArgs e)
        {
            btservicios.ForeColor = Color.White;
            btservicios.BackColor = Color.FromArgb(255, 200, 33);
        }

      

        private  void ocultartodos()
        {
            sidepanel.Visible = false;
            //cuusuarios1.Hide();
            cUgestion_empleados1.Hide();
            cUproveedores2.Hide();
            cuServicios1.Hide();
            cUclientes2.Hide();
            cUinventario2.Hide();
            cUfacturacion1.Hide();
            cuPanelDeAjuste1.Hide();
            cuReportes1.Hide();
            //cuInforme1.Hide();
            cUgastos1.Hide();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocultartodos();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUgastos1.Show();
            cUgastos1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {   // formulario correo
            correo CORREO = new correo();
            CORREO.Show();
        }

        private void bgastos_Click(object sender, EventArgs e)
        {
            if (sidepanel.Visible == false)
            {
                sidepanel.Visible = true;

            }
            sidepanel.Top = bgastos.Top;
            sidepanel.BringToFront();//corregir un pequeño error
            cUgastos1.Show();
            cUgastos1.BringToFront();
        }

        private void bgastos_MouseMove(object sender, MouseEventArgs e)
        {
            bgastos.BackColor = Color.White;
            bgastos.ForeColor = Color.FromArgb(255, 200, 33);
        }

        private void bgastos_MouseLeave(object sender, EventArgs e)
        {
            bgastos.ForeColor = Color.White;
            bgastos.BackColor = Color.FromArgb(255, 200, 33);
        }

        private void btpanelajuste_Click(object sender, EventArgs e)
        {
            cuPanelDeAjuste1.Show();
            cuPanelDeAjuste1.BringToFront();

        }
    }
}
