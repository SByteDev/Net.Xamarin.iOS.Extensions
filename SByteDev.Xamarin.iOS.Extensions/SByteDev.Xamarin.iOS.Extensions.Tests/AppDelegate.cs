using Foundation;
using NUnit.Runner;
using NUnit.Runner.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace SByteDev.Xamarin.iOS.Extensions.Tests
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : FormsApplicationDelegate
    {
        private static void Main(string[] args)
        {
            UIApplication.Main(args, null, nameof(AppDelegate));
        }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            LoadApplication(new App
            {
                Options = new TestOptions
                {
                    AutoRun = true,
                    TerminateAfterExecution = false,
                    CreateXmlResultFile = false
                }
            });

            return base.FinishedLaunching(app, options);
        }
    }
}