using WebApp.Domain;

namespace Bumbo.Models
{
    public class AvailabilityForm
    {
        public Weekday Weekday { get; set; }

        public bool HasAvailability1 { get; set; }

        public bool HasAvailability2 { get; set; }

        public Availability? Availability1 { get; set; }

        public Availability? Availability2 { get; set; }
    }
}
