using WebApp.Domain;

namespace Bumbo.Models
{
    public class ScheduleForm
    {
        public IList<bool> IsChecked { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public string DepartmentName { get; set; }

        public List<Availability> Availabilities { get; set; }

        public List<Schedule> Schedules { get; set; }

        public ScheduleForm()
        {
            IsChecked = new List<bool>();
        }
    }
}
