using CalculaIdadeBusiness;
using System;
using Xunit;

namespace CalculaIdadeTests
{
    public class CalculaIdadeTests
    {
        [Fact]
        public void CalculateFullAgeTest()
        {
            ICalculaIdade calculo = new CalculaIdade();
            int ano = 1979;
            int mes = 9;
            int dia = 17;
            DateTime bornDate = new DateTime(ano, mes, dia);
            var years = calculo.CalculateYearsAge(bornDate);
            var months = calculo.CalculateMonthsAge(bornDate);
            var days = calculo.CalculateDaysAge(bornDate);

            var expected = $"{years} years, {months} months and {days} days";

            var result = calculo.CalculateFullAge(bornDate);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void CalculateYearAgeTest()
        {
            ICalculaIdade calculo = new CalculaIdade();
            int ano = 1979;
            int mes = 9;
            int dia = 17;
            DateTime bornDate = new DateTime(ano, mes, dia);
            var result = calculo.CalculateYearsAge(bornDate);
            var expected = DateTime.Now.AddYears(ano * -1).Year;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateMonthDiffTest()
        {
            ICalculaIdade calculo = new CalculaIdade();
            int ano = 1979;
            int mes = 9;
            int dia = 17;
            DateTime bornDate = new DateTime(ano, mes, dia);
            var currentDate = DateTime.Now;
            var years = calculo.CalculateYearsAge(bornDate);
            var currentBitrthday = bornDate.AddYears(years);
            int expected = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (currentBitrthday.AddMonths(i) == currentDate)
                {
                    expected = i;
                    break;
                }
                else if (currentBitrthday.AddMonths(i) >= currentDate)
                {
                    expected = i - 1;
                    break;
                }
            }
            var result = calculo.CalculateMonthsAge(bornDate);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateDaysDiffTest()
        {
            ICalculaIdade calculo = new CalculaIdade();
            int ano = 1979;
            int mes = 9;
            int dia = 17;
            var bornDate = new DateTime(ano, mes, dia);
            var currentDate = DateTime.Now;
            var years = calculo.CalculateYearsAge(bornDate);
            var currentBitrthday = bornDate.AddYears(years);
            var months = calculo.CalculateMonthsAge(bornDate);

            var expected = currentDate.Subtract(currentBitrthday.AddMonths(months)).Days;
            var result = calculo.CalculateDaysAge(bornDate);
            Assert.Equal(expected, result);
        }

    }
}
