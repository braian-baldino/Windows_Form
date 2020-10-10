using System;
using System.Collections.Generic;
using ClassLibrary;
using ClassLibrary.Helpers;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class PdfTest
    {
        private const string FileName = "archivoDePrueba.pdf";
        private readonly Balance April = new Balance { Month = EMonth.Abril, TotalIncomes = 50000, TotalSpendings = 15000, Result = 35000 };
        private readonly Balance July = new Balance { Month = EMonth.Julio, TotalIncomes = 20000, TotalSpendings = 10000, Result = -10000 };

        [TestMethod]
        public void CreateAnualBalancePDF()
        {
            var anualBalance = new YearlyBalance(2020);
            anualBalance.Balances.Add(April);
            anualBalance.Balances.Add(July);
            anualBalance.Result = 45000;

            PdfHelper.CreateAnualPdf(FileName,anualBalance);
        }

        [TestMethod]
        public void CellHandlerTest()
        {
            //Arrange
            var text = "cell handler unit test";
            PdfFont HelveticaRegular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Style NormalText = new Style().SetFontSize(10).SetFont(HelveticaRegular);

            //Act
            var result = PdfHelper.CellHandler(text,NormalText,2,2);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Cell));
    }
    }
}
