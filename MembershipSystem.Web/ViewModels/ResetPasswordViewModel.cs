using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MembershipSystem.Web.ViewModels
{
	public class ResetPasswordViewModel
	{
		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
		[DataType(DataType.Password)]
		[DisplayName(" Yeni Şifre: ")]
		public string Password { get; set; }


		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmamaktadır.")]
		[Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz.")]
		[DisplayName("Yeni Şifre Tekrar: ")]
		public string PasswordConfirm { get; set; }
	}
}
