using System;
using System.IO;
using System.Reflection;
using Xamarin.UITest;

namespace Lab3.App.UiTest.UITests
{
    internal static class AppManager
    {
        /*App center command
        appcenter test run uitest --app "GysCapacitacion/Lab3" --devices "GysCapacitacion/set-android-gama-alta" --app-path "D:\capa\Lab3\src\Mobile Apps\Lab3.App\Lab3.App.Android\bin\Release\com.lab.sergio-Signed.apk" --test-series "automated-ui-test" --locale "es_MX" --build-dir "D:\capa\Lab3\Tests\Lab3.App.UiTest\bin\Release" --uitest-tools-dir "C:\Users\sergio.ramirez\.nuget\packages\xamarin.uitest\2.2.7\tools"
        */
        private const string ApkPath = "src\\Mobile Apps\\Lab3.App\\Lab3.App.Android\\bin\\Release\\com.lab.sergio-Signed.apk";

        private static IApp app;

        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return app;
            }
        }

        private static Platform? platform;

        public static Platform Platform
        {
            get
            {
                if (platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }

        public static void StartApp()
        {
            var _path = @"D:\capa\Lab3\src\Mobile Apps\Lab3.App\Lab3.App.Android\bin\Release\com.lab.sergio-Signed.apk";


            if (Platform == Platform.Android)
            {
                app = ConfigureApp
                    .Android
                    // Used to run a .apk file:
                    .ApkFile(_path)
                    .StartApp();
            }
        }
    }
}