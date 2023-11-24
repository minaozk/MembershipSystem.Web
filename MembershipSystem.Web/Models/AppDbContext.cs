using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MembershipSystem.Web.Models
{
	public class AppDbContext : IdentityDbContext<AppUser,AppRole,string>
	{
		public AppDbContext(DbContextOptions options):base(options)
		{
			
		}

	}
}
