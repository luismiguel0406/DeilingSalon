using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;// se agrega este using para poder usar las consultas de SQL
using Capa_Gestion_de_seguridad;// referencia capa de seguridad

namespace Sistema_de__inventarioGP2
{
    public partial class LoginGP2 : Form
    {
        public LoginGP2()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;

        // cosas que se usaran en sql

        //public string cnn()
        //{
        //    return System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        //}

     
        public bool login (string nombre,string contraseña)
        {
                       
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM USUARIOS WHERE NOMBRE_DE_USUARIO ='" + txtusuario.Text + "' AND CONTRASENA ='" + txtcontraseña.Text + "' ";
                Comando.Parameters.AddWithValue(nombre,txtusuario.Text);
                Comando.Parameters.AddWithValue(contraseña,txtcontraseña.Text);
                Comando.CommandType = CommandType.Text;

            try
            {
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cachelogin.idusuario = lector.GetInt32(0);
                        cachelogin.nombre = lector.GetString(1);
                        cachelogin.apellido = lector.GetString(2);
                        cachelogin.nombre_usuario = lector.GetString(3);
                        cachelogin.contrasena = lector.GetString(4);
                        cachelogin.cargo = lector.GetString(5);
                        cachelogin.privilegios = lector.GetString(6);

                    }

                    // En esta linea de abajo se oculta el formulario login si las credenciales estan correctas
                    this.Hide();
                    Bienvenida bienvenida = new Bienvenida();
                    bienvenida.ShowDialog();
                    Menu_Principal_GP2 Fmenu = Menu_Principal_GP2.obtener_instancia();
                    Fmenu.Show();
                    ConBD.cerrarconexion();//se agrego esto 
                   // return true;

                }
                return true;
                
            }
            
            catch (Exception)
            {

                MessageBox.Show("Usuario o contraseña invalida", "Inicio De Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontraseña.Clear();
                txtcontraseña.UseSystemPasswordChar = true;
                txtusuario.Clear();
                //se agrego limpiar los parametros para verificar el error de el inicio de sesion que no te deja entrar
                // si escribes la primera contraseña mal
                Comando.Parameters.Clear();
                txtusuario.Focus();
                ConBD.cerrarconexion();
                return false;
                
            }
   

        }
       
               
        private void LoginGP2_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void Btcancelar_MouseMove(object sender, MouseEventArgs e)
        {
            Btcancelar.BackColor = Color.Red;
            Btcancelar.ForeColor = Color.White;
        }
                

        private void Btcancelar_MouseLeave(object sender, EventArgs e)
        {
            Btcancelar.BackColor = Color.FromArgb(182, 20, 235);
            Btcancelar.ForeColor = Color.White;
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text =="Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text =="")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.Gray;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = true;

            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.Gray;
                txtcontraseña.UseSystemPasswordChar = false;

            }
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
        }

        private void btentrar_MouseMove_1(object sender, MouseEventArgs e)
        {
            btentrar.BackColor = Color.Green;
            btentrar.ForeColor = Color.White;//Color.FromArgb(182, 20, 235);
        }

        private void btentrar_MouseLeave_1(object sender, EventArgs e)
        {
            btentrar.BackColor = Color.FromArgb(182, 20, 235);
            btentrar.ForeColor = Color.White;
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            login(txtusuario.Text, txtcontraseña.Text);
        }
    }
}
