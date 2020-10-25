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
    public partial class CUgastos : UserControl
    {
        public CUgastos()
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

        private void deshabilitartxt()
        {
          // txtid.Enabled = false;
            txtgasto.Enabled = false;
            cbconcepto.Enabled = false;
            txtnotas.Enabled = false;
            dtpfechagasto.Enabled = false;


        }
        private void habilitartxt()
        {
            txtgasto.Enabled = true;
            cbconcepto.Enabled = true;
            txtnotas.Enabled = true;
            dtpfechagasto.Enabled = true;

        }

        private void limpiar()
        {
            txtid.Clear();
            txtgasto.Clear();
            cbconcepto.Text = "";
            txtnotas.Clear();
            dtpfechagasto.Value = DateTime.Now;
            
        }
        public DataTable CargarGastos()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM GASTOS ORDER BY FECHA";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {
                
            }

            return Tabla;

        }
        private void bguardar_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void bcancelar_MouseLeave(object sender, EventArgs e)
        {
            bcancelar.BackColor = Color.FromArgb(182, 20, 235);
            bcancelar.ForeColor = Color.White;
        }

        private void bcancelar_MouseMove(object sender, MouseEventArgs e)
        {
            bcancelar.BackColor = Color.Red;
            bcancelar.ForeColor = Color.White;
        }

        private void CUgastos_Load(object sender, EventArgs e)
        {
            deshabilitartxt();
            bguardar.Enabled = false;
            dgvgastos.DataSource = CargarGastos();
            
        }

        private void bnuevogasto_Click(object sender, EventArgs e)
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
                if (txtid.Text != "")
                {
                    if (dgvgastos.SelectedRows.Count > 0)
                    {
                        editar = true;
                        habilitartxt();
                        txtgasto.Focus();
                        bguardar.Enabled = true;

                    }
                }
                else { MessageBox.Show("Seleccione una fila", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una fila", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                //Haz esto si es si
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from GASTOS where ID = " + txtid.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvgastos.DataSource = CargarGastos();
                    MessageBox.Show("Operacion exitosa", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvgastos.DataSource = CargarGastos();
            }

            //LIMPIAR LOS TEXTBOX
            limpiar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvgastos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvgastos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvgastos.Rows)
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
                dgvgastos.DataSource = CargarGastos();
            }
        }
        string FINDIA = "No";
        private void bguardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {


                try
                {
                    if (txtgasto.Text != "" && txtgasto.Enabled == true)
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "insert into GASTOS (GASTO,CONCEPTO,NOTAS,FECHA,FIN_DIA) values(" + txtgasto.Text + ",'" + cbconcepto.Text + "','" + txtnotas.Text + "','" + dtpfechagasto.Value.ToString("yyyy-MM-dd") + "','"+FINDIA+"')";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();

                    //refrescar datagridview     
                    Tabla.Clear();
                    dgvgastos.DataSource = CargarGastos();
                    MessageBox.Show("Operacion exitosa", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    }
                    ////LIMPIAR LOS TEXTBOX
                    limpiar();
                deshabilitartxt();
            }
            //actualizar

            if (editar == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //Haz esto si es si
                    try
                    {
                        if (txtgasto.Text != "" && txtgasto.Enabled == true)
                            Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE GASTOS SET GASTO =" + txtgasto.Text + ",CONCEPTO = '" + cbconcepto.Text + "',NOTAS = '" + txtnotas.Text + "',FECHA='" + dtpfechagasto.Value.ToString("yyyy-MM-dd") + "' WHERE ID = " + txtid.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvgastos.DataSource = CargarGastos();
                        MessageBox.Show("Operacion exitosa", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Verifique los Campos", "Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvgastos.DataSource = CargarGastos();
                }
                //LIMPIAR LOS TEXTBOX
                limpiar();



            }
            editar = false;
            bguardar.Enabled = false;
            //deshabilito txt
            deshabilitartxt();
        }

        private void dgvgastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvgastos.CurrentRow.Cells[0].Value.ToString();
            txtgasto.Text= dgvgastos.CurrentRow.Cells[1].Value.ToString();
            cbconcepto.Text= dgvgastos.CurrentRow.Cells[2].Value.ToString();
            txtnotas.Text= dgvgastos.CurrentRow.Cells[3].Value.ToString();
            dtpfechagasto.Text= dgvgastos.CurrentRow.Cells[4].Value.ToString();
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitartxt();
            editar = false;
            bguardar.Enabled = false;
        }
    }
}
