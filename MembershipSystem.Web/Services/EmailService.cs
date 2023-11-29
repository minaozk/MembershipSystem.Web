using System.Net;
using System.Net.Mail;
using MembershipSystem.Web.OptionsModels;
using Microsoft.Extensions.Options;

namespace MembershipSystem.Web.Services
{
	public class EmailService : IEmailService
	{
		private readonly EmailSettings _emailSettings;


		public EmailService(IOptions<EmailSettings> options)
		{
			_emailSettings = options.Value;
		}

		public async Task SendResetPasswordEmail(string resetPassswordEmailLink, string toEmail)
		{
			var smtpClient = new SmtpClient();
			smtpClient.Host = _emailSettings.Host;
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Port = 587;
			smtpClient.Credentials = new NetworkCredential(_emailSettings.Email, _emailSettings.Password);
			smtpClient.EnableSsl = true;

			var mailMessage = new MailMessage();

			mailMessage.From = new MailAddress(_emailSettings.Email);
			mailMessage.To.Add(toEmail);

			mailMessage.Subject = "Şifre sıfırlama linki";
			mailMessage.Body = @$"
            <h4>Şifrenizi yenilemek için aşağıdaki linke tıklayınız.</h4> <p><a href ='{resetPassswordEmailLink
            }'>Şifre yenileme linki</a></p>";

			mailMessage.IsBodyHtml = true;
			await smtpClient.SendMailAsync(mailMessage);

		}
	}
}
