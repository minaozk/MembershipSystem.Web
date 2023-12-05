using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MembershipSystem.Web.ViewModels
{
	public class PasswordChangeViewModel

	{

		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
		[DisplayName("Eski Şifre: ")]
		[MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
		public string PasswordOld { get; set; } = null!;

		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Yeni şifre alanı boş bırakılamaz.")]
		[DisplayName("Yeni Şifre: ")]
		[MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
		public string PasswordNew { get; set; } = null!;

		[DataType(DataType.Password)]
		[Compare(nameof(PasswordNew), ErrorMessage = "Şifreler uyuşmamaktadır.")]
		[Required(ErrorMessage = "Yeni şifre tekrar alanı boş bırakılamaz.")]
		[DisplayName("Yeni Şifre Tekrar: ")]
		[MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
		public string PasswordNewConfirm { get; set; } = null!;
	}
}
