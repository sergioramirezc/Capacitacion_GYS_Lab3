using Lab3.App.UiTest.UITests;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Lab3.App.UiTest.Pages
{
    public class RamDetailPage : BasePage
    {
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("Computadora")
        };

        public RamDetailPage()
        {
        }

        public RamDetailPage LoadDetail()
        {
            app.WaitForElement(x => x.Marked("Computadora"));
            app.Screenshot("RamDetail");
            return this;
        }
    }
}