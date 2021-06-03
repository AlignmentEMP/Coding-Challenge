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
            Order = 200)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 201)]
        public virtual XhtmlString Header { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 202)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 203)]
        public virtual XhtmlString Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 204)]
        public virtual XhtmlString List { get; set; }

    }
}