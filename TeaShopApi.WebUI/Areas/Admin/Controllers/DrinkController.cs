using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DrinkController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
