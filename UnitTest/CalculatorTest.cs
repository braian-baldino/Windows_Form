using System;
using ClassLibrary;
using ClassLibrary.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly Balance July = new Balance { Month = EMonth.Julio, TotalIncomes = 20000, TotalSpendings = 10000, Result = -10000 };

        [TestMethod]
        public void CategoryCalculation()
        {
            Calculator.TotalBySpecifiedCategory(July,EIncome.Salario);
        }
    }
}
