using Microsoft.EntityFrameworkCore;

namespace WebApp.Domain
{
    public class BumboDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set;}
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<SchoolSchedule> SchoolSchedules { get; set; }  
        public DbSet<WorkedHours> WorkedHours { get; set; }
        public DbSet<Prognosis> Prognosis { get; set; }
        public DbSet<Availability> Availabilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Server=.;Database=BumboDB;Trusted_Connection=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "testUser1FirstName", MiddleName = "", LastName = "testUser1LastName", DateOfBirth = new DateTime(2000, 12, 20), NFCToken = "Token1" },
                new Employee { Id = 2, FirstName = "testUser2FirstName", MiddleName = "", LastName = "testUser2LastName", DateOfBirth = new DateTime(1999, 6, 10), NFCToken = "Token2" },
                new Employee { Id = 3, FirstName = "testUser3FirstName", MiddleName = "testUser3MiddelName", LastName = "testUser3LastName", DateOfBirth = new DateTime(1985, 8, 2), NFCToken = "Token3" }
            );
            #endregion

            #region Department
            modelBuilder.Entity<Department>().HasData(
                new Department { Name = "Verkoop" },
                new Department { Name = "Magazijn" }
            );
            #endregion

            #region SchoolSchedule
            modelBuilder.Entity<SchoolSchedule>().HasData(
                new SchoolSchedule { Id = 1, EmployeeId = 1,  Weekday = Weekday.Monday, StartTime = new DateTime(2022, 11, 21, 8, 30, 0), EndTime = new DateTime(2022, 11, 21, 13, 0, 0) },
                new SchoolSchedule { Id = 2, EmployeeId = 1,  Weekday = Weekday.Wednesday, StartTime = new DateTime(2022, 11, 22, 13, 0, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new SchoolSchedule { Id = 3, EmployeeId = 2,  Weekday = Weekday.Friday, StartTime = new DateTime(2022, 11, 25, 8, 30, 0), EndTime = new DateTime(2022, 11, 25, 16, 0, 0) },
                new SchoolSchedule { Id = 4, EmployeeId = 3,  Weekday = Weekday.Tuesday, StartTime = new DateTime(2022, 11, 24, 8, 30, 0), EndTime = new DateTime(2022, 11, 24, 16, 0, 0) }
            );
            #endregion

            #region Availability
            modelBuilder.Entity<Availability>().HasData(
                new Availability { Id = 1, EmployeeId = 1, Weekday = Weekday.Monday, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Availability { Id = 2, EmployeeId = 1, Weekday = Weekday.Thursday, StartTime = new DateTime(2022, 11, 24, 11, 0, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0)},
                new Availability { Id = 3, EmployeeId = 2, Weekday = Weekday.Tuesday ,StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Availability { Id = 4, EmployeeId = 3, Weekday = Weekday.Tuesday, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)}
            );
            #endregion

            #region Schedule
            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1 ,EmployeeId = 1, Department = "Magazijn", StartTime = new DateTime(2022, 11, 24, 11, 0, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0)},
                new Schedule { Id = 2, EmployeeId = 1, Department = "Verkoop", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Schedule { Id = 3, EmployeeId = 2, Department = "Verkoop", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new Schedule { Id = 4, EmployeeId = 3, Department = "Magazijn", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) }
            );
            #endregion

            #region WorkedHours
            modelBuilder.Entity<WorkedHours>().HasData(
                new WorkedHours { Id = 1, EmployeeId = 1, Department = "Magazijn", ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeStart = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeEnd = new DateTime(2022, 11, 22, 16, 0, 0) },
                new WorkedHours { Id = 2, EmployeeId = 1, Department = "Verkoop", ApprovalTime = new DateTime(2022, 11, 24, 11, 0, 0), ClockedTimeStart = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeEnd = new DateTime(2022, 11, 24, 17, 0, 0) },
                new WorkedHours { Id = 3, EmployeeId = 2, Department = "Verkoop", ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeStart = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeEnd = new DateTime(2022, 11, 22, 16, 0, 0) },
                new WorkedHours { Id = 4, EmployeeId = 3, Department = "Magazijn", ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeStart = new DateTime(2022, 11, 22, 8, 30, 0), ClockedTimeEnd = new DateTime(2022, 11, 22, 16, 0, 0) }
            );
            #endregion
        }
    }
}