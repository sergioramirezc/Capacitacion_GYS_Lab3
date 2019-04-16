using Lab3.App.UiTest.UITests;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Lab3.App.UiTest.Pages
{
    public class RamListPage : BasePage
    {
        readonly Query RamButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("+")
        };

        public RamListPage()
        {
            if (OnAndroid)
            {
                RamButton = x => x.Marked("Corsair");
            }
        }

        public RamListPage LoadItems()
        {
            app.WaitForElement(RamButton);
            app.Screenshot("RamList");
            return this;
        }

        public void SelectItem()
        {
            app.Tap(RamButton);
        }
    }
}
