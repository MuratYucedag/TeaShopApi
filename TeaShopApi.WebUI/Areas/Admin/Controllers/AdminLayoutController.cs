using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

		public PartialViewResult PartialSidebar()
		{
			return PartialView();
		}

		public PartialViewResult PartialNavbar()
		{
			return PartialView();
		}

		public PartialViewResult PartialContent()
		{
			return PartialView();
		}
	}
}