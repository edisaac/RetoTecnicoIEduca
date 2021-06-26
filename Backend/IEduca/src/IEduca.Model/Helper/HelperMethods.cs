using System;
using System.Globalization;

namespace IEduca.Model.Helper
{
    public static class HelperMethods
    {
        public static TimeSpan GetMinutesAndSeconds(this string duration)
        {
            return DateTime.ParseExact(duration, "mm:ss", CultureInfo.InvariantCulture).TimeOfDay;

        }
    }
}
