using System;
using Foundation;

namespace SByte.Xamarin.iOS.Extensions
{
    public static class NsObjectExtensions
    {
        /// <summary>
        /// Invokes provided action on main UI thread.
        /// </summary>
        /// <param name="object">Source object.</param>
        /// <param name="action">Action to invoke.</param>
        public static void InvokeOnMainThreadIfNeeded(this NSObject @object, Action action)
        {
            if (@object == null)
            {
                throw new ArgumentNullException(nameof(@object));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (NSThread.IsMain)
            {
                action.Invoke();
            }
            else
            {
                @object.InvokeOnMainThread(action);
            }
        }
    }
}