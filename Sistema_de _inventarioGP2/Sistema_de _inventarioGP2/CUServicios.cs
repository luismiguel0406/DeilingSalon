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
using Capa_Gestion_de_seguridad;

namespace Sistema_de__inventarioGP2
{
    public partial class CUServicios : UserControl
    {
        public CUServicios()
        {
            InitializeComponent();
        }




        //variables sql
        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        //variables sql
        private bool editar = false;
        public DataTable cargarservicios()
        {
            try
            {

                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT ID_SERVICIO,SERVICIO,PRECIO,PRECIO_COMISION,COMISION,(SELECT PRECIO_COMISION * COMISION)AS BENEFICIO_EMPLEADO,USUARIO FROM SERVICIOS ORDER BY SERVICIO";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();

            }
            catch (Exception)
            {

                MessageBox.Show(" No hay servicios ", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return Tabla;

        }

        private void limpiar()
        {
            txtideservicio.Clear();
            txtservicio.Clear();
            txtprecioserv.Clear();
            txtpreciocomision.Clear();
            txtcomision.Clear();


        }
        private void habilitartxt()
        {
            txtservicio.Enabled = true;
            txtprecioserv.Enabled = true;
            txtpreciocomision.Enabled = true;
            txtcomision.Enabled = true;

        }
        private void deshabilitartxt()
        {
            txtservicio.Enabled = false;
            txtprecioserv.Enabled = false;
            txtpreciocomision.Enabled = false;
            txtcomision.Enabled = false;

        }

        private void CUServicios_Load(object sender, EventArgs e)
        {
            editar = false;
            deshabilitartxt();
            bguardarserv.Enabled = false;
            dgvServicios.DataSource = cargarservicios();
        }

        private void bguardarserv_MouseMove(object sender, MouseEventArgs e)
        {
            bguardarserv.BackColor = Color.Green;
            bguardarserv.ForeColor = Color.White;
        }

        private void bguardarserv_MouseLeave(object sender, EventArgs e)
        {
            bguardarserv.BackColor = Color.FromArgb(182, 20, 235);
            bguardarserv.ForeColor = Color.White;
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

        private void bnuevoservicio_MouseMove(object sender, MouseEventArgs e)
        {
            bnuevoservicio.BackColor = Color.White;
            bnuevoservicio.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void bnuevoservicio_MouseLeave(object sender, EventArgs e)
        {
            bnuevoservicio.ForeColor = Color.White;
            bnuevoservicio.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void beditar_MouseMove(object sender, MouseEventArgs e)
        {
            beditar.BackColor = Color.White;
            beditar.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void beditar_MouseLeave(object sender, EventArgs e)
        {
            beditar.BackColor = Color.FromArgb(182, 20, 235);
            beditar.ForeColor = Color.White;
        }

        private void beliminar_MouseMove(object sender, MouseEventArgs e)
        {
            beliminar.BackColor = Color.Red;
            beliminar.ForeColor = Color.White;
        }

        private void beliminar_MouseLeave(object sender, EventArgs e)
        {
            beliminar.BackColor = Color.FromArgb(182, 20, 235);
            beliminar.ForeColor = Color.White;
        }

        private void txtbuscarserv_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (txtbuscarserv.Text != "")
            {
                dgvServicios.CurrentCell = null;
                foreach (DataGridViewRow r in dgvServicios.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvServicios.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscarserv.Text.ToUpper()) == 0)
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
                dgvServicios.DataSource = cargarservicios();
            }
        }

        private void bnuevoservicio_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitartxt();
            bguardarserv.Enabled = true;
            editar = false;

        }

        private void beditar_Click(object sender, EventArgs e)
        {
            if (txtideservicio.Text != "")
            {
                if (dgvServicios.SelectedRows.Count > 0)
                {
                    editar = true;
                    habilitartxt();
                    bguardarserv.Enabled = true;
                }

            }
            else
            {

                MessageBox.Show("Seleccione una fila", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            deshabilitartxt();
            editar = false;
            bguardarserv.Enabled = false;
            limpiar();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from SERVICIOS where ID_SERVICIO = " + txtideservicio.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvServicios.DataSource = cargarservicios();
                    MessageBox.Show("Operacion exitosa", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvServicios.DataSource = cargarservicios();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();
        }

        private void bguardarserv_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "insert into SERVICIOS (SERVICIO,PRECIO,PRECIO_COMISION,COMISION,USUARIO) values('" + txtservicio.Text + "'," + txtprecioserv.Text + ","+txtpreciocomision.Text+","+txtcomision.Text+",'" + "Agregado por:" + cachelogin.nombre.ToString() + "');";
                    //id producto no va en la consulta ya que es autoincrementable
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();

                    //refrescar datagridview     
                    Tabla.Clear();
                    dgvServicios.DataSource = cargarservicios();
                    MessageBox.Show("Operacion exitosa", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();
            }


            if (editar == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Servicios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {//Haz esto si es si
                    try
                    {
                        Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE SERVICIOS SET SERVICIO ='" + txtservicio.Text + "',PRECIO = " + txtprecioserv.Text + ",PRECIO_COMISION="+txtpreciocomision.Text+",COMISION="+txtcomision.Text+",USUARIO='"+"Editado por: "+cachelogin.nombre_usuario.ToString()+"' WHERE ID_SERVICIO = " + txtideservicio.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvServicios.DataSource = cargarservicios();
                        MessageBox.Show("Operacion exitosa", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception EX)
                    {

                        MessageBox.Show(EX.Message/*"Verifique los Campos", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error*/);
                        return;
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvServicios.DataSource = cargarservicios();
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();
                
            }
            deshabilitartxt();
            editar = false;
            bguardarserv.Enabled = false;
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtideservicio.Text = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            txtservicio.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            txtprecioserv.Text = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            txtpreciocomision.Text = dgvServicios.CurrentRow.Cells[3].Value.ToString();
            txtcomision.Text = dgvServicios.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
