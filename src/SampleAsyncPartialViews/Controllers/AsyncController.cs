using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleAsyncPartialViews.ViewModels;
using SampleAsyncPartialViews.Models;

namespace SampleAsyncPartialViews.Controllers
{
    public class AsyncController : Controller
    {
        Repository repository = new Repository();

        public ActionResult Index()
        {
			HomeViewModel vm = new HomeViewModel();
			vm.UserDetails.Items = repository.GetUserItems();
			//vm.NewsItems.Items = repository.GetNews();
			//vm.MostPopular.Items = repository.GetPopular();

			return View(vm);
        }

		public ActionResult News()
		{
			NewsItemsViewModel vm = new NewsItemsViewModel();
			vm.Items = repository.GetNews();
			return PartialView("NewsControl", vm);
		}

		public ActionResult Popular()
		{
			MostPopularViewModel vm = new MostPopularViewModel();
			vm.Items = repository.GetPopular();
			return PartialView("PopularControl", vm);
		}

    }
}
