using MembershipSystem.Web.Areas.Admin.Models;
using MembershipSystem.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserViewModel = MembershipSystem.Web.Areas.Admin.Models.UserViewModel;

namespace MembershipSystem.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public HomeController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> UserList()
		{
			var userList = _userManager.Users.ToList();
			var userViewModelList = userList.Select(x => new UserViewModel()
			{
				Id = x.Id,
				Email = x.Email,
				Name = x.UserName
			}).ToList();
			return View(userViewModelList);
		}
	}
}
