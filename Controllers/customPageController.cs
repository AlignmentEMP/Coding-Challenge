using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using testSite.Models.Pages;

namespace testSite.Controllers
{
    public class customPageController : PageControllerBase<customPage>
    {
        public ActionResult Index(customPage currentPage)
        {
            return View(currentPage);
        }
    }
}