using System;
using System.Collections.Generic;
using ClassLibrary;
using ClassLibrary.Serializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        Income salary = new Income();
        Income bonus = new Income();
        Spending vehicle = new Spending();
        Spending service = new Spending();
        Balance aprilBalance = new Balance(EMonth.Abril);
        YearlyBalance yearlyBal = new YearlyBalance(2020);

        [TestMethod]
        public void TestBalance()
        {

            salary.Date = DateTime.Today;
            salary.Amount = 30000;
            salary.Type = EIncome.Salario;
            salary.Description = "My Salary";

            bonus.Date = DateTime.Today;
            bonus.Amount = 5000;
            bonus.Type = EIncome.Bonus;
            bonus.Description = "Bonus from my company";

            vehicle.Date = DateTime.Today;
            vehicle.Amount = 500;
            vehicle.Type = ESpending.Vehiculo;
            vehicle.Description = "insurance";

            service.Date = DateTime.Today;
            service.Amount = 1500;
            service.Type = ESpending.Servicio;
            service.Description = "internet";

            aprilBalance += bonus;
            aprilBalance += salary;
            aprilBalance += service;
            aprilBalance += vehicle;

            Assert.IsNotNull(aprilBalance);
            //Expected Total Incomes 35000
            Assert.IsTrue(aprilBalance.TotalIncomes == 35000);
            //Expected Total Spendings 2000
            Assert.IsTrue(aprilBalance.TotalSpendings == 2000);
            //Expected Result 33000
            Assert.IsTrue(aprilBalance.Result == 33000);

        }

        [TestMethod]
        public void Serialization()
        {
            salary.Date = DateTime.Today;
            salary.Amount = 30000;
            salary.Type = EIncome.Salario;
            salary.Description = "My Salary";

            bonus.Date = DateTime.Today;
            bonus.Amount = 5000;
            bonus.Type = EIncome.Bonus;
            bonus.Description = "Bonus from my company";

            vehicle.Date = DateTime.Today;
            vehicle.Amount = 500;
            vehicle.Type = ESpending.Vehiculo;
            vehicle.Description = "insurance";

            service.Date = DateTime.Today;
            service.Amount = 1500;
            service.Type = ESpending.Servicio;
            service.Description = "internet";

            aprilBalance += bonus;
            aprilBalance += salary;
            aprilBalance += service;
            aprilBalance += vehicle;
            yearlyBal += aprilBalance;

            Assert.IsNotNull(Xml<YearlyBalance>.SaveBinaryXml("testBinary.bin", yearlyBal));
            Assert.IsNotNull(Xml<YearlyBalance>.ReadBinary("testBinary.bin", out YearlyBalance binaryData));
            Assert.IsNotNull(Xml<YearlyBalance>.SaveXml("test.xml", binaryData));
        }

        [TestMethod]
        public void Fix_DB()
        {
            //To read binary and generate xml
            Assert.IsNotNull(Xml<YearlyBalance>.ReadBinary("accountantDB.bin", out YearlyBalance binaryData));
            Assert.IsNotNull(Xml<YearlyBalance>.SaveXml("xmlDB.xml", binaryData));

            //To modify xml and serialize in binari again
            //Assert.IsNotNull(Xml<YearlyBalance>.ReadXml("xmlDB.xml", out YearlyBalance binaryData));
            //Assert.IsNotNull(Xml<YearlyBalance>.SaveBinaryXml("accountantDB.bin", binaryData));
        }
    }
}
