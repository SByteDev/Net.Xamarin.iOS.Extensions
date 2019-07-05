using System;
using Foundation;

namespace SByte.Xamarin.iOS.Extensions
{
    public static class NsObjectExtensions
    {
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