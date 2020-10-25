using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Capa_Gestion_de_seguridad
{
    public  class ServicioDeCorreo
    {
        private SmtpClient smtpclient;
        protected string correo { get; set; }
        protected string contraseña { get; set; }
        protected string host { get; set; }
        protected int puerto { get; set; }
        protected bool ssl { get; set; }
        
        protected void inicializarsmtpclient()
        {
            smtpclient = new SmtpClient();
            smtpclient.Credentials = new NetworkCredential(correo, contraseña);
            smtpclient.Host = host;
            smtpclient.Port = puerto;
            smtpclient.EnableSsl = ssl;

        }

        public void enviardecorreo(string asunto , string contenido,string CorreoReceptor) {
            var MensajeDeCorreo = new MailMessage();
            try
            {
                MensajeDeCorreo.From = new MailAddress(correo);
                MensajeDeCorreo.To.Add(CorreoReceptor);
                MensajeDeCorreo.Subject = asunto;
                MensajeDeCorreo.Body = contenido;
                MensajeDeCorreo.Priority = MailPriority.Normal;
                smtpclient.Send(MensajeDeCorreo);

            }
            catch (Exception ex) { }
           finally {
                MensajeDeCorreo.Dispose();
                smtpclient.Dispose();
              
                    }




        }


    }
}
