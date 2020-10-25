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
    public partial class CUsueldos_e_ingresos : UserControl
    {
        public CUsueldos_e_ingresos()
        {
            InitializeComponent();
        }

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql

        public DataTable cargar_reporte_De_ventas(string pagocomis)
        {
            try { 

            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "SELECT ID_VENTA,REALIZADO_POR,SERVICIO_VENTA,VALOR,COMISIONES,FECHA FROM REPORTES_VENTAS WHERE PAGO_COMISION='"+pagocomis+"'";
            Comando.CommandType = CommandType.Text;
            lector = Comando.ExecuteReader();
            Tabla.Load(lector);
            ConBD.cerrarconexion();
        }
            catch (Exception)
            {

               // MessageBox.Show("No hay datos ");

            }
            return Tabla;

            }
        string comisionporventasemp;
        string pagodecomision="No";//esta variable indicara si se pago o no la comision
        public void VerVentasPorEmpleado()
        {
            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "SELECT SUM(COMISIONES)AS COMISIONES FROM REPORTES_VENTAS WHERE REALIZADO_POR='"+lblempleado.Text+"' AND PAGO_COMISION='"+pagodecomision+"'";
            Comando.CommandType = CommandType.Text;
            lector = Comando.ExecuteReader();

            if (lector.HasRows)
            {
                lector.Read();
                comisionporventasemp = lector["COMISIONES"].ToString();

                lblcomision.Text = comisionporventasemp;         

                       }
            //else { lblcomision.Text = "0"; }
            lector.Close();
      
            ConBD.cerrarconexion();
            
        }
        public void sueldoempleado()
        {
        
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT NOMBRE,SUELDO FROM DATOS_EMPLEADOS WHERE CODIGO=" + cbcodigoempleado.Text + "";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    lblempleado.Text = lector.GetString(0);
                    lblsueldo.Text = lector.GetDouble(1).ToString();

                }
                lector.Close();
                          
               ConBD.cerrarconexion();

        }
        
        public void Calculoingresos()

        {
            if (lblsueldo.Text != "..." && pagodecomision =="No")// para que no calcule cuando este en valor no
            {
                try
                {
                    lbltotalingresos.Text = (float.Parse(lblsueldo.Text) + float.Parse(lblcomision.Text)).ToString("c"); /*- float.Parse(txtdescuento.Text)).ToString();*/

                }
                catch (Exception)
                {
                    lbltotalingresos.Text = "0.00";
                    lblcomision.Text = "0.00";
                    // MessageBox.Show("Verifique los datos ingresados", "Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
          
        }
        public void agregarempleado(ComboBox cb)
        { //llenar combobox con id proveedor
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT CODIGO FROM DATOS_EMPLEADOS";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    cb.Items.Add(lector["CODIGO"].ToString());
                }
                lector.Close();
            }
            catch (Exception)
            {
                return;

            }

            ConBD.cerrarconexion();
        }

        public void Realizar_pago(Label lblempl)
        {
            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "UPDATE REPORTES_VENTAS SET PAGO_COMISION='"+"Si"+"' WHERE REALIZADO_POR='"+lblempl.Text+ "' AND PAGO_COMISION='" + "No" + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            ConBD.cerrarconexion();


        }
        private void CUsueldos_e_ingresos_Load(object sender, EventArgs e)
        {
            dgvsueldos_e_ingresos.DataSource = cargar_reporte_De_ventas(pagodecomision);
            agregarempleado(cbcodigoempleado);


        }

        private void cbcodigoempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sueldoempleado();
                VerVentasPorEmpleado();
                Calculoingresos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


    private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (txtbuscar.Text != "")
            {
                dgvsueldos_e_ingresos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvsueldos_e_ingresos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvsueldos_e_ingresos.Rows)
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
                dgvsueldos_e_ingresos.DataSource = cargar_reporte_De_ventas(pagodecomision);
            }
        }

        //private void rbcomisionespendientes_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbcomisionespendientes.Checked == true)
        //        pagodecomision = "No";
        //    if (rbtodascomisiones.Checked == true)
        //        pagodecomision = "Si";
        //    Tabla.Clear();
        //    dgvsueldos_e_ingresos.DataSource = cargar_reporte_De_ventas(pagodecomision);
        //}

        //private void rbtodascomisiones_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbcomisionespendientes.Checked == true)
        //        pagodecomision = "No";
        //    if (rbtodascomisiones.Checked == true)
        //        pagodecomision = "Si";
        //    Tabla.Clear();
        //    dgvsueldos_e_ingresos.DataSource = cargar_reporte_De_ventas(pagodecomision);
        //}

        private void bpagar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Se realizara pago a este empleado?,Esta acción no puede deshacerse","Sueldos e Ingresos",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                if (lblempleado.Text != "...")
                {

                    try
                    {
                        Realizar_pago(lblempleado);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("No se pudo realizar pago por: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un codigo de empleado", "Sueldos e ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               // rbcomisionespendientes.Checked = true;
                Tabla.Clear();
                dgvsueldos_e_ingresos.DataSource = cargar_reporte_De_ventas(pagodecomision);
                VerVentasPorEmpleado();
                Calculoingresos();
                MessageBox.Show("Pago realizado correctamente","Sueldos e Ingresos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cbcodigoempleado_Enter(object sender, EventArgs e)
        {
            cbcodigoempleado.Items.Clear();
            agregarempleado(cbcodigoempleado);
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            Tabla.Clear();
            dgvsueldos_e_ingresos.DataSource = cargar_reporte_De_ventas(pagodecomision);
        }
    }
}
