using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MembershipSystem.Web.ViewModels
{
	public class SignInViewModel
	{
		public SignInViewModel()
		{
			
		}
		public SignInViewModel(string email, string password)
		{
			Email = email;
			Password = password;
		}
		[Required(ErrorMessage = "Email boş bırakılamaz.")]
		[Display(Name = "Email")]
		[EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
		[Display(Name = "Şifre")]
		public string Password { get; set; }

		[Display(Name = "Beni Hatırla")]
		public bool RememberMe { get; set; }
	}
}
