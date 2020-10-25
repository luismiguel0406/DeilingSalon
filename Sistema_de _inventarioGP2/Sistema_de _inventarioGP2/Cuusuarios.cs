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
    public partial class Cuusuarios : UserControl
    {
        public Cuusuarios()
        {
            InitializeComponent();
        }

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql
        private bool editar = false;

        public DataTable cargartablausuarios()
        {
            try
            {
                Comando.Connection = ConBD.conexion;
                ConBD.conexion.Open();
                Comando.CommandText = "SELECT * FROM USUARIOS ORDER BY NOMBRE";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.conexion.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ");

            }
            return Tabla;

        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitartxt();
            editar = false;
            bguardar.Enabled = true;
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigo.Text !="")
                {
                    if (dgvusuarios.SelectedRows.Count > 0)
                    {
                        editar = true;
                        habilitartxt();
                        txtnombre.Focus();
                        bguardar.Enabled = true;

                    }
                }
                else { MessageBox.Show("Seleccione una fila","Usuarios",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una fila");
            }
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitartxt();
            editar = false;
            bguardar.Enabled = false;
        }
        private void habilitartxt()
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtcontrasena.Enabled = true;
            txtcargo.Enabled = true;
            cbprivilegios.Enabled = true;
            
        }

        private void deshabilitartxt()
        {
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtcontrasena.Enabled = false;
            txtcargo.Enabled = false;
            cbprivilegios.Enabled = false;

        }
        private void limpiar()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtnombreusuario.Clear();
            txtcontrasena.Clear();
            txtcargo.Clear();
            cbprivilegios.Text="Ingrese privilegios";

        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvusuarios.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvusuarios.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvusuarios.CurrentRow.Cells[2].Value.ToString();
            txtnombreusuario.Text = dgvusuarios.CurrentRow.Cells[3].Value.ToString();
            txtcontrasena.Text = dgvusuarios.CurrentRow.Cells[4].Value.ToString();
            txtcargo.Text = dgvusuarios.CurrentRow.Cells[5].Value.ToString();
            cbprivilegios.Text = dgvusuarios.CurrentRow.Cells[6].Value.ToString();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                //Haz esto si es si
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from USUARIOS where ID_USUARIO = " + txtcodigo.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvusuarios.DataSource = cargartablausuarios();
                    MessageBox.Show("Operacion exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Operacion fallida,Intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvusuarios.DataSource = cargartablausuarios();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();

        }

        private void Cuusuarios_Load(object sender, EventArgs e)
        {
            bguardar.Enabled = false;
            deshabilitartxt();
            dgvusuarios.DataSource = cargartablausuarios();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (editar==false)
            {
try
            {
                if (txtnombre.Text != "" &&txtapellido.Text!="" &&txtcontrasena.Text!="" &&txtcargo.Text!="" &&cbprivilegios.Text!="" )

                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "insert into USUARIOS (NOMBRE,APELLIDO,NOMBRE_DE_USUARIO,CONTRASENA,CARGO,PRIVILEGIOS) values('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtnombreusuario.Text + "' , '" + txtcontrasena.Text + "','" + txtcargo.Text + "','" + cbprivilegios.Text + "');";
                //id producto no va en la consulta ya que es autoincrementable
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                ConBD.cerrarconexion();

                //refrescar datagridview     
                Tabla.Clear();
                dgvusuarios.DataSource = cargartablausuarios();
                MessageBox.Show("Operacion exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Operacion fallida,Intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            //LIMPIAR LOS TEXTBOX
            limpiar();
           

            }

            if (editar==true)
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE USUARIOS SET NOMBRE ='" + txtnombre.Text + "',APELLIDO='" + txtapellido.Text + "',NOMBRE_DE_USUARIO='" + txtnombreusuario.Text + "', CONTRASENA = '" + txtcontrasena.Text + "', CARGO ='" + txtcargo.Text + "', PRIVILEGIOS='" + cbprivilegios.Text + "' WHERE ID_USUARIO= " + txtcodigo.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvusuarios.DataSource = cargartablausuarios();
                        MessageBox.Show("Operacion exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Operacion fallida,Intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvusuarios.DataSource = cargartablausuarios();
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();
            }
            editar = false;
            bguardar.Enabled = false;
            deshabilitartxt();

        }

        private void bguardar_MouseMove(object sender, MouseEventArgs e)
        {
            bguardar.ForeColor = Color.White;//Color.FromArgb(182, 20, 235);
            bguardar.BackColor = Color.Green;
        }

        private void bguardar_MouseLeave(object sender, EventArgs e)
        {
            bguardar.BackColor = Color.FromArgb(182, 20, 235);
            bguardar.ForeColor = Color.White;
        }

        private void beliminar_MouseMove(object sender, MouseEventArgs e)
        {
            beliminar.BackColor = Color.Red;
            beliminar.ForeColor = Color.White;
        }

        private void beliminar_MouseLeave(object sender, EventArgs e)
        {
            beliminar.ForeColor = Color.White;
            beliminar.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void beditar_MouseLeave(object sender, EventArgs e)
        {
            beditar.ForeColor = Color.White;
            beditar.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void beditar_MouseMove(object sender, MouseEventArgs e)
        {
            beditar.BackColor = Color.White;
            beditar.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void bcancelar_MouseMove(object sender, MouseEventArgs e)
        {
            bcancelar.BackColor = Color.Red;
            bcancelar.ForeColor = Color.White;
        }

        private void bcancelar_MouseLeave(object sender, EventArgs e)
        {
            bcancelar.ForeColor = Color.White;
            bcancelar.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void bnuevo_MouseMove(object sender, MouseEventArgs e)
        {
            bnuevo.BackColor = Color.White;
            bnuevo.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void bnuevo_MouseLeave(object sender, EventArgs e)
        {
            bnuevo.BackColor = Color.FromArgb(182, 20, 235);
            bnuevo.ForeColor = Color.White;
            
        }

        string caracter;
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            //nombre de usuario automatico
            if (txtnombre.Text != "" && txtnombre.TextLength > 1)
            {
                txtapellido.Text = "";
                caracter = txtnombre.Text.Remove(1);//eliminar todas las letras menos la primera
                txtnombreusuario.Text = caracter.ToString().ToUpperInvariant() + ".";
            }
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {//nombre de usuario automatico

            txtnombreusuario.Text = (caracter + txtapellido.Text.Replace(" ", "").ToString()).ToUpperInvariant();

        }

        private void txtbuscarusu_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarusu.Text != "")
            {
                dgvusuarios.CurrentCell = null;
                foreach (DataGridViewRow r in dgvusuarios.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvusuarios.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscarusu.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                Tabla.Clear();
                dgvusuarios.DataSource = cargartablausuarios();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
