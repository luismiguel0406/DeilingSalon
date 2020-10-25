using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class ConexionBD
    {
        public SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BDBEAUTYSALON;Integrated Security=True");

        /*@"Server=DBServer,1433;DataBase=BDBEAUTYSALON;User Id=Acceso;Password=04061991"*/

        //para abrir conexion
        public SqlConnection abrirconexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {

                conexion.Open();
            }

            return conexion;

        }//para cerrar conexion
        public SqlConnection cerrarconexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return conexion;



        }

    }
}

