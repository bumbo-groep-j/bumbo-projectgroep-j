using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace Database
{
    public class BumboDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Division> Divisions { get; set;}
        public DbSet<ScheduledService> ScheduledServices { get; set; }
        public DbSet<SchoolMoment> Schoolmoments { get; set; }  
        public DbSet<WorkedService> WorkedServices { get; set; }
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
                new Employee { EmployeeId = 1, FirstName = "testUser1FirstName", Insertion = "", LastName = "testUser1LastName", Birthdate = new DateTime(2000, 12, 20), Email = "tester1@mail.com", NFCToken = "Token1" },
                new Employee { EmployeeId = 2, FirstName = "testUser2FirstName", Insertion = "", LastName = "testUser2LastName", Birthdate = new DateTime(1999, 6, 10), Email = "tester2@mail.com", NFCToken = "Token2" },
                new Employee { EmployeeId = 3, FirstName = "testUser3FirstName", Insertion = "", LastName = "testUser3LastName", Birthdate = new DateTime(1985, 8, 2), Email = "tester3@mail.com", NFCToken = "Token3" }
             );
            #endregion

            #region Divisions
            modelBuilder.Entity<Division>().HasData(
                new Division { DivisionName = "Verkoop" },
                new Division { DivisionName = "Magazijn" }
             );
            #endregion

            #region Prognosis
            modelBuilder.Entity<Prognosis>().HasData(
                new Prognosis { Id = 1, DivisionName = "Verkoop", TotalColli = 3, TotalCustomers = 10, Date = new DateTime(2020, 11, 20) },
                new Prognosis { Id = 2, DivisionName = "Magazijn", TotalColli = 10, TotalCustomers = 15, Date = new DateTime(2020, 11, 20) }
                );
            #endregion

            #region SchoolMoment
            modelBuilder.Entity<SchoolMoment>().HasData(
                new SchoolMoment { Id = 1, EmployeeId = 1, TotalHour = 20, date = new DateTime(2022, 11, 21) },
                new SchoolMoment { Id = 2, EmployeeId = 1, TotalHour = 20, date = new DateTime(2022, 11, 23) },
                new SchoolMoment { Id = 3, EmployeeId = 2, TotalHour = 20, date = new DateTime(2022, 11, 21) },
                new SchoolMoment { Id = 4, EmployeeId = 3, TotalHour = 20, date = new DateTime(2022, 11, 21) }
                );
            #endregion

            #region Availablitity
            modelBuilder.Entity<Availability>().HasData(
                new Availability {Id = 1, EmployeeId = 1, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Availability {Id = 2, EmployeeId = 1, StartTime = new DateTime(2022, 11, 24, 11, 0, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0)},
                new Availability {Id = 3, EmployeeId = 2, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new Availability {Id = 4, EmployeeId = 3, StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)}
                );
            #endregion

            #region ScheduledService
            modelBuilder.Entity<ScheduledService>().HasData(
                new ScheduledService {Id = 1 ,EmployeeId = 1, DivisionName = "Magazijn", StartTime = new DateTime(2022, 11, 24, 11, 0, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0)},
                new ScheduledService {Id = 2, EmployeeId = 1, DivisionName = "Verkoop", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0)},
                new ScheduledService {Id = 3, EmployeeId = 2, DivisionName = "Verkoop", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new ScheduledService {Id = 4, EmployeeId = 3, DivisionName = "Magazijn", StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) }
                );
            #endregion

            #region WorkedService
            modelBuilder.Entity<WorkedService>().HasData(
                new WorkedService {Id = 1, EmployeeId = 1, ApprovalMoment = new DateTime(2022, 11, 22, 8, 30, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new WorkedService {Id = 2, EmployeeId = 1, ApprovalMoment = new DateTime(2022, 11, 24, 11, 0, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 24, 17, 0, 0) },
                new WorkedService {Id = 3, EmployeeId = 2, ApprovalMoment = new DateTime(2022, 11, 22, 8, 30, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) },
                new WorkedService {Id = 4, EmployeeId = 3, ApprovalMoment = new DateTime(2022, 11, 22, 8, 30, 0), StartTime = new DateTime(2022, 11, 22, 8, 30, 0), EndTime = new DateTime(2022, 11, 22, 16, 0, 0) }
            );
            #endregion

        }

    }
}

