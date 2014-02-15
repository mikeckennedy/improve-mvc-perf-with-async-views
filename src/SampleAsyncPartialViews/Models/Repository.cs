using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace SampleAsyncPartialViews.Models
{
    public class Repository
    {
        internal string[] GetUserItems()
        {
            // fast
            return new[]
                       {
                           "Don't forget the milk",
                           "Pay the phone bill",
                           "Renew car insurance",
                           "Mow the lawn before leaving on vacation",
                       };
        }

        internal string[] GetNews()
        {
            // slow
			Thread.Sleep(500);

            return new[]
                       {
                           "International Energy Agency foresees an energy-independent US within 10 years",
                           "Review: The Mac mini takes the Ivy Bridge to Fusion Town",
                           "Google's Nexus 7 gets a fresh coat of paint for the holidays",
                           "Everyone agrees with us on climate change - especially when we're wrong",
                       };
        }

        internal string[] GetPopular()
        {
            // slowest
			Thread.Sleep(2000);

            return new[]
                       {
                           "Internet Explorer 10 finally comes to Windows 7",
                           "Apple boosts retail store performance despite Browett's missteps",
                           "Apple's Tim Cook beefing up employee perks, personal project time",
                           "Judge blasts troll for \"lack of interest in actually litigating\"",
                           "Kodak gets life-saving loan of $793 million—if it can sell its patents",
                       };
        }
    }
}