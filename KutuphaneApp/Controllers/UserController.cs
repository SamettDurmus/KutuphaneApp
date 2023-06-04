using KutuphaneApp.Entity.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneApp.Controllers
{
	[Authorize]
	public class UserController : Controller
	{
		private readonly UserManager<User> _userManager;

		private readonly SignInManager<User> _signInManager;
		public UserController(UserManager<User> userManager , SignInManager<User> signInManager)
        {
			_userManager=userManager;
			_signInManager=signInManager;

		}
        public IActionResult Login()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}
	}
}
