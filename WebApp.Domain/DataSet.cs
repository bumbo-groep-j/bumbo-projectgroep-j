using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class DataSet
    {
        [Key]
        [ForeignKey("Department")]
        public string DepartmentName { get; set; }

        // The minimum amount of employees working in this department at any given time
        [Required]
        public int MinimumEmployees { get; set; }

        [Required]
        public int DepartmentStartHour { get; set; }

        [Required]
        public int DepartmentEndHour { get; set; }

        // This value represents how many customers / colli one employee can handle in an hour. This is used to calculate
        // how many employees are needed based on the amount of customers / colli.
        [Required]
        public int EmployeeWorkLoad { get; set; }

        // The hourly curve is the distribution of customers / colli throughout a day, this would be based on yearly averages.
        // The hourly curve for example indicates that at 8:00 there are usually around 8% of all the customers in an average day,
        // or that at 13:00 there are usually around 11% of the customers in a day.
        [Required]
        public List<HourlyPoint> HourlyCurve { get; set; }

        [Required]
        public List<DataPoint> DataPoints { get; set; }

        // The weekly curve is the distribution of customers / colli throughout a week, this is calculated from the entire data set.
        // The weekly curve for example indicates that on Monday there are usually around 10% of all the customers in an average week,
        // or that on Sunday there are usually around 15% of the customers in a week.
        [NotMapped]
        private double[] WeeklyCurve { get; set; }

        // The monthly curve is the distribution of customers / colli throughout the months, this is calculated from the entire data set.
        // The monthly curve for example indicates that in January there are usually around 9% of all the customers in an average year,
        // or that in December there are usually around 12% of the customers in a year.
        [NotMapped]
        private double[] MonthlyCurve { get; set; }

        // This Value is calculated from the entire data set. It represents how many more customers / colli there usually are on holidays / just before holidays
        [NotMapped]
        private double HolidayFactor { get; set; }

        // Sum of all Values in an average year
        [NotMapped]
        private int YearlyTotal { get; set; }

        // Amount of days in each month
        [NotMapped]
        private static int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // This function regenerates the data curves from the current data points
        private void UpdateDataCurves()
        {
            WeeklyCurve = new double[7];
            MonthlyCurve = new double[12];
            HolidayFactor = 0;
            YearlyTotal = 0;

            int holidays = 0;
            int countedDays = 0;

            // Loop through each entry in the data set and add its Value to the respective weekday and month
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

            // Divide each Value in the curves by the total, this will turn each Value into a percentage of the total
            for(int i = 0; i < 12; i++) MonthlyCurve[i] /= YearlyTotal;
            for(int i = 0; i <  7; i++) WeeklyCurve[i]  /= YearlyTotal;

            // Turn our total into a yearly total, in other words into the total of an average year. This is done so that
            // the prediction works regardless of the sample size, be it 1 year, 5 years, or 50 years. Without this step
            // the predicted Values would get bigger and bigger the larger the data set is.
            YearlyTotal = YearlyTotal * 365 / countedDays;

            // To calculate the holiday factor we loop through each data point that is a holiday and calculate what the amount
            // of customers/deliveries would be on that day if it was not a holiday. Then we divide the actual Value stored in
            // the dataset by our predicted Value, and this is the factor by which our estimate was off. The holiday factor is
            // the average of all the factors we calculate in this loop.
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
            // Calculate weekly and monthly curve if they are still null
            if(MonthlyCurve == null || WeeklyCurve == null) UpdateDataCurves();

            // To predict a Value, we multiply the average yearly total by the monthly curve for the chosen month and the weekly curve for the chosen week.
            // This gives us an estimate for how many customers will arrive on (for example) EVERY Monday in February. To get the amount of customers that will
            // arrive on one single Monday in February we then have to divide this number by the amount of weeks in the chosen month.
            // The amount of weeks in a month is simply the amount of days in that month divided by 7, as there are 7 days in a week.
            int predictedValue = (int)(YearlyTotal * MonthlyCurve[Date.Month] * WeeklyCurve[(int)Date.DayOfWeek] * 7.0 / DaysInMonth[Date.Month]);

            // If the chosen day is a holiday, multiply it by the holiday factor
            if(holiday) predictedValue = (int)(predictedValue * HolidayFactor);

            return predictedValue;
        }

        public int[] PredictHourlyValues(DateTime Date, bool holiday)
        {
            int predictedValue = PredictValue(Date, holiday);
            int[] hourlyValues = new int[24];

            // To predict the Values over the individual hours in a day we simply multiply our predicted Value for the day
            // with the Value of the hourly curve at each individual hour. For example if we predicted 1000 customers on this
            // given day, and our hourly curve tells us that there are on average 6% of all customers at 8:00, we can multiply
            // these two Values to calculate that there will be about 60 customers at 8:00.
            foreach(HourlyPoint p in HourlyCurve)
                hourlyValues[p.Hour] = (int)(p.Value * predictedValue);

            return hourlyValues;
        }

        // This function works nearly exactly like the function above, but while the function above calculates how many
        // customers are scheduled to arrive at any particular hour, this function calculates how many employees are
        // required for that set amount of customers. This is done by simply dividing the amount of customers at that
        // given hour by the EmployeeWorkload factor (i.e. how many customers one single cashier can service in an hour)
        public int[] PredictHourlyEmployees(DateTime Date, bool holiday) {
            int predictedValue = PredictValue(Date, holiday);
            int[] hourlyValues = new int[24];

            foreach(HourlyPoint p in HourlyCurve)
                hourlyValues[p.Hour] = (int)(p.Value * predictedValue / EmployeeWorkLoad);

            // Ensure there is always at least the minimum amount of employees scheduled
            for(int i = DepartmentStartHour; i <= DepartmentEndHour; i++)
                if(hourlyValues[i] < MinimumEmployees)
                    hourlyValues[i] = MinimumEmployees;

            return hourlyValues;
        }
    }
}
