using Microsoft.AspNetCore.Identity;

namespace MembershipSystem.Web.Models
{
	public class AppUser : IdentityUser
	{
		public string City { get; set; }
	}
}
