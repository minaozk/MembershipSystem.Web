using Microsoft.AspNetCore.Identity;

namespace MembershipSystem.Web.Localizations
{
	public class LocalizationIdentityErrorDescriber : IdentityErrorDescriber
	{
		public override IdentityError DuplicateUserName(string userName)
		{
			return new()
			{
				Code = "DuplicateUserName",
				Description = $"{userName} daha önce başka bir kullanıcı tarafından alınmıştır."
			};

		}

		public override IdentityError DuplicateEmail(string email)
		{
			return new()
			{
				Code = "DuplicateEmail",
				Description = $"{email} daha önce başka bir kullanıcı tarafından alınmıştır."
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new()
			{
				Code = "PasswordRequiresDigit",
				Description = $"Şifreniz sayısal karakter içermelidir."
			}; ;
		}

		public override IdentityError PasswordTooShort(int length)
		{
			return new()
			{
				Code = "PasswordTooShort",
				Description = $"Şifreniz en az 6 karakter olmalıdır."
			}; ;
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Şifreniz büyük harf içermelidir."
			}; ;
		}

		public override IdentityError InvalidEmail(string? email)
		{
			return new()
			{
				Code = "InvalidEmail",
				Description = "Email geçersiz."
			}; ;
		}
	}
}
