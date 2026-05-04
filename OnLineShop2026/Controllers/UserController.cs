using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
		IUserRepository userRepository;

		public UserController(IUserRepository userRep)
		{
			this.userRepository = userRep;
		}

		public IActionResult Index(Guid id)
		{
			var user = userRepository.TryGetById(id);
			if (user == null) return null;
			return View(user);
		}
	}
}
