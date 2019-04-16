using System;
using System.IO;
using System.Reflection;
using Xamarin.UITest;

namespace Lab3.App.UiTest.UITests
{
    internal static class AppManager
    {
        private const string ApkPath = "src\\Mobile Apps\\Lab3.App\\Lab3.App.Android\\bin\\Release\\com.arkano.test-Signed.apk";

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
            var _path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            _path = _path.Replace("Tests\\Lab3.App.UiTest\\bin\\Debug", ApkPath).Replace("file:\\", "");


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