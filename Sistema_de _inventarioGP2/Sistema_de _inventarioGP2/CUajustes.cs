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
    public partial class CUajustes : UserControl
    {
        public CUajustes()
        {
            InitializeComponent();
        }

        //variables sql
        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        //variables sql
        // variable id de las consultas
        int idempresa;
        private bool editar = false;

        private void deshabilitartxt()
        {
            txtnombreempresa.Enabled = false;
            txtrncempresa.Enabled = false;
            txtdireccionempresa.Enabled = false;
            txttelefonoempresa.Enabled = false;
            txtcelularempresa.Enabled = false;
            txtadmempresa.Enabled = false;
            
        }

        private void habilitartxt()
        {
            txtnombreempresa.Enabled = true;
            txtrncempresa.Enabled = true;
            txtdireccionempresa.Enabled = true;
            txttelefonoempresa.Enabled = true;
            txtcelularempresa.Enabled = true;
            txtadmempresa.Enabled = true;
        }

        private void limpiar()
        {
            txtnombreempresa.Clear();
            txtrncempresa.Clear();
            txtdireccionempresa.Clear();
            txttelefonoempresa.Clear();
            txtcelularempresa.Clear();
            txtadmempresa.Clear();
        }


        private void bcancelar_MouseMove(object sender, MouseEventArgs e)
        {
            bcancelar.BackColor = Color.Red;
            bcancelar.ForeColor = Color.White;
        }

        private void bcancelar_MouseLeave(object sender, EventArgs e)
        {
            bcancelar.BackColor = Color.FromArgb(182, 20, 235);
            bcancelar.ForeColor = Color.White;
        }

        private void bguardar_MouseLeave(object sender, EventArgs e)
        {
            bguardar.BackColor = Color.FromArgb(182, 20, 235);
            bguardar.ForeColor = Color.White;
        }

      

        private void CUajustes_Load(object sender, EventArgs e)
        {
            Cargarlabels();
            if (lblnombre_empresa.Text!="")
            {
                deshabilitartxt();
            }
            
            bguardar.Enabled = false;
            


        }

        public void Cargarlabels(){
            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "SELECT * FROM EMPRESA";
            Comando.CommandType = CommandType.Text;
            try
            {
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        idempresa = lector.GetInt32(0);
                        lblnombre_empresa.Text = lector.GetString(1);
                        lblrncempresa.Text = lector.GetString(2);
                        lbldirempresa.Text = lector.GetString(3);
                        lbltelefonoempresa.Text = lector.GetString(4);
                        lblcelularempresa.Text = lector.GetString(5);
                        lbladmempresa.Text = lector.GetString(6);

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Datos","Ajustes",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            lector.Close();
            ConBD.cerrarconexion();

            
        }
        private void bcancelar_Click(object sender, EventArgs e)
        {
            limpiar();

            deshabilitartxt();
            bguardar.Enabled = false;
        }

        
        private void bguardar_Click(object sender, EventArgs e)
        {


            
            if (editar == false)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "INSERT INTO EMPRESA (NOMBRE_EMPRESA,RNC,DIRECCION,TELEFONO,CELULAR,ADMINISTRADOR) VALUES('" + txtnombreempresa.Text + "','" + txtrncempresa.Text + "','" + txtdireccionempresa.Text + "','" + txttelefonoempresa.Text + "','" + txtcelularempresa.Text + "','" + txtadmempresa.Text + "');";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                }
                catch (Exception)
                {

                    
                }
                               
            }

            if (editar == true)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "UPDATE  EMPRESA  SET NOMBRE_EMPRESA='" + txtnombreempresa.Text + "',RNC='" + txtrncempresa.Text + "',DIRECCION='" + lbldirempresa.Text + "',TELEFONO='" + txttelefonoempresa.Text + "',CELULAR='" + txtcelularempresa.Text + "',ADMINISTRADOR='" + txtadmempresa.Text + "'WHERE ID_EMPRESA=" + idempresa + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();

                }
                catch (Exception)
                {

                    
                }
               
            }
         
            limpiar();
            deshabilitartxt();
            editar = false;
            bguardar.Enabled = false;
            Cargarlabels();
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            if (lblnombre_empresa.Text!="")
            {
                habilitartxt();
                editar = true;
                bguardar.Enabled = true;
                txtadmempresa.Text = lbladmempresa.Text;
                txtcelularempresa.Text = lblcelularempresa.Text;
                txtdireccionempresa.Text = lbldirempresa.Text;
                txtnombreempresa.Text = lblnombre_empresa.Text;
                txtrncempresa.Text = lblrncempresa.Text;
                txttelefonoempresa.Text = lbltelefonoempresa.Text;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbladmempresa.Text!="")
            {
                MessageBox.Show("Ya exixte una empresa, Presione Editar","Ajustes",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                editar = false;
                limpiar();
                habilitartxt();
                bguardar.Enabled = true;
            }
            
        }

        private void bguardar_MouseMove(object sender, MouseEventArgs e)
        {
            bguardar.BackColor = Color.Green;
            bguardar.ForeColor = Color.White;

        }

        private void beditar_MouseMove(object sender, MouseEventArgs e)
        {
            beditar.ForeColor = Color.FromArgb(182, 20, 235);
            beditar.BackColor = Color.White;
        }

        private void beditar_MouseLeave(object sender, EventArgs e)
        {
            beditar.BackColor = Color.FromArgb(182, 20, 235);
            beditar.ForeColor = Color.White;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
