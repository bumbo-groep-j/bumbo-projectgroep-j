namespace Bumbo.Models
{
    public class ApprovedHoursForm
    {
        public int WorkedHourId { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }
    }
}
