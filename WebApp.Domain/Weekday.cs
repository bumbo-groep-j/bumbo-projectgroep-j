using System.ComponentModel;
using System.Reflection;

namespace WebApp.Domain
{
    public static class Weekdays
    {
        public static string GetName(Weekday weekday)
        {
            FieldInfo fi = weekday.GetType().GetField(weekday.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return (attributes.Length > 0) ? attributes[0].Description : weekday.ToString();
        }
    }

    public enum Weekday
    {
        [Description("Maandag")]
        Monday,
        [Description("Dinsdag")]
        Tuesday,
        [Description("Woensdag")]
        Wednesday,
        [Description("Donderdag")]
        Thursday,
        [Description("Vrijdag")]
        Friday,
        [Description("Zaterdag")]
        Saturday,
        [Description("Zondag")]
        Sunday
    }
}
