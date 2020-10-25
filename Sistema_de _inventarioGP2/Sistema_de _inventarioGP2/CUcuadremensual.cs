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
    public partial class CUcuadremensual : UserControl
    {
        public CUcuadremensual()
        {
            InitializeComponent();
        }
        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql


        public DataTable cargartablacuadremensual()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT VALOR_RECAUDACION,COMISIONES_DEL_DIA,GANANCIA_DEL_DIA,VENTAS_EFECTIVO,VENTAS_CREDITO,VENTAS_TARJETA,GASTO_DIARIO,FECHA,USUARIO FROM CUADRE_MENSUAL ORDER BY FECHA";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ventas del dia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return Tabla;

        }

        private void CUcuadremensual_Load(object sender, EventArgs e)
        {
            dgvcuadre_mensual.DataSource = cargartablacuadremensual();
            cuInforme1.Hide();
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {


            try
            {
                Tabla.Clear();
                dgvcuadre_mensual.DataSource = cargartablacuadremensual();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btactualizar_MouseMove(object sender, MouseEventArgs e)
        {
            btactualizar.BackColor = Color.White;
            btactualizar.ForeColor = Color.FromArgb(182, 20, 235);
        }

        private void btactualizar_MouseLeave(object sender, EventArgs e)
        {
            btactualizar.BackColor = Color.FromArgb(182, 20, 235);
            btactualizar.ForeColor = Color.White;
        }

     
        
        public void GenerarResumenVenta()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT SUM(VALOR_RECAUDACION)AS TOTAL_VALOR_RECAUDACION,SUM(COMISIONES_DEL_DIA)AS TOTAL_COMISIONES,SUM(GANANCIA_DEL_DIA)AS TOTAL_GANANCIAS,SUM(GASTO_DIARIO)AS GASTOS,SUM(VENTAS_EFECTIVO)AS TOTAL_VENTAS_EFECTIVO,SUM(VENTAS_CREDITO)AS TOTAL_VENTAS_CREDITO,SUM(VENTAS_TARJETA)AS TOTAL_VENTAS_TARJETA FROM CUADRE_MENSUAL WHERE FECHA >='" + dtpdesde.Value.ToString("yyyy-MM-dd") + "' AND FECHA <= '" + dtphasta.Value.ToString("yyyy-MM-dd") + "'";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Read();

                    VariablesReporte.valortotal = lector.GetDouble(0);
                    VariablesReporte.comisiontotal = lector.GetDouble(1);
                    VariablesReporte.gananciatotal = lector.GetDouble(2);
                    VariablesReporte.gastostotales = lector.GetDouble(3);
                    VariablesReporte.totalefectivo = lector.GetDouble(4);
                    VariablesReporte.totalcredito = lector.GetDouble(5);
                    VariablesReporte.totaltarjeta = lector.GetDouble(6);
                    
                }

                lector.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {
                lector.Close();
                VariablesReporte.valortotal = 0;
                VariablesReporte.comisiontotal = 0;
                VariablesReporte.gananciatotal = 0;
                VariablesReporte.totalefectivo = 0;
                VariablesReporte.totalcredito = 0;
                VariablesReporte.totaltarjeta = 0;
                VariablesReporte.gastostotales = 0;

                ConBD.cerrarconexion();

            }
           
        }

        private void btgenerar_Click(object sender, EventArgs e)
        {
            DialogResult dialogocuadre = MessageBox.Show("Se generara un cuadre mensual entre las dos fechas que selecciono?", "Cuadre Mensual", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogocuadre==DialogResult.Yes)
            {
                //try
                //{
                    GenerarResumenVenta();
                    cuInforme1.Show();
                    cuInforme1.BringToFront();
                    
                                                          
                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("Hubo algun error al generar el cuadre", "Cuadre Mensual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            
            
        }
    }
}
