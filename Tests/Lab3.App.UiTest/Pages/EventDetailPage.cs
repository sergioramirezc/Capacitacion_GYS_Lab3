using Lab3.App.UiTest.UITests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Lab3.App.UiTest.Pages
{
    public class EventDetailPage : BasePage
    {
        Query ViewMoreLabel;
        Query FavoriteButtom;
        Query ViewMapButtom;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("Comprar")
        };

        public EventDetailPage()
        {
            if (OnAndroid)
            {
                ViewMoreLabel = x => x.Id("NoResourceEntry-112");
                FavoriteButtom = x => x.Id("NoResourceEntry-110");
                ViewMapButtom = x => x.Button("Ver mapa");
            }
        }

        public EventDetailPage ViewMap()
        {   
            app.ScrollDownTo(ViewMapButtom);
            app.Tap(ViewMapButtom);
            AssertOnPage(TimeSpan.FromSeconds(30));
            app.Screenshot("Map");
            return this;
        }

    }
}
