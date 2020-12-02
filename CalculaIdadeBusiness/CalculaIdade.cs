using System;

namespace CalculaIdadeBusiness
{
    public class CalculaIdade : ICalculaIdade
    {
        public string CalculateFullAge(DateTime bornDate)
        {
            var years = CalculateYearsAge(bornDate);
            var months = CalculateMonthsAge(bornDate);
            var days = CalculateDaysAge(bornDate);
            return $"{years} years, {months} months and {days} days";
        }

        public int CalculateYearsAge(DateTime bornDate)
        {
            return new DateTime(DateTime.Now.Subtract(bornDate).Ticks).Year - 1;
        }

        public int CalculateMonthsAge(DateTime bornDate)
        {
            var years = CalculateYearsAge(bornDate);
            var currentDate = DateTime.Now;
            var currentBitrthday = bornDate.AddYears(years);
            int months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (currentBitrthday.AddMonths(i) == currentDate)
                {
                    months = i;
                    break;
                }
                else if (currentBitrthday.AddMonths(i) >= currentDate)
                {
                    months = i - 1;
                    break;
                }
            }
            return months;
        }

        public int CalculateDaysAge(DateTime bornDate)
        {
            var currentDate = DateTime.Now;
            var years = CalculateYearsAge(bornDate);
            var currentBitrthday = bornDate.AddYears(years);
            var months = CalculateMonthsAge(bornDate);
            return currentDate.Subtract(currentBitrthday.AddMonths(months)).Days;
        }
    }
}
