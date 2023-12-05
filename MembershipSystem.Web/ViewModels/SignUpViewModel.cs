using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MembershipSystem.Web.ViewModels
{
	public class SignUpViewModel
	{
		public SignUpViewModel()
		{
			
		}
		public SignUpViewModel(string username, string email, string phone, string password)
		{
			UserName = username;
			Email = email;
			Phone = phone;
			Password = password;
		}
		[Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
		[Display(Name = "Kullanıcı Adı: ")]
		public string UserName { get; set; }
		[EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
		[Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
		[DisplayName("Email: ")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Telefon numarası boş bırakılamaz.")]
		[DisplayName("Telefon Numarası:")]
		public string Phone { get; set; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
		[DisplayName("Şifre: ")]
		[MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmamaktadır.")]
		[Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz.")]
		[DisplayName("Şifre Tekrar: ")]
		[MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
		public string PasswordConfirm { get; set; }
	}
}
