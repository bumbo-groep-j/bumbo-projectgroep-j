using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApp.Domain.CSV
{
    public class CsvReader
    {
        private string _csvFilePath;

        public List<Employee> GetEmployeesFromCSV( StreamReader reader )
        {
            List<Employee> employeesFromCSV = new List<Employee>();
            string[]columns = reader.ReadLine().Split(',');
            int id = 1;
            while (!reader.EndOfStream)
            {
                int count = 0;
                string[] rows = reader.ReadLine().Split(',');
                Employee employee = new Employee();
                foreach ( string column in columns )
                {
                    switch (column)
                    {
                        case "Vn":
                            employee.FirstName = rows[count];
                            employee.UserName = rows[count];
                            break;
                        case "Tv":
                            employee.MiddleName = rows[count];
                            employee.UserName += rows[count];
                            break;
                        case "An":
                            employee.LastName = rows[count];
                            employee.UserName += rows[count];
                            break;
                        case "Geboortedatum":
                            employee.DateOfBirth = DateTime.Parse(rows[count]);
                            break;
                        case "Functie":
                            switch (rows[count])
                            {
                                case "Slager":
                                    employee.Department = new Department { Name = "Vers", PredictionValueName = "Colli" };
                                    break;
                                case "Vers":
                                    employee.Department = new Department { Name = "Vers", PredictionValueName = "Colli" };
                                    break;
                                case "Vakkenvuller":
                                    employee.Department = new Department { Name = "VKK", PredictionValueName = "Colli" };
                                    break;
                                case "Teamleider":
                                    employee.Department = new Department { Name = "Kassa", PredictionValueName = "Bezoekers" };
                                    break;
                            }
                            break;
                    }
                    count++;
                }
                employee.UserName = employee.UserName.Replace(" ", "");
                employee.NFCToken = "Token" + id;
                //employee.HourlyWage = 5;
                employee.Inactive = false;
                employee.Id = id;
                employeesFromCSV.Add(employee);
                id++;
            }
            return employeesFromCSV;
        }

        public List<WorkedHour> GetHoursFromCSV( List<Schedule> schedules, List<Employee> employees )
        {
            StreamReader reader = new StreamReader(_csvFilePath);
            List<WorkedHour> hoursFromCSV = new List<WorkedHour>();
            string[] columns = reader.ReadLine().Split(',');
            int id = 1;
            while (id < 500)
            {
                int count = 0;
                string[] rows = reader.ReadLine().Split(',');
                WorkedHour hour = new WorkedHour();
                Employee employee = employees.First(e => rows[1].Contains(e.FirstName + ' ' + e.MiddleName));
                foreach (string column in columns)
                {
                    switch (column)
                    {
                        case "Clock in":
                            hour.ClockedTimeStart = DateTime.Parse(rows[count]);
                            hour.ApprovedTimeStart = DateTime.Parse(rows[count]);
                            break;
                        case "Clock out":
                            hour.ClockedTimeEnd = DateTime.Parse(rows[count]);
                            hour.ApprovedTimeEnd = DateTime.Parse(rows[count]);
                            break;
                    }
                    count++;
                }
                Schedule schedule = schedules.First(s => s.EmployeeId == employee.Id);
                hour.ScheduleId = schedule.Id;
                hour.Department = schedule.Department;
                hoursFromCSV.Add(hour);
                hour.Id = -id;
                id++;
            }
            return hoursFromCSV;
        }
        public List<Schedule> GetSchedulesFromCSV(List<Employee> employees)
        {
            StreamReader reader = new StreamReader(_csvFilePath);
            List<Schedule> schedulesFromCSV = new List<Schedule>();
            string[] columns = reader.ReadLine().Split(',');
            int id = 1;
            while ( id < 500)
            {
                int count = 0;
                string[] rows = reader.ReadLine().Split(',');
                Schedule schedule = new Schedule();
                Employee employee = employees.First(e => rows[1].Contains(e.FirstName + ' ' + e.MiddleName));
                foreach (string column in columns)
                {
                    switch (column)
                    {
                        case "Clock in":
                            schedule.StartTime = DateTime.Parse(rows[count]);
                            break;
                        case "Clock out":
                            schedule.EndTime = DateTime.Parse(rows[count]);
                            break;
                    }
                    count++;
                }
                schedule.Department = employee.Department.Name;
                schedulesFromCSV.Add(schedule);
                schedule.EmployeeId = employee.Id;
                schedule.Id = -id;
                id++;
            }
            return schedulesFromCSV;
        }
    }
}
