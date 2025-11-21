using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Configura los detalles del remitente y destinatario
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress(CorreoRemitente.Text); // Tu dirección de correo
                string Vendedor;
                mensaje.To.Add(CorreoDestino.Text); // Destinatario
                mensaje.Subject = Asunto.Text;
                string Excel = "C:\\Inventario\\InventarioGeneral.xlsx";
                Attachment adjunto = new Attachment(Excel);
                mensaje.Attachments.Add(adjunto);
                // Desactiva la validación del certificado para pruebas (no recomendado para producción)
                System.Net.ServicePointManager.ServerCertificateValidationCallback =
                    (sender, certificate, chain, sslPolicyErrors) => true;

                // Configuración del cliente SMTP (usando Gmail como ejemplo)
                SmtpClient clienteSmtp = new SmtpClient("smtp.papeleriacornejo.com", 587); // Servidor SMTP y puerto
                clienteSmtp.Credentials = new NetworkCredential(CorreoRemitente.Text, PwCorreo.Text); // Credenciales
                clienteSmtp.EnableSsl = true; // SSL para una conexión segura
                                              // Envía el correo
                clienteSmtp.Send(mensaje);
                MensajeOK mensajeOK = new MensajeOK();
                mensajeOK.texto.Text = "Correo enviado correctamente."; // Mensaje de éxito
                mensajeOK.ShowDialog(); // Muestra un mensaje de éxito
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.", ex.Message);
            }
        }

        private void CorreoRemitente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PwCorreo.Focus(); // Mueve el foco al campo de contraseña
            }
        }

        private void PwCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CorreoDestino.Focus(); // Mueve el foco al campo de destinatario
            }
        }

        private void CorreoDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Asunto.Focus(); // Mueve el foco al campo de asunto
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Asunto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Enviar_Click(sender, e); // Llama al método de envío al presionar Enter
            }
        }
    }
}
