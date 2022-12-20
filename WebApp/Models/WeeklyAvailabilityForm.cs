using WebApp.Domain;

namespace Bumbo.Models
{
    public class WeeklyAvailabilityForm
    {
        public IList<bool> HasAvailability { get; set; }

        public IList<Availability> Availability { get; set; }

        public IList<bool> CanCreateInstantly { get; set; }
    }
}
