using Lab3.App.UiTest.UITests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Lab3.App.UiTest.Pages
{
    public class EventListPage : BasePage
    {
        Query MenuButtom;
        Query AppName;
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("OK")
        };

        public EventListPage()
        {
            if (OnAndroid)
            {
                MenuButtom = x => x.Marked("OK");
                AppName = x => x.Marked("AppName");
            }
        }

        public EventListPage OpenMenu()
        {
            app.Tap(MenuButtom);
            app.WaitForElement(AppName);
            app.Screenshot("MenuOpened");
            return this;
        }

        public EventListPage CloseMenu()
        {
            app.Back();
            app.Screenshot("MenuClosed");
            return this;
        }

        public void EventDetailTap(string marker)
        {
            app.Tap(marker);
        }
    }
}
