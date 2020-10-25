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
    public partial class CUinventario : UserControl
    {
        public CUinventario()
        {
            InitializeComponent();
        }

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql

        private bool editar = false;

        StringBuilder invtotal = new StringBuilder();


        public void limpiar()
        {
            txtid.Clear();
            try
            {
                cbidproveedor.Text = "Ingrese Proveedor";
            }
            catch (ArgumentOutOfRangeException)
            {

                /* MessageBox.Show(ex.Message) */
                ;
            }

            txtproducto.Clear();
            txtprecioventa.Clear();
            txtpreciocosto.Clear();
            txtcomision.Clear();
            txtcantidad.Clear();
            txtubicacion.Clear();
            txtproducto.Focus();
        }
        private void habilitartxt()
        {
            txtproducto.Enabled = true;
            txtpreciocosto.Enabled = true;
            txtprecioventa.Enabled = true;
            txtcomision.Enabled = true;
            cbidproveedor.Enabled = true;
            txtubicacion.Enabled = true;
            txtcantidad.Enabled = true;
        }


        private void deshabilitartxt()
        {
            txtproducto.Enabled = false;
            txtpreciocosto.Enabled = false;
            txtprecioventa.Enabled = false;
            cbidproveedor.Enabled = false;
            txtubicacion.Enabled = false;
            txtcantidad.Enabled = false;
            txtcomision.Enabled = false;

        }


        public DataTable cargartablainventario()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM INVENTARIO ORDER BY PRODUCTO";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();

            }
            catch (Exception)
            {

                MessageBox.Show(" No hay datos ", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return Tabla;

        }
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public void agregaritem(ComboBox cb)
        { //llenar combobox con id proveedor
            try
            {
                cmd.Connection = ConBD.abrirconexion();
                cmd.CommandText = "SELECT NOMBRE FROM PROVEEDORES";
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader["NOMBRE"].ToString());
                }
                reader.Close();
            }
            catch (Exception)
            {


            }

            ConBD.cerrarconexion();
        }

        private void CUinventario_Load(object sender, EventArgs e)
        {
            bguardar.Enabled = false;
            deshabilitartxt();
            dgvinventario.DataSource = cargartablainventario();
            agregaritem(cbidproveedor);
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from INVENTARIO where ID_PRODUCTO = " + txtid.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvinventario.DataSource = cargartablainventario();
                    MessageBox.Show("Operacion exitosa", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Operacion fallida,Intente de nuevo", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvinventario.DataSource = cargartablainventario();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (txtbuscar.Text != "")
            {
                dgvinventario.CurrentCell = null;
                foreach (DataGridViewRow r in dgvinventario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvinventario.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscar.Text.ToUpper()) == 0)
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
                dgvinventario.DataSource = cargartablainventario();
            }
        }

        private void beditar_MouseMove(object sender, MouseEventArgs e)
        {
            beditar.BackColor = Color.White;
            beditar.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void beditar_MouseLeave(object sender, EventArgs e)
        {
            beditar.ForeColor = Color.White;
            beditar.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void bguardar_MouseMove(object sender, MouseEventArgs e)
        {
            bguardar.BackColor = Color.Green;
            bguardar.ForeColor = Color.White;//Color.FromArgb(182, 20, 235);
        }

        private void bguardar_MouseLeave(object sender, EventArgs e)
        {
            bguardar.ForeColor = Color.White;
            bguardar.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void bnuevo_MouseMove(object sender, MouseEventArgs e)
        {
            bnuevo.BackColor = Color.White;
            bnuevo.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void bnuevo_MouseLeave(object sender, EventArgs e)
        {
            bnuevo.ForeColor = Color.White;
            bnuevo.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void dgvinventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //condicion de la celda
            if (this.dgvinventario.Columns[e.ColumnIndex].Name == "CANTIDAD")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (Convert.ToInt32(e.Value) <= 5)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.BackColor = Color.Orange;
                        }
                    }
                }
                catch (NullReferenceException ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void dgvinventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvinventario.CurrentRow.Cells[0].Value.ToString();
            txtproducto.Text = dgvinventario.CurrentRow.Cells[2].Value.ToString();
            cbidproveedor.Text = dgvinventario.CurrentRow.Cells[1].Value.ToString();
            txtprecioventa.Text = dgvinventario.CurrentRow.Cells[3].Value.ToString();
            txtpreciocosto.Text = dgvinventario.CurrentRow.Cells[4].Value.ToString();
            txtcantidad.Text = dgvinventario.CurrentRow.Cells[5].Value.ToString();
            txtubicacion.Text = dgvinventario.CurrentRow.Cells[6].Value.ToString();
            txtcomision.Text= dgvinventario.CurrentRow.Cells[9].Value.ToString();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            editar = false;
            habilitartxt();
            bguardar.Enabled = true;
        }

        string total;

        private void btnTotalinv_Click(object sender, EventArgs e)
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(PRECIO_COSTO) AS TOTAL FROM INVENTARIO";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();

                lector.Read();
                total = lector["TOTAL"].ToString();

                MessageBox.Show("Total en inventario es:RD$ " + total);

                ConBD.cerrarconexion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnTotalinv_MouseMove(object sender, MouseEventArgs e)
        {
            btnTotalinv.BackColor = Color.White;
            btnTotalinv.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void btnTotalinv_MouseLeave(object sender, EventArgs e)
        {
            btnTotalinv.ForeColor = Color.White;
            btnTotalinv.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void beliminar_MouseMove(object sender, MouseEventArgs e)
        {
            beliminar.ForeColor = Color.White;
            beliminar.BackColor = Color.Red;
        }

        private void beliminar_MouseLeave(object sender, EventArgs e)
        {
            beliminar.ForeColor = Color.White;
            beliminar.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "insert into INVENTARIO (PROVEEDOR,PRODUCTO,PRECIO_VENTA,PRECIO_COSTO,CANTIDAD,UBICACION,FECHA_INGRESO,USUARIO,COMISION) values('" + cbidproveedor.Text + "','" + txtproducto.Text + "'," + txtprecioventa.Text + "," + txtpreciocosto.Text + "," + txtcantidad.Text + ",'" + txtubicacion.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + "Agregado por:" + cachelogin.nombre.ToString() + "',"+txtcomision.Text+");";
                    //id producto no va en la consulta ya que es autoincrementable
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();

                    //refrescar datagridview     
                    Tabla.Clear();
                    dgvinventario.DataSource = cargartablainventario();
                    MessageBox.Show("Operacion exitosa", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                    deshabilitartxt();
                    editar = false;
                    bguardar.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los campos,Intente de nuevo", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }


            if (editar == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {//Haz esto si es si
                    try
                    {
                        Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE INVENTARIO SET PROVEEDOR ='" + cbidproveedor.Text + "',PRODUCTO = '" + txtproducto.Text + "',PRECIO_VENTA = " + txtprecioventa.Text + ",PRECIO_COSTO=" + txtpreciocosto.Text + ", CANTIDAD = " + txtcantidad.Text + ",UBICACION = '" + txtubicacion.Text + "',FECHA_INGRESO= '" + DateTime.Now.ToString("yyyy-MM-dd") + "',USUARIO='" + "Modificado por:" + cachelogin.nombre.ToString() + "',COMISION="+txtcomision.Text+" WHERE ID_PRODUCTO = " + txtid.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvinventario.DataSource = cargartablainventario();
                        MessageBox.Show("Operacion exitosa", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //
                        limpiar();
                        deshabilitartxt();
                        editar = false;
                        bguardar.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Verifique los campos,Intente de nuevo", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvinventario.DataSource = cargartablainventario();
                }
               
            }
            
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (dgvinventario.SelectedRows.Count > 0)
                {
                    editar = true;
                    habilitartxt();
                    bguardar.Enabled = true;
                }

            }
            else
            {

                MessageBox.Show("Seleccione una fila", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            limpiar();
            deshabilitartxt();
            bguardar.Enabled = false;
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
    }
}
