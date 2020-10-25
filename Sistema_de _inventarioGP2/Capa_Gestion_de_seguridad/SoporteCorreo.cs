using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace Capa_Gestion_de_seguridad
{
    class SoporteCorreo:ServicioDeCorreo
    {
        // tomar datos de la base de datos proxima ocasion
        public SoporteCorreo()
        {
            correo = "familycybber04@hotmail.com";
            contraseña = "imprimir1";
            host = "smtp.live.com";
            puerto = 587;
            ssl = true;
            inicializarsmtpclient();
        }
    }
}
