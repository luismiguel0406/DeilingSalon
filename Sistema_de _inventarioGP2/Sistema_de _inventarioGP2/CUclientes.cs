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
    public partial class CUclientes : UserControl
    {
        public CUclientes()
        {
            InitializeComponent();
        }


        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql


        public void limpiar()
        {
            txtnombre.Clear();
            txtcodigo.Clear();
            txtapellido.Clear();
            dtpCumple.Value = DateTime.Now;// verificar este formato
            txtcelular.Clear();
            rtxtanotaciones.Clear();
            txtnombre.Focus();


        }

        private bool editar = false;
        public DataTable cargartablaclientes()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM CLIENTES ORDER BY NOMBRE";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();

            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ","Clientes",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            return Tabla;

        }

        private void CUclientes_Load(object sender, EventArgs e)
        {
            deshabilitartxtbox();
            bguardar.Enabled = false;
            dgvclientes.DataSource = cargartablaclientes();

        }

        private void bguardar_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {


                try
                {
                    if (txtnombre.Text != "" && txtnombre.Enabled == true)
                        Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "insert into CLIENTES (NOMBRE,APELLIDO,CELULAR,CUMPLEAÑOS,ANOTACIONES,VISITAS) values('" + txtnombre.Text + "' , '" + txtapellido.Text + "','" + txtcelular.Text + "','" + dtpCumple.Value.ToString("yyyy-MM-dd") + "','" + rtxtanotaciones.Text + "',"+ 0 +");";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();

                    //refrescar datagridview     
                    Tabla.Clear();
                    dgvclientes.DataSource = cargartablaclientes();
                    MessageBox.Show("Operacion exitosa", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();
                deshabilitartxtbox();
            }
            //actualizar

            if (editar == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //Haz esto si es si
                    try
                    {
                        if (txtcodigo.Text != "" && txtnombre.Enabled == true)
                            Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE CLIENTES SET NOMBRE ='" + txtnombre.Text + "',APELLIDO = '" + txtapellido.Text + "',CELULAR = '" + txtcelular.Text + "',CUMPLEAÑOS='" + dtpCumple.Value.ToString("yyyy-MM-dd") + "',ANOTACIONES='"+rtxtanotaciones.Text+"' WHERE CODIGO = " + txtcodigo.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvclientes.DataSource = cargartablaclientes();
                        MessageBox.Show("Operacion exitosa", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Verifique los Campos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvclientes.DataSource = cargartablaclientes();
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();



            }
            editar = false;
            bguardar.Enabled = false;
            //deshabilito txt
            deshabilitartxtbox();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                //Haz esto si es si
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from CLIENTES where CODIGO = " + txtcodigo.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvclientes.DataSource = cargartablaclientes();
                    MessageBox.Show("Operacion exitosa", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvclientes.DataSource = cargartablaclientes();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvclientes.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvclientes.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvclientes.CurrentRow.Cells[2].Value.ToString();
            txtcelular.Text = dgvclientes.CurrentRow.Cells[3].Value.ToString();
            dtpCumple.Text = dgvclientes.CurrentRow.Cells[4].Value.ToString();
            rtxtanotaciones.Text = dgvclientes.CurrentRow.Cells[6].Value.ToString();

            // AREA DE INFORMACIONES 
            lblnombre_cliente.Text = (dgvclientes.CurrentRow.Cells[1].Value + " " + dgvclientes.CurrentRow.Cells[2].Value).ToString();
            lblcumpleaños.Text = "Esta de cumpleaños el " + DateTime.Parse(dgvclientes.CurrentRow.Cells[4].Value.ToString()).ToLongDateString();

            if (lblcumpleaños.Text == "Esta de cumpleaños el " + DateTime.Now.ToLongDateString())
            {
                lblcumpleaños.Text = "Esta de cumpleaños el dia de Hoy";
            }


            try
            {
                lblcita.Text = "Tiene cita para el " + DateTime.Parse(dgvclientes.CurrentRow.Cells[5].Value.ToString()).ToLongDateString();
            }
            catch (Exception)
            {
                lblcita.Text="..";

            }
        }

        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarcliente.Text != "")
            {
                dgvclientes.CurrentCell = null;
                foreach (DataGridViewRow r in dgvclientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvclientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscarcliente.Text.ToUpper()) == 0)
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
                dgvclientes.DataSource = cargartablaclientes();
            }
        }

        private void bguardar_MouseMove(object sender, MouseEventArgs e)
        {
            bguardar.BackColor = Color.Green;
            bguardar.ForeColor = Color.White;
        }

        private void bguardar_MouseLeave(object sender, EventArgs e)
        {
            bguardar.BackColor = Color.FromArgb(182, 20, 235);
            bguardar.ForeColor = Color.White;
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

        private void bnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitartextbox();
            editar = false;
            bguardar.Enabled = true;
        }
        private void habilitartextbox()
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtcelular.Enabled = true;
            dtpCumple.Enabled = true;
            rtxtanotaciones.Enabled = true;
           
        }

        private void deshabilitartxtbox()
        {

            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtcelular.Enabled = false;
            dtpCumple.Enabled = false;
            rtxtanotaciones.Enabled = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se agregara una nueva cita?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //Haz esto si es si
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "UPDATE CLIENTES SET CITA ='" + dtpcita.Value.ToString("yyyy-MM-dd") + "' WHERE CODIGO =" + txtcodigo.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    Tabla.Clear();
                    dgvclientes.DataSource = cargartablaclientes();
                    MessageBox.Show("Operacion exitosa", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos de fecha", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvclientes.DataSource = cargartablaclientes();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigo.Text != "")
                {
                    if (dgvclientes.SelectedRows.Count > 0)
                    {
                        editar = true;
                        habilitartextbox();
                        txtnombre.Focus();
                        bguardar.Enabled = true;

                    }
                }
                else { MessageBox.Show("Seleccione una fila","Clientes",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una fila", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitartxtbox();
            editar = false;
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

        private void bagregarcita_MouseMove(object sender, MouseEventArgs e)
        {
            bagregarcita.BackColor = Color.White;
            bagregarcita.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void bagregarcita_MouseLeave(object sender, EventArgs e)
        {
            bagregarcita.ForeColor = Color.White;
            bagregarcita.BackColor = Color.FromArgb(182, 20, 235);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}



