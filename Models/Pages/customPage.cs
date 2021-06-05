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

        [Required]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Data Points",
            Order = 4)]
        [UIHint(Global.SiteUIHints.StringsCollection)]
        public virtual IList<string> customDataPoints { get; set; }

        [Required]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Labels List (use with 2 below)",
            Order = 5)]
        public virtual IList<string> customLabelsUserDefined { get; set; }

        [Required]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Values List (use with above and below)",
            Order = 5)]
        public virtual IList<int> customValuesUserDefined { get; set; }

        [Required]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Custom Images List (use with 2 above)",
            Order = 5)]
        public virtual IList<ContentReference> customImagesUserDefined { get; set; }


        //My first attempt at creating a 2D list that accepts generics, but it's actually not what I want here, as
        //there is no user-friendly way to import data like this
        /*[Display(
            GroupName = SystemTabNames.Content,
            Name = "Generic Property List",
            Order = 6)]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<testGenericDataPoints<string, int, ContentReference>>))]
        public virtual IList<testGenericDataPoints<string, int, ContentReference>> genericDataList { get; set; }

        public class testGenericDataPoints<T1, T2, T3>
        {
            public virtual T1 Label { get; set; }
            public virtual T2 Value { get; set; }
            public virtual T3 Image { get; set; }
        }

        [PropertyDefinitionTypePlugIn]
        public class testGenericProperty : PropertyList<testGenericDataPoints<string, int, ContentReference>> { }*/

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual ContentArea customContentArea { get; set; }

    }
}