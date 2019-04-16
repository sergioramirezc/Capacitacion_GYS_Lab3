using Lab3.App.Services;
using Lab3.App.ViewModels.Base;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lab3.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitApp();
        }

        private void InitApp()
        {
            ViewModelLocator.RegisterDependencies(useMockServices: false);
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override async void OnStart()
        {
            base.OnStart();

            AppCenter.Start("android=30eeeca5-2acc-4ffd-b0e6-4bb51e89b594;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Crashes),typeof(Analytics));

            await InitNavigation();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
