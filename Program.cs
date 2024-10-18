using System.Net;
using System.Net.Mail;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using SendEmail;


static void RecibirCorreo()
{
  List<Mensajes> lisMensajes = new List<Mensajes>();
  string user = "a27302@svalero.com"; //"a27300@svalero.com"
  string pas = "sanvalero330507"; //S13rr4G0m3z
  string host = "imap.gmail.com";
  int puerto = 993;
  using (var client = new ImapClient())
      {
        using (var cancel = new CancellationTokenSource())
            {
              client.Connect(host, puerto, true, cancel.Token);

              client.Authenticate(user, pas, cancel.Token);

              IMailFolder inbox = client.Inbox;

              inbox.Open(FolderAccess.ReadOnly, cancel.Token);

              Console.WriteLine("Total messages: {0}", inbox.Count);

              for (int i = inbox.Count - 1; i > inbox.Count - 4; i--)
                {
                  MimeMessage message = inbox.GetMessage(i);
                  Mensajes mensaje = new Mensajes();
                  Console.WriteLine(message.Sender.ToString());
                  mensaje.Autor = message.From.ToString();
                  mensaje.Asunto = message.Subject;
                  mensaje.Cuerpo = message.TextBody.ToString();
                  mensaje.Fecha = message.Date.ToString().Substring(0, 15);
                  lisMensajes.Add(mensaje);
                  Console.WriteLine(i);
                  //  Console.WriteLine("Subject: {0}", message.Subject);
                }
                  lisMensajes.ForEach(item => Console.WriteLine(item.Asunto));
                  foreach (var item in lisMensajes)
                    {
                      Console.WriteLine($"\nMensaje enviado por {item.Autor}  con asunto: {item.Asunto} a fecha de {item.Fecha} que dice lo siguiente {item.Cuerpo.Substring(0, 50)}");

                    }


              client.Disconnect(true, cancel.Token);
          }
      }

}

RecibirCorreo();




//  +++ habilitar pop en Gmail Acc pop3
//  +++ dotnet add package MailKit
/*POP3 
Es un protocolo antiguo que originalmente se diseñó para usarse en un solo equipo,  carecen de la mayoría de las funciones básicas 
La capacidad de marcar un mensaje como leído y de enviar elementos en varios dispositivos.
No tiene la posibilidad e recibir  correos electrónicos en tiempo real, sino que actualiza periodicamente.

IMAP (Protocolo de acceso a mensajes de Internet)
Puede iniciar sesión con varios equipos y dispositivos al mismo tiempo, el archivo de correo se sincroniza y se almacena en el servido
El correo enviado y recibido se almacena en el servidor hasta que el usuario lo elimina

SMTP (Simple Mail Transfer Protocol)
Es un protocolo de mensajería : manda un email de un punto A (un servidor de origen o servidor saliente) a un punto B (un servidor de destino o servidor entrante)
-Servidor SMTP : ordenador encargado del servicio SMTP, (“cartero electrónico”), permite el transporte del correo electrónico por internet.
-La retransmisión SMTP: a través de un proceso de autenticación: servidor SMTP confirma las identidades del remitente y del destinatario ----> el envío se realiza.
-Puerto 25 para la comunicación entre servidores / Puerto 587 para la comunicación autenticada desde los clientes de correo.
*/
