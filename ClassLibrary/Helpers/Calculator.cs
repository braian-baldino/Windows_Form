using System;
using System.Collections;
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

        public static double CalculateTotalBySpecifiedCategory(Balance balance,Enum category)
        {
            var type = category.GetType();
            var result = 0.0;

            switch (type.Name)
            {
                case "EIncome":
                    result = GetIncomeCategoryAmount(balance, (EIncome)category);
                    break;
                case "ESpending":
                    result = GetSpendingCategoryAmount(balance, (ESpending)category);
                    break;
                default:
                    break;
            }

            return result;
        }

        public static double CalculateTotalForAnualBySpecifiedCategory(YearlyBalance anualBalance, Enum categoryName)
        {
            var result = 0.0;
            foreach (var balance in anualBalance.Balances)
            {
                result += CalculateTotalBySpecifiedCategory(balance, categoryName);
            }

            return result;
        }

        private static double GetIncomeCategoryAmount(Balance balance,EIncome categoryName)
        {
            var count = 0.0;
            foreach (var income in balance.Incomes)
            {
                if (categoryName == income.Type)
                    count += income.Amount;
            }
            return count;
        }

        private static double GetSpendingCategoryAmount(Balance balance, ESpending categoryName)
        {
            var count = 0.0;
            foreach (var spending in balance.Spendings)
            {
                if (categoryName == spending.Type)
                    count += spending.Amount;
            }
            return count;
        }
    }
}
