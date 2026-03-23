using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Shared
{
    public static class Mailler
    {
		public static void sendEmail()
		{
			string logFilePath = @"C:\Users\Laptop\source\repos\AppGestionCahierTexteV2\Logs\errorslogs.txt";

			try
			{
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress("saambadiall6@gmail.com");
				mail.To.Add("saambadiall6@gmail.com");
				mail.Subject = "Alerte - Fichier Log Application";
				mail.Body = "Veuillez trouver ci-joint le fichier log.";

				// Ajouter la pièce jointe
				Attachment attachment = new Attachment(logFilePath);
				mail.Attachments.Add(attachment);

				SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
				smtp.Credentials = new NetworkCredential("saambadiall6@gmail.com", "bpbo olwu pgul dkyk");
				smtp.EnableSsl = true;

				smtp.Send(mail);

				Console.WriteLine("Email envoyé avec succès.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erreur : " + ex.Message);
			}
		}
	}
}

