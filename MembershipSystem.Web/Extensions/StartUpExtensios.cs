﻿using MembershipSystem.Web.CustomValidations;
using MembershipSystem.Web.Localizations;
using MembershipSystem.Web.Models;

namespace MembershipSystem.Web.Extensions
{
	public static class StartUpExtensios
	{
		public static void AddIdentityWithExt(this IServiceCollection services)
		{
			services.AddIdentity<AppUser, AppRole>(options =>
			{
				options.User.RequireUniqueEmail = true;
				options.User.AllowedUserNameCharacters = "abcdefghijklmnoprstuvwxyz123456789_.";

				options.Password.RequiredLength = 6;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;
				options.Password.RequireDigit = true;

				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
				options.Lockout.MaxFailedAccessAttempts = 3;


			}).AddPasswordValidator<PasswordValidator>().AddUserValidator<UserValidator>().AddErrorDescriber<LocalizationIdentityErrorDescriber>().AddEntityFrameworkStores<AppDbContext>();
		}
	}
}
