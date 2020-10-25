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
    public partial class CUproveedores : UserControl
    {
        public CUproveedores()
        {
            InitializeComponent();
        }

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql

        // variable editar para saber si se edittara o se agregar
        private bool editar = false;
        public void limpiar()
        {
            txtidproveedor.Clear();
            txtrnc.Clear();
            txtnombre.Clear();
            txttelefonos.Clear();
            txtwhatsapp.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            txtsuministro.Clear();
            txtnombre.Focus();


        }
        public DataTable cargartablaproveedores()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM PROVEEDORES ORDER BY NOMBRE";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();

            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            return Tabla;
            
        }

        private void habilitartxt()
        {

            txtnombre.Enabled = true;
            txtrnc.Enabled = true;
            txttelefonos.Enabled = true;
            txtwhatsapp.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;
            txtsuministro.Enabled = true;


        }

        private void deshabilitartxt()
        {

            txtnombre.Enabled = false;
            txtrnc.Enabled = false;
            txttelefonos.Enabled = false;
            txtwhatsapp.Enabled = false;
            txtdireccion.Enabled = false;
            txtemail.Enabled = false;
            txtsuministro.Enabled = false;


        }

        private void CUproveedores_Load(object sender, EventArgs e)
        {
            deshabilitartxt();
            bguardar.Enabled = false;
            dgvproveedores.DataSource = cargartablaproveedores();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    if (txtnombre.Text != "")
                        Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "insert into PROVEEDORES (RNC,NOMBRE,TELEFONO,DIRECCION,EMAIL,SUMINISTRO,WHATSAPP) values('" + txtrnc.Text + "','" + txtnombre.Text + "','" + txttelefonos.Text + "','" + txtdireccion.Text + "','" + txtemail.Text + "','" + txtsuministro.Text + "','" + txtwhatsapp.Text + "');";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();

                    //refresco tabla 
                    Tabla.Clear();
                    dgvproveedores.DataSource = cargartablaproveedores();
                    MessageBox.Show("Operacion exitosa", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                limpiar();
            }

            if (editar == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //Haz esto si es si
                    try
                    {
                        Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE PROVEEDORES SET RNC ='" + txtrnc.Text + "',NOMBRE = '" + txtnombre.Text + "',TELEFONO = '" + txttelefonos.Text + "',WHATSAPP='" + txtwhatsapp.Text + "', DIRECCION ='" + txtdireccion.Text + "',EMAIL = '" + txtemail.Text + "',SUMINISTRO = '" + txtsuministro.Text + "' WHERE ID_PROVEEDOR = " + txtidproveedor.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvproveedores.DataSource = cargartablaproveedores();
                        MessageBox.Show("Operacion exitosa", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Verifique los Campos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvproveedores.DataSource = cargartablaproveedores();
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();
            }
            editar = false;
            deshabilitartxt();
            bguardar.Enabled = false;
            


        }

        
        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                //Haz esto si es si
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from PROVEEDORES where ID_PROVEEDOR= " + txtidproveedor.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvproveedores.DataSource = cargartablaproveedores();
                    MessageBox.Show("Operacion exitosa", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvproveedores.DataSource = cargartablaproveedores();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();
        }

        private void txtbuscarprov_TextChanged(object sender, EventArgs e)
        {
            // buscar proveedor
            if (txtbuscarprov.Text != "")
            {
                dgvproveedores.CurrentCell = null;
                foreach (DataGridViewRow r in dgvproveedores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvproveedores.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscarprov.Text.ToUpper()) == 0)
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
                dgvproveedores.DataSource = cargartablaproveedores();
            }
        }

        private void bguardar_MouseMove(object sender, MouseEventArgs e)
        {
            bguardar.BackColor = Color.Green;
            bguardar.ForeColor = Color.White;
        }

        private void bguardar_MouseLeave(object sender, EventArgs e)
        {
            bguardar.ForeColor = Color.White;
            bguardar.BackColor = Color.FromArgb(182, 20, 235);
        }

        

        private void beditar_Click(object sender, EventArgs e)
        {
            if (txtidproveedor.Text != "")
            {
                if (dgvproveedores.SelectedRows.Count > 0)
                {
                    editar = true;
                    habilitartxt();
                    bguardar.Enabled = true;
                }

            }

            else
            {

                MessageBox.Show("Seleccione una fila", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproveedor.Text = dgvproveedores.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvproveedores.CurrentRow.Cells[1].Value.ToString();
            txtrnc.Text = dgvproveedores.CurrentRow.Cells[2].Value.ToString();
            txttelefonos.Text = dgvproveedores.CurrentRow.Cells[3].Value.ToString();
            txtwhatsapp.Text = dgvproveedores.CurrentRow.Cells[4].Value.ToString();
            txtdireccion.Text = dgvproveedores.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = dgvproveedores.CurrentRow.Cells[6].Value.ToString();
            txtsuministro.Text = dgvproveedores.CurrentRow.Cells[7].Value.ToString();
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

        private void bnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitartxt();
            editar = false;
            bguardar.Enabled = true;
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
            bcancelar.BackColor = Color.FromArgb(182, 20, 235);
            bcancelar.ForeColor = Color.White;
        }
    }
}
