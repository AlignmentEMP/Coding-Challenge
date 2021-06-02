using System.Web.Mvc;
using testSite.Models.Pages;
using testSite.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace testSite.Controllers
{
    public class customPageController : PageControllerBase<customPage>
    {
        public ActionResult Index(customPage currentPage)
        {
            var model = customViewModel.Create(currentPage);
            return View(model);
        }
    }
}