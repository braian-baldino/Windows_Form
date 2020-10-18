using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Diagnostics;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using System.Collections.Generic;
using iText.Layout.Properties;
using System;
using C = ClassLibrary.Helpers.Calculator; 

namespace ClassLibrary.Helpers
{
    public static class PdfHelper
    {
        #region Properties
        private static PdfWriter Writer { get; set; }
        private static Document Document { get; set; }
        private static MemoryStream MemStream { get; set; }
        #endregion

        #region Fonts & Styles
        //Fonts
        private static PdfFont HelveticaRegular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
        private static PdfFont HelveticaBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

        //Styles
        private static Style Header = new Style()
                                    .SetFontSize(16)
                                    .SetFont(HelveticaBold);

        private static Style Title = new Style()
                                    .SetFontSize(14)
                                    .SetFont(HelveticaBold);

        private static Style SubTitle = new Style()
                                    .SetFontSize(12)
                                    .SetFont(HelveticaBold);

        private static Style NormalText = new Style()
                                    .SetFontSize(10)
                                    .SetFont(HelveticaRegular);

        private static Style NormalTextBold = new Style()
                                    .SetFontSize(10)
                                    .SetFont(HelveticaBold);

        private static Style NegativeNormalText = new Style()
                                    .SetFontSize(10)
                                    .SetFontColor(ColorConstants.RED)
                                    .SetFont(HelveticaRegular);

        private static Style CellHeader = new Style()
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(14)
                                    .SetFont(HelveticaBold);

        #endregion

        #region Ctor
        static PdfHelper()
        {
            MemStream = new MemoryStream();
            Writer = new PdfWriter(MemStream);
            Document = new Document(new PdfDocument(Writer),PageSize.A4);    
        }
        #endregion

        public static void CreateAnualPdf(string fileName, YearlyBalance yearBalance)
        {
            try
            {
                SetAnualDocumentInfo(yearBalance);

                byte[] bytesStream = MemStream.ToArray();
                MemStream = new MemoryStream();
                MemStream.Write(bytesStream, 0, bytesStream.Length);
                MemStream.Position = 0;

                using (FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    MemStream.CopyTo(file);
                    Process.Start(fileName);
                }
            }
            catch (Exception)
            {
                Document.Close();
            }
            
        }

        #region Private Methods
        public static Cell CellHandler(string text, Style style, int cellRow = 1, int cellCol = 1)
        {
            return new Cell(cellRow, cellCol).Add(new Paragraph(text).AddStyle(style));
        }

        private static void GenerateSpaces(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                Document.Add(new Paragraph(""));
            }
        }

        private static void SetAnualDocumentInfo(YearlyBalance anualBalance)
        {
            //Content         
            Document.Add(new Paragraph($"Balance Anual {anualBalance.Year}").AddStyle(Header));
            GenerateSpaces(1);

            Document.Add(new Paragraph($"Total ${C.FormatValue(anualBalance.Result)}").AddStyle(Header));

            CreateAnualTablePerMonthBalance(anualBalance.Balances);

            GenerateSpaces(2);

            CreateAnualDetailsTable(anualBalance);

            GenerateSpaces(2);

            AnualIncomeCategoryTable(anualBalance);

            GenerateSpaces(2);

            AnualSpendingCategoryTable(anualBalance);

            Document.Close();
        }
     
        private static void CreateAnualTablePerMonthBalance(List<Balance> balances)
        {                     
            Table table = new Table(4).UseAllAvailableWidth();
            table.AddCell(CellHandler("Resumen Anual Por Mes", CellHeader, 4, 4));
            table.AddCell(CellHandler("Mes",SubTitle));
            table.AddCell(CellHandler("Ingreso", SubTitle));
            table.AddCell(CellHandler("Egreso", SubTitle));
            table.AddCell(CellHandler("Balance", SubTitle));

            foreach (var month in balances)
            {
                var resultParagraph = new Paragraph($"${month.Result}");

                table.AddCell(CellHandler($"{month.Month}",NormalText));
                table.AddCell(CellHandler($"${month.TotalIncomes}",NormalText));
                table.AddCell(CellHandler($"${month.TotalSpendings}",NormalText));
                table.AddCell((month.Result >= 0) ? resultParagraph.AddStyle(NormalText) : resultParagraph.AddStyle(NegativeNormalText));
            }

            Document.Add(table);
        }

        private static void AnualIncomeCategoryTable(YearlyBalance anualBalance)
        {
            var incomeCategories = Enum.GetNames(typeof(EIncome));
            Array.Sort(incomeCategories, StringComparer.InvariantCulture);

            Table incomeCategoriesTable = new Table(2).UseAllAvailableWidth();
            incomeCategoriesTable.AddCell(CellHandler("Detalle Ingresos por categoria", CellHeader, 2, 2));

            foreach (var categoryName in incomeCategories)
            {
                var category = (EIncome)Enum.Parse(typeof(EIncome), categoryName);      
                incomeCategoriesTable.AddCell(CellHandler(categoryName, NormalText));
                incomeCategoriesTable.AddCell(CellHandler($"${C.FormatValue(C.CalculateTotalForAnualBySpecifiedCategory(anualBalance, category))}", NormalText));
            }

            Document.Add(incomeCategoriesTable);
        }

        private static void AnualSpendingCategoryTable(YearlyBalance anualBalance)
        {
            var spendingCategories = Enum.GetNames(typeof(ESpending));
            Array.Sort(spendingCategories, StringComparer.InvariantCulture);

            Table spendingCategoriesTable = new Table(2).UseAllAvailableWidth();
            spendingCategoriesTable.AddCell(CellHandler("Detalle Egresos por categoria", CellHeader, 2, 2));

            foreach (var categoryName in spendingCategories)
            {
                var category = (ESpending)Enum.Parse(typeof(ESpending), categoryName);
                spendingCategoriesTable.AddCell(CellHandler(categoryName, NormalText));
                spendingCategoriesTable.AddCell(CellHandler($"${C.FormatValue(C.CalculateTotalForAnualBySpecifiedCategory(anualBalance, category))}", NormalText));
            }

            Document.Add(spendingCategoriesTable);
        }

        private static void CreateAnualDetailsTable(YearlyBalance anualBalance)
        {
            Table table = new Table(2).UseAllAvailableWidth();
            table.AddCell(CellHandler("Detalle Anual", CellHeader, 2, 2));

            table.AddCell(CellHandler("Ingresos Totales", NormalText));
            table.AddCell(CellHandler($"${C.FormatValue(anualBalance.TotalSaved)}", NormalText));

            table.AddCell(CellHandler("Gastos Totales", NormalText));
            table.AddCell(CellHandler($"${C.FormatValue(anualBalance.TotalSpent)}",NormalText));

            table.AddCell(CellHandler("Promedio de Ingresos por mes", NormalText));
            table.AddCell(CellHandler($"${C.FormatValue(C.AverageIncomesPerMonth(anualBalance))}", NormalText));

            table.AddCell(CellHandler("Promedio de Gastos por mes", NormalText));
            table.AddCell(CellHandler($"${C.FormatValue(C.AverageSpendingsPerMonth(anualBalance))}", NormalText));

            table.AddCell(CellHandler("Balance Final", NormalText));
            table.AddCell(CellHandler($"${C.FormatValue(anualBalance.Result)}", NormalText));

            Document.Add(table);
        }
        #endregion
    }
}
