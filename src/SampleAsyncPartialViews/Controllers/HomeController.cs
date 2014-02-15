using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleAsyncPartialViews.Models;
using SampleAsyncPartialViews.ViewModels;

namespace SampleAsyncPartialViews.Controllers
{
    public class HomeController : Controller
    {
        private Repository repository = new Repository();

        public ActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.UserDetails.Items = repository.GetUserItems();
            vm.NewsItems.Items = repository.GetNews();
            vm.MostPopular.Items = repository.GetPopular();

            return View(vm);
        }

    }
}
