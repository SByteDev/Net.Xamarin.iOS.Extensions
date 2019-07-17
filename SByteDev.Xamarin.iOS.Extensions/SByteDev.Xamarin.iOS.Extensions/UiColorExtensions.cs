using System;
using UIKit;

namespace SByteDev.Xamarin.iOS.Extensions
{
    public static class UiColorExtensions
    {
        /// <summary>
        /// Converts provided <c>UIColor</c> to hexadecimal color representation.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>a hexadecimal color</returns>
        /// <exception cref="ArgumentNullException">if <c>UIColor</c> is <c>null</c></exception>
        public static string ToHexColor(this UIColor color)
        {
            if (color == null)
            {
                throw new ArgumentNullException(nameof(color));
            }

            color.GetRGBA(out var red, out var green, out var blue, out var alpha);

            return $"#{(int) (alpha * 255):X2}{(int) (red * 255):X2}{(int) (green * 255):X2}{(int) (blue * 255):X2}";
        }
    }
}