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
            SetDocumentInfo(yearBalance);

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

        #region Private Methods
        public static Cell CellHandler(string text, Style style, int cellRow = 1, int cellCol = 1)
        {
            return new Cell(cellRow, cellCol).Add(new Paragraph(text).AddStyle(style));
        }

        private static void SetDocumentInfo(YearlyBalance anualBalance)
        {
            //Content         
            Document.Add(new Paragraph($"Balance Anual {anualBalance.Year}").AddStyle(Header));
            Document.Add(new Paragraph(""));

            Document.Add(new Paragraph($"Total ${Calculator.FormatValue(anualBalance.Result)}").AddStyle(Header));

            CreateTablePerMonthBalance(anualBalance.Balances);

            Document.Add(new Paragraph(""));
            Document.Add(new Paragraph(""));

            CreateAnualDetailsTable(anualBalance);

            Document.Close();
        }
     
        private static void CreateTablePerMonthBalance(List<Balance> balances)
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

        private static void CreateAnualDetailsTable(YearlyBalance anualBalance)
        {
            Table table = new Table(2).UseAllAvailableWidth();
            table.AddCell(CellHandler("Detalle Anual", CellHeader, 2, 2));

            table.AddCell(CellHandler("Ingresos Totales", NormalText));
            table.AddCell(CellHandler($"${Calculator.FormatValue(anualBalance.TotalSaved)}", NormalText));

            table.AddCell(CellHandler("Gastos Totales", NormalText));
            table.AddCell(CellHandler($"${Calculator.FormatValue(anualBalance.TotalSpent)}",NormalText));

            table.AddCell(CellHandler("Promedio de Ingresos por mes", NormalText));
            table.AddCell(CellHandler($"${Calculator.FormatValue(Calculator.AverageIncomesPerMonth(anualBalance))}", NormalText));

            table.AddCell(CellHandler("Promedio de Gastos por mes", NormalText));
            table.AddCell(CellHandler($"${Calculator.FormatValue(Calculator.AverageSpendingsPerMonth(anualBalance))}", NormalText));

            table.AddCell(CellHandler("Balance Final", NormalText));
            table.AddCell(CellHandler($"${Calculator.FormatValue(anualBalance.Result)}", NormalText));

            Document.Add(table);
        }
        #endregion
    }
}
