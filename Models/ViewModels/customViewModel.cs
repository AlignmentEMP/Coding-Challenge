using EPiServer.Core;
using System;
using System.Web.Mvc;
using testSite.Models.Pages;

namespace testSite.Models.ViewModels
{
    public class customViewModel<T> : PageViewModel

    {
        public customViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }
    }

    public static class customViewModel
    {
        public static customViewModel<T> Create<T>(T page) where T: PageViewModel
        {
            return new customViewModel<T>(page);
        }
    }
}