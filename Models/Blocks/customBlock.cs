using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace testSite.Models.Blocks
{
    [ContentType(DisplayName = "Logo Block", GUID = "e7adddba-b539-49f8-8346-df2c7909987f", Description = "")]
    public class customBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Logo Block",
            Description = "A block meant for watermarking content",
            Order = 1)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference customImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual PageReference customLink { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string customHeading { get; set; }
    }
}