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
    public partial class CUfacturacion : UserControl
    {
        public CUfacturacion()
        {
            InitializeComponent();
        }

        public string facidarticulo = "";
        public string facnombre = "";
        public string facprecio = "";
        // variables para calcular cantidad en la tabla dgvfacturas
        int cantidaddgvfac;
        float preciodgcfac;  // se cambio de float a decimal
        float subtotaldgvfac;// se cambio de float a decimal

        //Matriz para crear la lista a facturar
        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;

        //instancio las cosas que utilizare en sql

        ConexionBD.ConexionBD ConBD = new ConexionBD.ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader lector;
        SqlDataReader lector1;
        SqlDataReader lector2;
        DataTable Tabla = new DataTable();
        DataTable Tabla2 = new DataTable();
        // cosas que se usaran en sql

        // variables para obtener los datos de la empresa
        string empresa;
        string rnc;
        string direccion;
        string telefono;
        string celular;
        // variable para el descuento 
        double descuento=0;
        //
        public void datosempresa()
        {
            Comando.Connection = ConBD.abrirconexion();
            Comando.CommandText = "SELECT * FROM EMPRESA";
            Comando.CommandType = CommandType.Text;
            try
            {
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        
                         empresa = lector.GetString(1);
                         rnc = lector.GetString(2);
                         direccion = lector.GetString(3);
                         telefono = lector.GetString(4);
                         celular = lector.GetString(5);
                        

                    }

                }
            }
            catch (Exception)
            {

               // MessageBox.Show("No hay Datos", "Ajustes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            lector.Close();
            ConBD.cerrarconexion();
            
        }




        public DataTable cargarservicios_venta()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT ID_SERVICIO,SERVICIO,PRECIO FROM SERVICIOS ORDER BY SERVICIO";
                Comando.CommandType = CommandType.Text;
                lector1 = Comando.ExecuteReader();
                Tabla.Load(lector1);
                lector1.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {

              //  MessageBox.Show("No hay datos");
            }       
                
                 return Tabla;               
            
        }
        public DataTable cargarproductos_venta()
        {
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT ID_PRODUCTO,PRODUCTO,PRECIO_VENTA AS PRECIO,CANTIDAD FROM INVENTARIO ORDER BY PRODUCTO";
                Comando.CommandType = CommandType.Text;
                lector2 = Comando.ExecuteReader();
                Tabla2.Load(lector2);
                lector2.Close();
                ConBD.cerrarconexion();
            }
            catch (Exception)
            {

               // MessageBox.Show("No hay datos");
            }
            
            return Tabla2;

        }
        int id;
        string servicio_venta;
        string valor;
        //string cantidad;
        string empleado;
        double comisiones;
        int cuentafila = 0;
        string ganancia;
        string fecha;
        string tipodep;
        string tipodeventa;
        string findia;
        string pago_comision;//esta variable indicara si se pago la comision

        
        public void AñadirAReportes()

        {
            Comando.Connection = ConBD.abrirconexion();

            cuentafila = dgvfactura.RowCount;
            for (int i = 0; i < cuentafila; i++)
            {
                   id             = int.Parse(dgvfactura.Rows[i].Cells[0].Value.ToString());
                   servicio_venta = dgvfactura.Rows[i].Cells[1].Value.ToString();
                   valor          = dgvfactura.Rows[i].Cells[4].Value.ToString();

                if (id % 2 == 0)//significa es un servicio por ser modulo de 2
                {
                    try
                    {
                        //BUSCO EL VALOR DE COMISION EN LA TABLA SERVICIOS
                        //  Comando.Connection = ConBD.abrirconexion();
                        Comando.CommandText = "SELECT PRECIO_COMISION * COMISION FROM SERVICIOS WHERE ID_SERVICIO =" + id + "";
                        Comando.CommandType = CommandType.Text;
                        lector = Comando.ExecuteReader();
                        lector.Read();
                        comisiones = lector.GetDouble(0);
                        
                    }
                    catch (Exception)
                    {

                        comisiones = 0;
                    }
                    lector.Close();
                    ConBD.cerrarconexion();
                    tipodeventa = "Servicio";
                }
                else
                {
                    try
                    {
                        // si no BUSCO EL VALOR DE COMISION EN LA TABLA inventario
                        Comando.CommandText = "SELECT PRECIO_COSTO * COMISION FROM INVENTARIO WHERE ID_PRODUCTO =" + id + "";
                        Comando.CommandType = CommandType.Text;
                        lector = Comando.ExecuteReader();
                        lector.Read();
                        comisiones = lector.GetDouble(0);
                       
                    }
                    catch (Exception)
                    {

                        comisiones = 0;
                    }
                    lector.Close();
                    ConBD.cerrarconexion();
                    tipodeventa = "Producto";

                }
                   ganancia         =(Double.Parse(valor)-comisiones).ToString();
                
                   empleado         = cbleatendio.Text;
                   fecha            = DateTime.Now.ToString("yyyy-MM-dd");
                   tipodep          = tipopago;
                   findia           = "No";
                   pago_comision    = "No";

                //insertar la venta
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText= "INSERT INTO REPORTES_VENTAS(SERVICIO_VENTA,VALOR,REALIZADO_POR,COMISIONES,FECHA,GANANCIA,TIPO_DE_PAGO,TIPO_DE_VENTA,FIN_DIA,PAGO_COMISION) VALUES('" + servicio_venta + "',"+Convert.ToDouble(valor)+",'"+empleado+"',"+Convert.ToDouble(comisiones)+",'"+fecha+"',"+Convert.ToDouble(ganancia)+",'"+tipodep+"','"+tipodeventa+"','"+findia+"','"+pago_comision+"')";
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                ConBD.cerrarconexion();

            }
            
        }

        public void EliminarFaCturados()
        {//variables
            
            int idproductoFACTURA = 0;
            int idproductofacturacion = 0;
            int cantidadproductoFACTURA = 0;
            int cantidadproductofacturacion = 0;
            int cantidadRESTANTE = 0;
            int conteofilas = 0;
            // numero de filas
            conteofilas = dgvfactura.RowCount;

            //ciclo for


            for (int i = 0; i < conteofilas; i++)
            {
                idproductoFACTURA = int.Parse(dgvfactura.Rows[i].Cells[0].Value.ToString());
                cantidadproductoFACTURA = int.Parse(dgvfactura.Rows[i].Cells[3].Value.ToString());
                //si el modulo del id es diferente de 0 significa que es par por ende procede a hacer la reduccion del inventario
                if (idproductoFACTURA % 2 != 0)
                {

                    //// CONSULTAS 

                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "SELECT * FROM INVENTARIO WHERE ID_PRODUCTO=" + idproductoFACTURA + "";
                    Comando.CommandType = CommandType.Text;

                    try
                    {
                        lector = Comando.ExecuteReader();

                        if (lector.HasRows)
                        {

                            while (lector.Read())
                            {
                                idproductofacturacion = lector.GetInt32(0);
                                cantidadproductofacturacion = lector.GetInt32(5);
                            }
                        }

                        cantidadRESTANTE = cantidadproductofacturacion - cantidadproductoFACTURA;
                        lector.Close();
                        ConBD.cerrarconexion();

                        //se agrego esto


                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    ///////////////////////////////////////
                    Comando.Connection = ConBD.abrirconexion();
                    Comando.CommandText = "UPDATE INVENTARIO SET CANTIDAD =" + cantidadRESTANTE + " WHERE ID_PRODUCTO = " + idproductofacturacion + "";
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                    // se agrego esto
                    ConBD.cerrarconexion();
                    //refresco
                }
            }
            Tabla.Clear();
            dgvfacturacion.DataSource = cargarservicios_venta();

        }
        int idcliente;// para tener codigo de cliente
        public void clienteregistrado()
        {

                  Comando.Connection = ConBD.abrirconexion();
                 Comando.CommandText = "SELECT * FROM CLIENTES WHERE CODIGO =" + txtclientereg.Text + "";
                // comando.Parameters.AddWithValue(idcliente, txtclientereg.Text);
                  Comando.CommandType = CommandType.Text;

                try
                {
                    lector = Comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            idcliente = lector.GetInt32(0);
                            lblcliente.Text = (lector.GetString(1) + " " + lector.GetString(2)).ToString().ToUpperInvariant();
                            lblvisita.Text = (lector.GetInt32(7)).ToString();
                        }

                    lector.Close();
                }
                
                
                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente no existe","Clientes",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   
                }
            ConBD.cerrarconexion();
        }
        double creditoresultado = 0;
        double creditoobtenido = 0;
        public void credito_cliente()
        {
            if (rbcredito.Checked==true && idcliente!= 0)
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT CREDITO FROM CLIENTES WHERE CODIGO="+idcliente+"";
                Comando.CommandType = CommandType.Text;
                lector= Comando.ExecuteReader();

                lector.Read();
                creditoobtenido = lector.GetDouble(0);
                creditoresultado =  double.Parse(lbltotal.Text) + creditoobtenido;
                lector.Close();
                ConBD.cerrarconexion();
                //

                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "UPDATE CLIENTES SET CREDITO="+creditoresultado+"WHERE CODIGO ="+idcliente+"";
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                ConBD.cerrarconexion();
            }
             idcliente = 0;//igualo a cero pára que el credito en la siguiente venta si no es con cliente no se le valla
                          // a pasar a otro cliente el credito


        }
        int visitaobtenida;
        int visitaresultado;
        public void AgregarVisita()
        {
            if (idcliente!=0)
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT VISITAS FROM CLIENTES WHERE CODIGO=" + idcliente + "";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    visitaobtenida = lector.GetInt32(0);
                    visitaresultado = visitaobtenida + 1;
                }
                lector.Close();
                ConBD.cerrarconexion();
                //
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "UPDATE CLIENTES SET VISITAS=" + visitaresultado + " WHERE CODIGO=" + idcliente + "";
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                lector.Close();
                ConBD.cerrarconexion();
            }
            
           
        }
        public void CostoApagar()
        {
            float SubTotal = 0;
            int Conteo = 0;
            float tempo = 0;

            Conteo = dgvfactura.RowCount;

            for (int i = 0; i < Conteo; i++)
            {
                tempo = float.Parse(dgvfactura.Rows[i].Cells[4].Value.ToString());
                SubTotal = SubTotal + tempo;


            }
            lblsubtotal.Text = SubTotal.ToString();

        }

        private void CUfacturacion_Load(object sender, EventArgs e)
        {
          
            empleados(cbleatendio);
            btvender.Enabled = false;
          
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
           // busqueda por lo que se escriba
            if (txtbuscar.Text != "")
            {
                dgvfacturacion.CurrentCell = null;
                foreach (DataGridViewRow r in dgvfacturacion.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvfacturacion.Rows)
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

                if (rbservicios.Checked==true)
                {
                    Tabla.Clear();
                    Tabla2.Clear();
                    dgvfacturacion.DataSource = cargarservicios_venta();
                }
                if (rbproductos.Checked==true)
                {
                    Tabla.Clear();
                    Tabla2.Clear();
                    dgvfacturacion.DataSource = cargarproductos_venta();

                }
                
            }
        }

        private void btagregarlista_Click(object sender, EventArgs e)
        {
            if (facidarticulo != "" && facnombre != "" && facprecio != "")
            {
                ListaVenta[Fila, 0] = facidarticulo;
                ListaVenta[Fila, 1] = facnombre;
                ListaVenta[Fila, 2] = facprecio;


                dgvfactura.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2]);

                Fila++;
            }
        }

        public void empleados(ComboBox cb)
        { //llenar combobox con id proveedor
            try
            {
                Comando.Connection = ConBD.abrirconexion();
                Comando.CommandText = "SELECT NOMBRE FROM DATOS_EMPLEADOS ORDER BY NOMBRE";
                Comando.CommandType = CommandType.Text;
                lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    cb.Items.Add(lector["NOMBRE"].ToString());
                }
                lector.Close();
            }
            catch (Exception)
            {


            }

            ConBD.cerrarconexion();
        }


        private void dgvfacturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //estas son las posiciones corresposndientes a la tabla inventario y a su vez a la de facturacion
            // para que las variables tomen ese valor
            facidarticulo = dgvfacturacion.CurrentRow.Cells[0].Value.ToString();
            facnombre = dgvfacturacion.CurrentRow.Cells[1].Value.ToString();
            facprecio = dgvfacturacion.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvfactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // calculo del subtotal cuando la cantidad sea elegida


            if (dgvfactura.Columns[e.ColumnIndex].Name == "Column4")
            {
                try
                {
                    cantidaddgvfac = int.Parse(dgvfactura.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Agregue un producto a la lista");

                }
                try
                {
                    preciodgcfac = float.Parse(dgvfactura.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                catch (Exception)
                {

                    MessageBox.Show("Agregue un producto a la lista");
                }
                try
                {
                    if (cantidaddgvfac != 0 && preciodgcfac != 0)
                    {
                        subtotaldgvfac = cantidaddgvfac * preciodgcfac;
                        dgvfactura.Rows[e.RowIndex].Cells[4].Value = subtotaldgvfac.ToString();
                        CostoApagar();

                       


                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Parece hubo un error con el Subtotal " + ex);
                }


            }
        }

        private void dgvfacturacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //condicion de la celda
            if (this.dgvfacturacion.Columns[e.ColumnIndex].Name == "CANTIDAD")
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

        private void bteliminardelista_Click(object sender, EventArgs e)
        {
            try
            {
                dgvfactura.Rows.Remove(dgvfactura.CurrentRow);
                // se agrego costo a pagar si aplica
                CostoApagar();
                //
                if (dgvfactura.RowCount == 0)
                {
                    lblsubtotal.Text = "0.00";
                   // lblitbis.Text = "0.00";
                    txtdescuento.Text = "0.00";
                    lbltotal.Text = "0.00";
                    //

                }
            }

            catch (Exception)
            {
                //ACTIVAR LUEGO
                //MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void llbbuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clienteregistrado();
        }

       

       public string tipopago;
        private void tipodepago()
        {

            if (rbefectivo.Checked == true)
            {
                tipopago = "Efectivo";
                txttarjeta.Text = "0.00";
                try
                {
                    if (double.Parse(txtefectivo.Text) >= double.Parse(lbltotal.Text))
                    {
                        btvender.Enabled = true;
                    }
                    else { btvender.Enabled = false; }
                }
                catch (Exception)
                {

                    return;
                }
                
            }
            if (rbtarjeta.Checked == true)
            {
                tipopago = "Tarjeta";
                txtefectivo.Text = "0.00";
                txtdescuento.Text = "0.00";
                txttarjeta.Text = "0.00";
                txtefectivo.Enabled = false;
                txtdescuento.Enabled = false;
                btvender.Enabled = true;
            }
            if (rbcredito.Checked == true)
            {
                tipopago = "Credito";
                txtefectivo.Text = "0.00";
                txtdescuento.Text = "0.00";
                txttarjeta.Text = "0.00";
                txtefectivo.Enabled = false;
                txtdescuento.Enabled = false;
                btvender.Enabled = true;
            }
            if (rbvarios.Checked==true)
            {
                tipopago = "Efectivo";// poner a tipo de pago como varios en una a actualizacion
                txttarjeta.Text = "0.00";
                txtefectivo.Enabled = true;
                txtdescuento.Enabled = true;
                btvender.Enabled = true;
            }
            
        }


        private void btvender_Click(object sender, EventArgs e)
        {
            try
            { // colocar fuera mas luego
                datosempresa();

                DialogResult dialogo = MessageBox.Show("Se realizara una venta?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogo == DialogResult.Yes)

                {
                    /* reduce lo que se factura de la tabla inventario/facturacion*/
                    EliminarFaCturados();
                    //agrega la visita del cliente
                    AgregarVisita();
                    //añade las ventas a la tabla reportes
                    AñadirAReportes();
                    // credito a cliente
                    credito_cliente();
                    
                //
                Creador_de_factura.clsFuncion.CreaTicket Ticket1 = new Creador_de_factura.clsFuncion.CreaTicket();

                    Ticket1.TextoCentro(empresa); //imprime una linea de descripcion
                    Ticket1.TextoCentro("****************************");

                    Ticket1.TextoIzquierda(direccion);
                    Ticket1.TextoIzquierda("Tel:"+telefono+"  "+"Cel:"+celular);
                    Ticket1.TextoIzquierda("RNC: "+rnc);
                    Ticket1.TextoIzquierda("");
                    Ticket1.TextoIzquierda("Factura de Venta"); //imprime una linea de descripcion, se cambio de texto centro a izquierda
                    //Ticket1.TextoIzquierda("No Fac: 000");
                    Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                    Ticket1.TextoIzquierda("Le Atendio: " + cbleatendio.Text);///////////////////////////////////
                    Ticket1.TextoIzquierda("Cliente: "+lblcliente.Text);
                    Ticket1.TextoIzquierda("");
                    Creador_de_factura.clsFuncion.CreaTicket.LineasGuion();

                    Creador_de_factura.clsFuncion.CreaTicket.EncabezadoVenta();
                    Creador_de_factura.clsFuncion.CreaTicket.LineasGuion();
                    //try
                    //{

                        foreach (DataGridViewRow r in dgvfactura.Rows)

                        // LA TABLA FACTURA DEBE TENER ESTAS COLUMNAS PARA QUE COINCIDA CON LO QUE PUSE AQUI EL NUMERO DE LAS CELDAS
                        //ID FACTURA AUTOINCREMENTABLE POSICION 0
                        // NOMBRE DEL ARTICULO POSICION 1
                        //PRECIO POSICION 2
                        //CANTIDAD POSICION 3
                        // SUBTOTAL  POSICION 4

                        { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 

                            //se cambio de double a float
                            Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                        }

                    //}
                    //catch (Exception)
                    //{

                    //    MessageBox.Show("Complete los datos en la lista de venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}

                    Creador_de_factura.clsFuncion.CreaTicket.LineasGuion();
                    //                                
                    Ticket1.AgregaTotales("Sub-Total", float.Parse(lblsubtotal.Text)); // imprime linea con total
                   // Ticket1.AgregaTotales("Descuento", float(txtdescuento.Text)); // imprime linea con total
                                                                                               //                                 CAMBIE EL VALOR "0" POR EL VALOR DEL LABEL ITBIS
                   // Ticket1.AgregaTotales("ITBIS", float.Parse(lblitbis.Text)); // imprime linea con total
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Total", float.Parse(lbltotal.Text)); // imprime linea con total
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.TextoIzquierda("Tipo de Pago:          "+tipopago);
                    Ticket1.AgregaTotales("Efectivo:", float.Parse(txtefectivo.Text));
                    Ticket1.AgregaTotales("Tarjeta:", float.Parse(txttarjeta.Text));
                    Ticket1.AgregaTotales("Cambio:", float.Parse(lblcambio.Text));


                    // Ticket1.LineasTotales(); // imprime linea 

                    Ticket1.TextoIzquierda(" ");
                    Ticket1.TextoCentro("**************************");
                    Ticket1.TextoCentro("* Gracias por preferirnos *");

                    Ticket1.TextoCentro("**************************");
                    Ticket1.TextoIzquierda(" ");

                   

                    string impresora = "Microsoft XPS Document Writer"; //usar variable
                    Ticket1.ImprimirTiket(impresora);
                    //hasta aqui el codigo de imprimir


                    //reinicia el conteo de las filas en la tabla de factura
                    Fila = 0;
                    while (dgvfactura.RowCount > 0)//limpia el dgv
                    { dgvfactura.Rows.Remove(dgvfactura.CurrentRow); }

                     limpiarelementos();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se efectuo la venta por:" + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Dispose();
                
            }

        }

        public void limpiarelementos()
        {
            if (rbefectivo.Checked == true)
                rbefectivo.Checked = false;
            if (rbcredito.Checked == true)
                rbcredito.Checked = false;
            if (rbtarjeta.Checked == true)
                rbtarjeta.Checked = false;
            // los demas controles que intervienen en la venta

            lblsubtotal.Text = "0.00";
            //lblitbis.Text = "0.00";
            lblcambio.Text = "0.00";
            txtdescuento.Text = "0.00";//txtdescuento.Text = "";
            lbltotal.Text = "0.00";
            lblcliente.Text = "...";
            lblvisita.Text = "...";
            cbleatendio.Text = "Ingrese empleado";
            txtclientereg.Clear();
            descuento = 0;
            txtefectivo.Clear();
            btvender.Enabled = false;

        }
        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtefectivo.Text != "0.00")
                {
                    if (float.Parse(txtefectivo.Text) >= float.Parse(lbltotal.Text))
                    {
                        btvender.Enabled = true;
                    }
                    else
                    {
                        btvender.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
            try
            {
                if (rbefectivo.Checked==true)
                lblcambio.Text = (float.Parse(txtefectivo.Text) - float.Parse(lbltotal.Text)).ToString();
            }
            catch (Exception)
            {
                lblcambio.Text = "0.00";
            }



        }

        private void rbproductos_CheckedChanged(object sender, EventArgs e)
        {

            if (rbproductos.Checked == true)
            {                
                Tabla.Clear();
                Tabla2.Clear();
               
                dgvfacturacion.DataSource = cargarproductos_venta();
            }
        }

        private void rbservicios_CheckedChanged(object sender, EventArgs e)
        {
            if (rbservicios.Checked == true)
            {
                Tabla.Clear();
                Tabla2.Clear();
               
                dgvfacturacion.DataSource = cargarservicios_venta();
            }
        
        }

        private void lblsubtotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblsubtotal.Text != "0.00")

                    lbltotal.Text = lblsubtotal.Text;
                    AplicarDescuento();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifique el descuento digitado " + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        

        private void rbefectivo_CheckedChanged(object sender, EventArgs e)
        {
            tipodepago();

            if (rbefectivo.Checked == true)
            {
                txtefectivo.Enabled = true;
                txtdescuento.Enabled = true;
            }
            else
                txtefectivo.Enabled = false;
         }

        private void rbcredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcredito.Checked==true)
            {
                if (lblcliente.Text == "...")
                {
                    MessageBox.Show("Recuerde seleccionar el cliente y quien le atendio", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            //try
            //{
            //        if (txtefectivo.Text != "0.00")
            //        lblcambio.Text = (float.Parse(txtefectivo.Text) - float.Parse(lbltotal.Text)).ToString();
            //}
            //catch (Exception)
            //{
                lblcambio.Text = "0.00";
        //    }
        }
            
            tipodepago();
        }

        private void rbtarjeta_CheckedChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtefectivo.Text != "0.00")

            //        lblcambio.Text = (float.Parse(txtefectivo.Text) - float.Parse(lbltotal.Text)).ToString();
                
            //}
            //catch (Exception)
            //{
                lblcambio.Text = "0.00";
            //}
            tipodepago();
        }

        private void txtdescuento_Leave(object sender, EventArgs e)
        {// esto devolvera el valor del total cuando el descuento cambie

            AplicarDescuento();

        }
        public void AplicarDescuento()
        {

            if (descuento != double.Parse(txtdescuento.Text))
            {
                if (lbltotal.Text != "0.00")
                {// devuelve el valor que el total tenia antes de que se le reste el proximo descuento si aplica
                    lbltotal.Text = (double.Parse(lbltotal.Text) + descuento).ToString();
                }
            }
            try
            {
                if (txtdescuento.Text != "" && txtdescuento.Text != " ")
                {
                    descuento = double.Parse(txtdescuento.Text);
                }

                if (lbltotal.Text != "0.00")
                {  

                    lbltotal.Text = (double.Parse(lbltotal.Text) - descuento).ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void bteliminardelista_MouseLeave(object sender, EventArgs e)
        {
            bteliminardelista.BackColor = Color.FromArgb(182, 20, 235);
            bteliminardelista.ForeColor = Color.White;
        }

        private void bteliminardelista_MouseMove(object sender, MouseEventArgs e)
        {
            bteliminardelista.BackColor = Color.Red;
            bteliminardelista.ForeColor = Color.White;
        }

        private void cbleatendio_Enter(object sender, EventArgs e)
        {
            cbleatendio.Items.Clear();
            empleados(cbleatendio);
        }
    }
}
