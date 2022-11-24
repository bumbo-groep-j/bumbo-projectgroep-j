using System.Web;

namespace Bumbo.Models
{
    public class CalendarData
    {
        public int CurrentMonth;
        public int CurrentYear;
        public int FirstWeekdayOfMonth;

        public DateOnly Today;
        public DateOnly Selected;

        public DateOnly? MinimumDay;
        public DateOnly? MaximumDay;

        public string? Link;

        public string Month
        {
            get
            {
                switch(CurrentMonth)
                {
                    case 1: return "Januari";
                    case 2: return "Februari";
                    case 3: return "Maart";
                    case 4: return "April";
                    case 5: return "Mei";
                    case 6: return "Juni";
                    case 7: return "Juli";
                    case 8: return "Augustus";
                    case 9: return "September";
                    case 10: return "Oktober";
                    case 11: return "November";
                    case 12: return "December";
                    default: return "";
                }
            }
        }

        public string? EscapedLink
        {
            get
            {
                if(Link == null) return null;

                return HttpUtility.UrlEncode(Link);
            }
        }
    }
}