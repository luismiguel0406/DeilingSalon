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
    public partial class CUcuadrediario : UserControl
    {
        public CUcuadrediario()
        {
            InitializeComponent();
        }


        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql

        string estatus_fin_de_dia="No";
        public DataTable cargartablaventa_dia(string FINDEDIA)
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT * FROM REPORTES_VENTAS WHERE FIN_DIA='"+FINDEDIA+"' ORDER BY FECHA";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();

            }
            catch (Exception)
            {

                MessageBox.Show("No hay ventas registradas","Ventas del dia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            return Tabla;

        }

        private void CUcuadrediario_Load(object sender, EventArgs e)
        {
            dgvventas_dia.DataSource = cargartablaventa_dia(estatus_fin_de_dia);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvventas_dia.CurrentCell = null;
                foreach (DataGridViewRow r in dgvventas_dia.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvventas_dia.Rows)
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
                dgvventas_dia.DataSource = cargartablaventa_dia(estatus_fin_de_dia);
            }
        }
        //variables para metodo suma venta del dia
        double valorrecaudacion;
        double comisionesdia;
        double ganacia_dia;
        double ventas_efectivo;
        double ventas_credito;
        double ventas_tarjeta;
        double gastos;
        string fechadia;
        string usuario;


        public void Suma_ventas_del_dia() {


            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(VALOR)AS VALOR_RECAUDACION FROM REPORTES_VENTAS WHERE FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    valorrecaudacion = lector.GetDouble(0);
                }

                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {

                lector.Close();
                valorrecaudacion = 0;
                ConBD.cerrarconexion();
            }
                

            //
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(COMISIONES)AS COMISIONES_DIA FROM REPORTES_VENTAS WHERE FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    comisionesdia = lector.GetDouble(0);
                }
                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {
                lector.Close();
                comisionesdia = 0;
                ConBD.cerrarconexion();
            }


            //

            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(GANANCIA)AS GANANCIAS_DIA FROM REPORTES_VENTAS WHERE FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    ganacia_dia = lector.GetDouble(0);
                }
                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {

                lector.Close();
                ganacia_dia = 0;
                ConBD.cerrarconexion();
            }
            
            //

            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(VALOR)AS VENTAS_EFECTIVO FROM REPORTES_VENTAS WHERE TIPO_DE_PAGO='" + "Efectivo" + "' AND FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    ventas_efectivo = lector.GetDouble(0);
                }
                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {
                lector.Close();
                ventas_efectivo = 0;
                ConBD.cerrarconexion();
            }
            
            //

            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(VALOR)AS VENTAS_CREDITO FROM REPORTES_VENTAS WHERE TIPO_DE_PAGO='" + "Credito" + "' AND FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    ventas_credito = lector.GetDouble(0);
                }
                lector.Close();
                ConBD.cerrarconexion();
            }  
                        
            catch (Exception)
            {
                lector.Close();
                ventas_credito = 0;
                ConBD.cerrarconexion();                
            }
            
            //
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(VALOR)AS VENTAS_TARJETA FROM REPORTES_VENTAS WHERE TIPO_DE_PAGO='" + "Tarjeta" + "' AND FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    ventas_tarjeta = lector.GetDouble(0);
                }
                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {
                lector.Close();
                ventas_tarjeta = 0;
                ConBD.cerrarconexion();
            }
            //
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(GASTO)AS GASTO_DIARIO FROM GASTOS WHERE FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    gastos = lector.GetDouble(0);
                }
                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {
                lector.Close();
                gastos = 0;
                ConBD.cerrarconexion();
            }

            //
            fechadia = DateTime.Now.ToString("yyyy-MM-dd");
            usuario = Capa_Gestion_de_seguridad.cachelogin.nombre_usuario;
                      
        }

        public void insertar_a_cuadre_mensual() {
            
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "INSERT INTO CUADRE_MENSUAL (VALOR_RECAUDACION,COMISIONES_DEL_DIA,GANANCIA_DEL_DIA,VENTAS_EFECTIVO,VENTAS_CREDITO,VENTAS_TARJETA,GASTO_DIARIO,FECHA,USUARIO) VALUES(" +valorrecaudacion + "," + comisionesdia + "," +ganacia_dia + "," + ventas_efectivo + ","+ventas_credito+","+ventas_tarjeta+","+gastos+",'"+fechadia+"','" + usuario + "') ";
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                ConBD.cerrarconexion();
                    
        }

        public void fin_de_dia_ventas()
        {
            int id;
            int cuentafilas;
            cuentafilas = dgvventas_dia.RowCount;
            for (int i = 0; i < cuentafilas; i++)
            {
                id = int.Parse(dgvventas_dia.Rows[i].Cells[0].Value.ToString());

                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "UPDATE REPORTES_VENTAS SET FIN_DIA='"+"Si"+"' WHERE ID_VENTA="+id+" ";
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                ConBD.cerrarconexion();

            }
                       

        }
        public void fin_de_dia_gastos()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "UPDATE GASTOS SET FIN_DIA='" + "Si" + "'WHERE FIN_DIA='" + "No" + "'";
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                
            }
            catch (Exception)
            {

            }

            ConBD.cerrarconexion();

        }

        private void bfindedia_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show(" Esta seguro que desea realizar fin de dia?", "Fin de dia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogo == DialogResult.Yes)
                {
                    Suma_ventas_del_dia();
                    insertar_a_cuadre_mensual();
                    fin_de_dia_ventas();
                    fin_de_dia_gastos();
                    Tabla.Clear();
                    dgvventas_dia.DataSource = cargartablaventa_dia(estatus_fin_de_dia);

                    //
                    MessageBox.Show("Se realizo fin de dia correctamente", "Fin de dia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
        }
            catch (Exception EX)
            {

                MessageBox.Show("No se realizo fin de dia por: " + EX.Message);
            }


}

        private void rbventashoy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbventashoy.Checked == true)
            { estatus_fin_de_dia = "No"; }

            if (rbtodasventas.Checked == true)
            { estatus_fin_de_dia = "Si"; }

            Tabla.Clear();
            dgvventas_dia.DataSource = cargartablaventa_dia(estatus_fin_de_dia);
            
        }

        private void rbtodasventas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbventashoy.Checked == true)
            { estatus_fin_de_dia = "No"; }

            if (rbtodasventas.Checked == true)
            { estatus_fin_de_dia = "Si"; }
            Tabla.Clear();
            dgvventas_dia.DataSource = cargartablaventa_dia(estatus_fin_de_dia);
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Tabla.Clear();
                dgvventas_dia.DataSource = cargartablaventa_dia(estatus_fin_de_dia);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
