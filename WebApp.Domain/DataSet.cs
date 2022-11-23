using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class DataSet
    {
        [Key]
        [ForeignKey("Department")]
        public string DepartmentName { get; set; }

        [Required]
        public int MinimumEmployees { get; set; }

        [Required]
        public int DepartmentStartHour { get; set; }

        [Required]
        public int DepartmentEndHour { get; set; }

        [Required]
        public int EmployeeWorkLoad { get; set; }

        [Required]
        public List<HourlyPoint> HourlyCurve { get; set; }

        [Required]
        public List<DataPoint> DataPoints { get; set; }

        [NotMapped]
        private double[] WeeklyCurve { get; set; }

        [NotMapped]
        private double[] MonthlyCurve { get; set; }

        [NotMapped]
        private double HolidayFactor { get; set; }

        [NotMapped]
        private int YearlyTotal { get; set; }

        [NotMapped]
        private static int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private void UpdateDataCurves()
        {
            WeeklyCurve = new double[7];
            MonthlyCurve = new double[12];
            HolidayFactor = 0;
            YearlyTotal = 0;

            int holidays = 0;
            int countedDays = 0;

            foreach(DataPoint point in DataPoints)
            {
                if(!point.IsHoliday)
                {
                    MonthlyCurve[point.Date.Month] += point.Value;
                    WeeklyCurve[(int)point.Date.DayOfWeek] += point.Value;
                    YearlyTotal += point.Value;
                    countedDays++;
                }
            }

            for(int i = 0; i < 12; i++) MonthlyCurve[i] /= YearlyTotal;
            for(int i = 0; i <  7; i++) WeeklyCurve[i]  /= YearlyTotal;

            YearlyTotal = YearlyTotal * 365 / countedDays;

            foreach(DataPoint point in DataPoints)
            {
                if(point.IsHoliday)
                {
                    int predictedValue = (int)(YearlyTotal * MonthlyCurve[point.Date.Month] * WeeklyCurve[(int)point.Date.DayOfWeek] * 7.0 / DaysInMonth[point.Date.Month]);
                    HolidayFactor += (double)point.Value / predictedValue;
                    holidays++;
                }
            }

            HolidayFactor /= holidays;
        }

        public int PredictValue(DateTime Date, bool holiday)
        {
            if(MonthlyCurve == null || WeeklyCurve == null) UpdateDataCurves();

            int predictedValue = (int)(YearlyTotal * MonthlyCurve[Date.Month] * WeeklyCurve[(int)Date.DayOfWeek] * 7.0 / DaysInMonth[Date.Month]);

            if(holiday) predictedValue = (int)(predictedValue * HolidayFactor);

            return predictedValue;
        }

        public int[] PredictHourlyValues(DateTime Date, bool holiday)
        {
            int predictedValue = PredictValue(Date, holiday);
            int[] hourlyValues = new int[24];

            foreach(HourlyPoint p in HourlyCurve)
                hourlyValues[p.Hour] = (int)(p.Value * predictedValue);

            return hourlyValues;
        }

        public int[] PredictHourlyEmployees(DateTime Date, bool holiday) {
            int predictedValue = PredictValue(Date, holiday);
            int[] hourlyValues = new int[24];

            foreach(HourlyPoint p in HourlyCurve)
                hourlyValues[p.Hour] = (int)(p.Value * predictedValue / EmployeeWorkLoad);

            for(int i = DepartmentStartHour; i <= DepartmentEndHour; i++)
                if(hourlyValues[i] < MinimumEmployees)
                    hourlyValues[i] = MinimumEmployees;

            return hourlyValues;
        }
    }
}
