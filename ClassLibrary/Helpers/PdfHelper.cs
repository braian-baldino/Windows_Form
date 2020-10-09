using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Diagnostics;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Drawing;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using System.Dynamic;
using System.Collections.Generic;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using iText.Kernel.Pdf.Colorspace;

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

        #endregion

        static PdfHelper()
        {
            MemStream = new MemoryStream();
            Writer = new PdfWriter(MemStream);
            Document = new Document(new PdfDocument(Writer),PageSize.A4);    
        }

        private static void SetDocumentInfo(YearlyBalance yearBalance)
        {
            //Content
            var formattedResult = String.Format("{0:0.00}", yearBalance.Result);
            Document.Add(new Paragraph($"Balance Anual {yearBalance.Year}  ${formattedResult}").AddStyle(Header));

            CreateTablePerMonthBalance(yearBalance.Balances);

            Document.Close();
        }


        private static void CreateTablePerMonthBalance(List<Balance> balances)
        {
            Table table = new Table(4).UseAllAvailableWidth();
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

        public static void CreatePdf(string fileName, YearlyBalance yearBalance)
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
