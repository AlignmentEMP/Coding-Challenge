using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using testSite.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using testSite.Models.Properties;
using EPiServer.Web;
using EPiServer.PlugIn;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;

namespace testSite.Models.Pages
{
    [SiteContentType(GUID = "0a93e7da-a6f2-4116-a986-29e988467e08")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-custom.png")]
    public class customPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Header",
            Order = 1)]
        public virtual XhtmlString customHeader { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Page Image",
            Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference customPageImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Main Body",
            Order = 3)]
        public virtual XhtmlString customMainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Data Points",
            Order = 4)]
        [UIHint(Global.SiteUIHints.StringsCollection)]
        public virtual IList<string> customDataPoints { get; set; }


        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom List with Images",
            Order = 5)]
        public virtual IList<string> customLabelValueImageList { get; set; }
    }
}