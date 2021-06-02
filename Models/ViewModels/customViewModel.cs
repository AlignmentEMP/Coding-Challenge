using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using testSite.Models.Pages;

namespace testSite.Models.ViewModels
{
    public class customViewModel<T> : PageViewModel<customPage>
    {
        public customViewModel(customPage currentPage) : base(currentPage)
        {
            CurrentPage = currentPage;
        }

        public new customPage CurrentPage { get; set; }
    }

    public class customViewModel
    {
        public static customViewModel<T> Create<T>(T page) where T : customPage
        {
            return new customViewModel<T>(page);
        }
    }
}