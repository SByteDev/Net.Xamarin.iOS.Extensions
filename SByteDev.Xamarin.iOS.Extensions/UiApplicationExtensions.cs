using System.Linq;
using UIKit;

namespace SByteDev.Xamarin.iOS.Extensions
{
    public static class UiApplicationExtensions
    {
        /// <summary>
        /// Searches for a topmost presented <c>UIViewController</c>.
        /// </summary>
        /// <param name="application"></param>
        /// <returns>The topmost <c>UIViewController</c> or <c>null</c> if not found.</returns>
        public static UIViewController GetTopViewController(this UIApplication application)
        {
            var topViewController = application?.KeyWindow?.RootViewController;

            if (topViewController == null)
            {
                return null;
            }

            while (topViewController.PresentedViewController != null)
            {
                topViewController = topViewController.PresentedViewController;
            }

            var navigationController = topViewController as UINavigationController;

            if (navigationController != null)
            {
                topViewController = navigationController.ViewControllers.LastOrDefault();
            }

            return topViewController ?? navigationController;
        }
    }
}