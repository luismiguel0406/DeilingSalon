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
    public partial class CUcreditos : UserControl
    {
        public CUcreditos()
        {
            InitializeComponent();
        }

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        DataTable Tabla = new DataTable();
        // cosas que se usaran en sql

        public DataTable cargar_creditos_clientes()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT CODIGO,NOMBRE,CREDITO,FECHA_ULTIMO_PAGO FROM CLIENTES WHERE CREDITO <> 0 ORDER BY NOMBRE";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                Tabla.Load(lector);
                ConBD.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
            return Tabla;
        }

        
        string importe;
        double credito_pendiente;
        double credito_resultante;

        private void pagarcredito(TextBox txt)
        {
          //  idcliente = int.Parse(dgvcreditos.CurrentRow.Cells[0].Value.ToString());
            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "SELECT * FROM CLIENTES WHERE CODIGO =" + idcliente + " ";
            Comando.CommandType = CommandType.Text;
            lector = Comando.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                credito_pendiente = lector.GetDouble(8);
                importe = txt.Text;

                credito_resultante = credito_pendiente - double.Parse(importe);
                lector.Close();
            }
            lector.Close();
            ConBD.cerrarconexion();
            // actualizamos el credito

            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "UPDATE CLIENTES SET CREDITO="+credito_resultante+",FECHA_ULTIMO_PAGO='"+DateTime.Now.ToString("yyyy-MM-dd")+"' WHERE CODIGO="+idcliente+"";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            ConBD.cerrarconexion();

            MessageBox.Show("Importe Aplicado Exitosamente","Creditos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txt.Clear();
            idcliente = 0;
            

        }

        private void CUcreditos_Load(object sender, EventArgs e)
        {
            dgvcreditos.DataSource = cargar_creditos_clientes();
        }

        private void bimporte_Click(object sender, EventArgs e)
        {
            DialogResult Dialogo = MessageBox.Show("Desea aplicar importe a este cliente?", "Creditos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dialogo==DialogResult.Yes)
            {
                try
                {
                    if (idcliente!=0 && txtimporte.Text!=null)
                        pagarcredito(txtimporte);
                }
                catch (Exception EX)
                {

                    MessageBox.Show("No se pudo aplicar el importe por: " + EX.Message, "Creditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Tabla.Clear();
                dgvcreditos.DataSource = cargar_creditos_clientes();
            }
        }

        private void txtimporte_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtimporte.Text !="")
                {
                    if (double.Parse(txtimporte.Text) > double.Parse(dgvcreditos.CurrentRow.Cells[2].Value.ToString()))
                    {
                        MessageBox.Show("Este importe es mayor al credito pendiente, Favor ingresar importe correcto", "Creditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtimporte.Text = "0";
                    }
                }
            }
            catch (Exception)
            {

                
            }

        }

        private void txtbuscarcredito_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarcredito.Text != "")
            {
                dgvcreditos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvcreditos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvcreditos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscarcredito.Text.ToUpper()) == 0)
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
                dgvcreditos.DataSource = cargar_creditos_clientes();
            }
        }
        int idcliente=0;
        private void dgvcreditos_Click(object sender, EventArgs e)
        {
            idcliente = int.Parse(dgvcreditos.CurrentRow.Cells[0].Value.ToString());

            lblnombre.Text = dgvcreditos.CurrentRow.Cells[1].Value.ToString();
            lblcredito.Text = "RD$" + dgvcreditos.CurrentRow.Cells[2].Value.ToString();
            lblfechaultimop.Text = dgvcreditos.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
