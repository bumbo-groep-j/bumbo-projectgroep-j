namespace Bumbo.Models
{
    public class ClockedHour
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ScheduledStartTime { get; set; }

        public DateTime ScheduledEndTime { get; set; }

        public DateTime ClockedStartTime { get; set; }

        public DateTime? ClockedEndTime { get; set; }

        public DateTime? ApprovedStartTime { get; set; }

        public DateTime? ApprovedEndTime { get; set; }

        public TimeSpan? WorkedHours { get; set; }

        public DateTime? ApprovalTime { get; set; }

        public string TimeDifference { get; set; }

        public bool SickLeave { get; set; }
    }
}
