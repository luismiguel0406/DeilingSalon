using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;
namespace Sistema_de__inventarioGP2
{
    public partial class CUDatosempleado : UserControl
    {
        public CUDatosempleado()
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
        public void AbrirImagen()
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                pbfotoempleado.Image = Image.FromFile(Abrir.FileName);
                
            }
            

        }
        //MemoryStream ms = new MemoryStream();
        //public void GuardarImagen()
        //{
        //    pbfotoempleado.Image.Save(ms,ImageFormat.Jpeg);
        //}


        private void deshabilitartxt()
        {
            txtnombre.Enabled = false;
            txtcedula.Enabled = false;
            txtdireccion.Enabled = false;
            txtsueldo.Enabled = false;
            txtcelular.Enabled = false;
            txtcelpariente1.Enabled = false;
            txtcelpariente2.Enabled = false;
            dtpfechaingreso.Enabled = false;
            pbfotoempleado.Enabled = false;

        }
        private void habilitartxt()
        {
            txtnombre.Enabled = true;
            txtcedula.Enabled = true;
            txtdireccion.Enabled = true;
            txtsueldo.Enabled = true;
            txtcelular.Enabled = true;
            txtcelpariente1.Enabled = true;
            txtcelpariente2.Enabled = true;
            dtpfechaingreso.Enabled = true;
            pbfotoempleado.Enabled = true;

        }
        private void limpiar()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtcedula.Clear();
            txtdireccion.Clear();
            txtsueldo.Clear();
            txtcelular.Clear();
            txtcelpariente1.Clear();
            txtcelpariente2.Clear();
            pbfotoempleado.Image = null;
            dtpfechaingreso.Value=DateTime.Now;

        }

        public DataTable cargardatosempleado()
        {
            try { 

            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "SELECT CODIGO,NOMBRE,CEDULA,DIRECCION,SUELDO,CELULAR,CEL_PARIENTE_1,CEL_PARIENTE_2,FECHA_INGRESO FROM DATOS_EMPLEADOS ORDER BY NOMBRE";
            Comando.CommandType = CommandType.Text;
            lector = Comando.ExecuteReader();
            Tabla.Load(lector);
            ConBD.cerrarconexion();
        }
            catch (Exception)
            {

                MessageBox.Show(" No hay Empleados ","Datos empleados",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            return Tabla;
           
        }

        private void pbfotoempleado_Click(object sender, EventArgs e)
        {
            AbrirImagen();
        }

        public void guardarempleado(PictureBox foto)
        {
            
            if (editar == false)
            {
                try
                {
                    if (txtnombre.Text != "")
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "insert into DATOS_EMPLEADOS (NOMBRE,CEDULA,DIRECCION,SUELDO,CELULAR,CEL_PARIENTE_1,CEL_PARIENTE_2,FECHA_INGRESO,FOTO ) values('" + txtnombre.Text + "','" + txtcedula.Text + "','" + txtdireccion.Text + "'," + txtsueldo.Text + ",'" + txtcelular.Text + "','" + txtcelpariente1.Text + "','" + txtcelpariente2.Text + "','" + dtpfechaingreso.Value.ToString("yyyy-MM-dd") + "',@foto)";
                    Comando.CommandType = CommandType.Text;
                    Comando.Parameters.Add("@foto", SqlDbType.Image);

                    MemoryStream ms = new MemoryStream();
                    foto.Image.Save(ms, ImageFormat.Jpeg);
                    Comando.Parameters["@foto"].Value = ms.GetBuffer();

                    

                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    ConBD.cerrarconexion();

                    //refresco tabla 
                    Tabla.Clear();
                    dgvdatosempleado.DataSource = cargardatosempleado();
                    MessageBox.Show("Operacion exitosa", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    deshabilitartxt();
                    bguardar.Enabled = false;
                    editar = false;
                    limpiar();
                }
                catch (Exception )
                {

                    MessageBox.Show("Verifique los campos", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
            }
            if (editar==true)
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //Haz esto si es si
                    try
                    {
                        Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "UPDATE DATOS_EMPLEADOS SET NOMBRE ='" + txtnombre.Text + "',CEDULA = '" + txtcedula.Text + "',DIRECCION = '" + txtdireccion.Text + "',SUELDO= " + txtsueldo.Text + ", CELULAR ='" + txtcelular.Text + "',CEL_PARIENTE_1 = '" + txtcelpariente1.Text + "',CEL_PARIENTE_2 = '" + txtcelpariente2.Text + "',FECHA_INGRESO='" + dtpfechaingreso.Value.ToString("yyyy-MM-dd") + "',FOTO=@foto WHERE CODIGO = " + txtcodigo.Text + "";
                        Comando.CommandType = CommandType.Text;
                        Comando.Parameters.Add("@foto", SqlDbType.Image);

                        MemoryStream ms = new MemoryStream();
                        foto.Image.Save(ms, ImageFormat.Jpeg);
                        Comando.Parameters["@foto"].Value = ms.GetBuffer();

                        //Comando.CommandType = CommandType.Text;
                        Comando.ExecuteNonQuery();
                        Comando.Parameters.Clear();
                        ConBD.cerrarconexion();
                        // refresco tabla
                        Tabla.Clear();
                        dgvdatosempleado.DataSource = cargardatosempleado();
                        MessageBox.Show("Operacion exitosa", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //
                        deshabilitartxt();
                        bguardar.Enabled = false;
                        editar = false;
                        limpiar();
                    }
                    catch (Exception )
                    {

                        MessageBox.Show("Verifique los Campos", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //hacer esto si es no

                    //refrescar datagridview 
                    Tabla.Clear();
                    dgvdatosempleado.DataSource = cargardatosempleado();
                }
                               
                }
            
        }
        private void bguardar_Click(object sender, EventArgs e)
        {          
                guardarempleado(pbfotoempleado);
               
        }

        private void CUDatosempleado_Load(object sender, EventArgs e)
        {
            bguardar.Enabled = false;
            deshabilitartxt();
            dgvdatosempleado.DataSource = cargardatosempleado();

        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            
            editar = false;
            limpiar();
            habilitartxt();
            bguardar.Enabled = true;

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            limpiar();
            deshabilitartxt();
            bguardar.Enabled = false;
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (dgvdatosempleado.SelectedRows.Count > 0)
                {
                    editar = true;
                    habilitartxt();
                    bguardar.Enabled = true;
                }

            }
            else
            {

                MessageBox.Show("Seleccione una fila", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (txtbuscar.Text != "")
            {
                dgvdatosempleado.CurrentCell = null;
                foreach (DataGridViewRow r in dgvdatosempleado.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvdatosempleado.Rows)
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
                dgvdatosempleado.DataSource = cargardatosempleado();
            }
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar?", "Datos empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "delete from DATOS_EMPLEADOS where CODIGO = " + txtcodigo.Text + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    ConBD.cerrarconexion();
                    // refresco tabla
                    Tabla.Clear();
                    dgvdatosempleado.DataSource = cargardatosempleado();
                    MessageBox.Show("Operacion exitosa", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Verifique los Campos", "Datos empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                //hacer esto si es no

                //refrescar datagridview 
                Tabla.Clear();
                dgvdatosempleado.DataSource = cargardatosempleado();
            }
                    
            //LIMPIAR LOS TEXTBOX
            limpiar();

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

        private void dgvdatosempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
            txtcodigo.Text= dgvdatosempleado.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvdatosempleado.CurrentRow.Cells[1].Value.ToString();
            txtcedula.Text = dgvdatosempleado.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dgvdatosempleado.CurrentRow.Cells[3].Value.ToString();
            txtsueldo.Text = dgvdatosempleado.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = dgvdatosempleado.CurrentRow.Cells[5].Value.ToString();
            txtcelpariente1.Text = dgvdatosempleado.CurrentRow.Cells[6].Value.ToString();
            txtcelpariente2.Text = dgvdatosempleado.CurrentRow.Cells[7].Value.ToString();
            dtpfechaingreso.Text = dgvdatosempleado.CurrentRow.Cells[8].Value.ToString();

            //VARIABLE BYTE PARA CAPTURAR IMAGEN
            byte[] fotoempleado = new byte[0];
            //CONSULTA PARA BUSCARLA
            
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT FOTO FROM DATOS_EMPLEADOS WHERE CODIGO=" + txtcodigo.Text + "";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                lector.Read();
                fotoempleado = (byte[])lector["FOTO"];
                MemoryStream MS = new MemoryStream(fotoempleado);
                pbfotoempleado.Image = Bitmap.FromStream(MS);

                lector.Close();
                
            }
            catch (Exception)
            {
                pbfotoempleado.Image = null;

                
            }
            ConBD.cerrarconexion();


        }
    }
}

