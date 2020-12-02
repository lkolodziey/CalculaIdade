using System;

namespace CalculaIdadeBusiness
{
    public interface ICalculaIdade
    {
        string CalculateFullAge(DateTime bornDate);
        int CalculateYearsAge(DateTime bornDate);
        int CalculateMonthsAge(DateTime bornDate);
        int CalculateDaysAge(DateTime bornDate);
    }
}
