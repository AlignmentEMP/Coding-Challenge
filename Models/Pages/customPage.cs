using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace testSite.Models.Pages
{
    [SiteContentType(GUID = "0a93e7da-a6f2-4116-a986-29e988467e08")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-custom.png")]
    public class customPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}