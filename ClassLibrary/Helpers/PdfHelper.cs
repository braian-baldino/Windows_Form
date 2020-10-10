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
        private static PdfWriter Writer { get; set; }
        private static Document Document { get; set; }
        private static MemoryStream MemStream { get; set; }

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

        static PdfHelper()
        {
            MemStream = new MemoryStream();
            Writer = new PdfWriter(MemStream);
            Document = new Document(new PdfDocument(Writer),PageSize.A4);    
        }

        private static Cell CellHandler(string text, Style style, int cellRow = 1, int cellCol = 1)
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

        private static void CreateAnualDetailsTable(YearlyBalance anualBalance)
        {
            Table table = new Table(2).UseAllAvailableWidth();
            //table.AddCell(new Cell(2,2).Add(new Paragraph("Detalle Anual").AddStyle(CellHeader)));
            table.AddCell(CellHandler("Detalle Anual",CellHeader,2,2));
            table.AddCell(CellHandler("Ingresos Totales",NormalText));
            table.AddCell(new Cell().Add(new Paragraph($"${Calculator.FormatValue(anualBalance.TotalSaved)}").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph("Gastos Totales").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph($"${Calculator.FormatValue(anualBalance.TotalSpent)}").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph("Promedio de Ingreso por mes").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph($"${Calculator.FormatValue(Calculator.AverageIncomesPerMonth(anualBalance))}").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph("Promeio de Gastos por mes").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph($"${Calculator.FormatValue(Calculator.AverageSpendingsPerMonth(anualBalance))}").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph("Balance Final").AddStyle(NormalText)));
            table.AddCell(new Cell().Add(new Paragraph($"${Calculator.FormatValue(anualBalance.Result)}").AddStyle(NormalText)));

            Document.Add(table);
        }
     
        private static void CreateTablePerMonthBalance(List<Balance> balances)
        {                     
            Table table = new Table(4).UseAllAvailableWidth();
            table.AddCell(new Cell(4,4).Add(new Paragraph("Resumen Anual por mes").AddStyle(CellHeader)));
            table.AddCell(new Cell().Add(new Paragraph("Mes").AddStyle(SubTitle)));
            table.AddCell(new Cell().Add(new Paragraph("Ingreso").AddStyle(SubTitle)));
            table.AddCell(new Cell().Add(new Paragraph("Egreso").AddStyle(SubTitle)));
            table.AddCell(new Cell().Add(new Paragraph("Balance").AddStyle(SubTitle)));

            foreach (var month in balances)
            {
                var resultParagraph = new Paragraph($"${month.Result}");

                table.AddCell(new Paragraph($"{month.Month}").SetBold().AddStyle(NormalText));
                table.AddCell(new Paragraph($"${month.TotalIncomes}").AddStyle(NormalText));
                table.AddCell(new Paragraph($"${month.TotalSpendings}").AddStyle(NormalText));
                table.AddCell((month.Result >= 0) ? resultParagraph.AddStyle(NormalText) : resultParagraph.AddStyle(NegativeNormalText));
            }

            Document.Add(table);
        }

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
        
    }
}
