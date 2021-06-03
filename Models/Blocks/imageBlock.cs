using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace testSite.Models.Blocks
{
    [ContentType(DisplayName = "Image", GUID = "1c8e2c89-57d1-42fe-a631-ac38df60a900", Description = "For showing an image")]
    [SiteImageUrl]
    public class imageBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentReference Image { get; set; }
    }
}