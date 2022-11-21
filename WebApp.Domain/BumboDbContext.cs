using Microsoft.EntityFrameworkCore;


namespace WebApp.Domain
{
    public class BumboDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set;}
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<SchoolSchedule> SchoolSchedules { get; set; }  
        public DbSet<WorkedHour> WorkedHours { get; set; }
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
                new Employee { EmployeeId = 1, FirstName = "testUser1FirstName", MiddelName = "", LastName = "testUser1LastName", Birthdate = new DateTime(2000, 12, 20), Email = "tester1@mail.com", NFCToken = "Token1" },
                new Employee { EmployeeId = 2, FirstName = "testUser2FirstName", MiddelName = "", LastName = "testUser2LastName", Birthdate = new DateTime(1999, 6, 10), Email = "tester2@mail.com", NFCToken = "Token2" },
                new Employee { EmployeeId = 3, FirstName = "testUser3FirstName", MiddelName = "testUser3MiddelName", LastName = "testUser3LastName", Birthdate = new DateTime(1985, 8, 2), Email = "tester3@mail.com", NFCToken = "Token3" }
             );
            #endregion

            #region Divisions
            modelBuilder.Entity<Department>().HasData(
                new Department { Name = "Verkoop" },
                new Department { Name = "Magazijn" }
             );
            #endregion

            #region Prognosis
            modelBuilder.Entity<Prognosis>().HasData(
                new Prognosis { Id = 1, Department = "Verkoop", TotalColli = 3, TotalCustomers = 10, Date = new DateTime(2020, 11, 20) },
                new Prognosis { Id = 2, Department = "Magazijn", TotalColli = 10, TotalCustomers = 15, Date = new DateTime(2020, 11, 20) }
                );
            #endregion

            #region SchoolMoment
            modelBuilder.Entity<SchoolSchedule>().HasData(
                new SchoolSchedule { Id = 1, EmployeeId = 1,  WeekDay = WeekDays.Maandag, StartTime = new DateTime(2022, 11, 21, 8, 30, 0), EndTime = new DateTime(2022, 11, 21, 13, 0, 0) },
                new SchoolSchedule { Id = 2, EmployeeId = 1,  WeekDay = WeekDays.Woensdag, StartTime = new DateTime(2022, 11, 22, 13, 0, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new SchoolSchedule { Id = 3, EmployeeId = 2,  WeekDay = WeekDays.Vrijdag, StartTime = new DateTime(2022, 11, 25, 8, 30, 0), EndTime = new DateTime(2022, 11, 25, 16, 0, 0) },
                new SchoolSchedule { Id = 4, EmployeeId = 3,  WeekDay = WeekDays.Dinsdag, StartTime = new DateTime(2022, 11, 24, 8, 30, 0), EndTime = new DateTime(2022, 11, 24, 16, 0, 0) }
                );
            #endregion

            #region Availablitity
            modelBuilder.Entity<Availability>().HasData(
                new Availability {Id = 1, EmployeeId = 1, WeekDay = WeekDays.Maandag, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Availability {Id = 2, EmployeeId = 1, WeekDay = WeekDays.Donderdag, StartTime = new DateTime(2022, 11, 24, 11, 0, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0)},
                new Availability {Id = 3, EmployeeId = 2, WeekDay = WeekDays.Dinsdag ,StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Availability {Id = 4, EmployeeId = 3, WeekDay = WeekDays.Dinsdag, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)}
                );
            #endregion

            #region ScheduledService
            modelBuilder.Entity<Schedule>().HasData(
                new Schedule {Id = 1 ,EmployeeId = 1, Department = "Magazijn", StartTime = new DateTime(2022, 11, 24, 11, 0, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0)},
                new Schedule {Id = 2, EmployeeId = 1, Department = "Verkoop", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Schedule {Id = 3, EmployeeId = 2, Department = "Verkoop", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new Schedule {Id = 4, EmployeeId = 3, Department = "Magazijn", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) }
                );
            #endregion

            #region WorkedService
            modelBuilder.Entity<WorkedHour>().HasData(
                new WorkedHour {Id = 1, EmployeeId = 1, Department = "Magazijn" ,ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new WorkedHour {Id = 2, EmployeeId = 1, Department = "Verkoop", ApprovalTime = new DateTime(2022, 11, 24, 11, 0, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0) },
                new WorkedHour {Id = 3, EmployeeId = 2, Department = "Verkoop",ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new WorkedHour {Id = 4, EmployeeId = 3, Department = "Magazijn",  ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) }
            );
            #endregion
            
        }

    }
}

