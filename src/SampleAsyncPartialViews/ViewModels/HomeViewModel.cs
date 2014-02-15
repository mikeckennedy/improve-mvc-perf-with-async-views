using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAsyncPartialViews.ViewModels
{
    public class HomeViewModel
    {
        public UserDetailsViewModel UserDetails { get; set; }
        public NewsItemsViewModel NewsItems { get; set; }
        public MostPopularViewModel MostPopular { get; set; }

        public HomeViewModel()
        {
            UserDetails = new UserDetailsViewModel();
            NewsItems = new NewsItemsViewModel();
            MostPopular = new MostPopularViewModel();
        }
    }
}