using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MembershipSystem.Web.Models
{
	public class ForgetPasswordViewModel
	{
		[EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
		[Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
		[DisplayName("Email: ")]
		public string Email { get; set; }
	}
}
