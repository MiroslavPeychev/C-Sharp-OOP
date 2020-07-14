namespace DefiningClasses
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        public static double GetDaysBetweenTwoDates(string dateOne, string dateTwo)
        {
            DateTime firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (firstDate>secondDate)
            {
                return GetDaysBetweenTwoDates(dateTwo, dateOne);
            }

            return (secondDate - firstDate).Days;
        }
    }
}