using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application["visits"] = int.Parse(Application["visits"].ToString()) + 1;
            Application.UnLock();
            Counter.Text = Application["visits"].ToString();

            HttpCookie userCookie;
            userCookie = Request.Cookies["UserID"];
            if (userCookie == null)
            {
                Label1.Text = "No existe la cookie, creando cookie ahora...";
                userCookie = new HttpCookie("UserID", "Enrique");
                userCookie.Expires = DateTime.Now.AddSeconds(10);
                Response.Cookies.Add(userCookie);
            }
            else
            {
                Label1.Text = "Bienvenido otra vez, " + userCookie.Value;
            }

        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            Application["visits"] = 0;
        }

        protected void Mail_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("ear64@gcloud.ua.es", "Alias remitente");
               
                MailAddress toAddress = new MailAddress("ear64@gcloud.ua.es", "Alias destinatario");
               
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Probando el envío!";
                message.Body = "Este es el cuerpo del mensaje";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("", "");
               
                smtpClient.Send(message);
                Label1.Text = "Mensaje enviado.";
            }
            catch (Exception ex)
            {
                Label1.Text = "No se pudo enviar el mensaje!";
            }
        }
    }
}
