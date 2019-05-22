using Lab3.App.Services;
using Lab3.App.ViewModels.Base;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
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
            ViewModelLocator.RegisterDependencies(useMockServices: true);
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override async void OnStart()
        {
            base.OnStart();

            AppCenter.Start("android=48afbb71-5326-4169-b771-0d157fed036d;" +
                  "uwp={Your UWP App secret here};" +
                  "ios=e6239c0d-ecca-47af-b1e1-7d7cdd61922a",
                  typeof(Crashes),typeof(Analytics),typeof(Push));

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
