using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
    public static class Calculator
    {
        public static string FormatValue(double value)
        {
            return String.Format("{0:0.00}", value);
        }

        public static double AverageIncomesPerMonth(YearlyBalance anualBalance)
        {
            return anualBalance.TotalSaved / anualBalance.Balances.Count;
        }

        public static double AverageSpendingsPerMonth(YearlyBalance anualBalance)
        {
            return anualBalance.TotalSpent / anualBalance.Balances.Count;
        }
    }
}
