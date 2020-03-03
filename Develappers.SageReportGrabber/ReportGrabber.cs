using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Develappers.SageReportGrabber.Reports;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace Develappers.SageReportGrabber
{
    public class ReportGrabber
    {
        //needed for the conversion from millimeters to dots
        const int dpi = 72; //dots per inch
        const double mmpi = 25.4d; //millimeters per inch

        /// <summary>
        /// Grabs the <see cref="Lohnkonto"/> data from a PDF document.
        /// </summary>
        /// <param name="stream">Contains the PDF document.</param>
        /// <returns>The list of <see cref="Lohnkonto"/></returns>
        public List<Lohnkonto> GrabLohnkonto(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream), $"{nameof(stream)} must not be null");
            }

            var pdfDoc = new PdfDocument(new PdfReader(stream));

            var mitarbeiterList = new List<Lohnkonto>();


            for (var pageIndex = 1; pageIndex <= pdfDoc.GetNumberOfPages(); pageIndex++)
            {
                var page = pdfDoc.GetPage(pageIndex);
                var pageWidth = page.GetPageSize().GetWidth() / dpi * mmpi;

                //Vergleich an bestimmter Position, ob text vorhanden ist, wenn nicht dann continue
                if (GetTextAtPosition(page, 13, 15, 5, 3) != "Status")
                {
                    continue;
                }

                var mitarbeiter = Extract<Lohnkonto>(page);

                var mitarbeiterPersonalnummer =
                    mitarbeiterList.SingleOrDefault(x => x.Personalnummer == mitarbeiter.Personalnummer);

                if (mitarbeiterPersonalnummer != null)
                {
                    mitarbeiter = mitarbeiterPersonalnummer;
                }
                else
                {
                    mitarbeiterList.Add(mitarbeiter);
                    mitarbeiter.Monate = new List<LohnkontoMonat>();
                }

                for (int offset = 0; offset < (int)pageWidth; offset += 26)
                {
                    var res = Extract<LohnkontoMonat>(page, offset);
                    if (string.IsNullOrEmpty(res.Abrechnungsmonat))
                    {
                        break;
                    }
                    if (res.Status == "Vortragswerte" || res.Status == "Summen")
                    {
                        continue;
                    }

                    mitarbeiter.Monate.Add(res);
                }

            }

            return mitarbeiterList;
        }

        /// <summary>
        /// Grabs the <see cref="MitarbeiterStammdatenblatt"/> data from a PDF document
        /// </summary>
        /// <param name="stream">Contains the PDF document.</param>
        /// <returns>A list of Stammdatenblätter.</returns>
        public List<MitarbeiterStammdatenblatt> GrabMitarbeiterStammdatenblatt(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream), $"{nameof(stream)} must not be null");
            }

            var pdfDoc = new PdfDocument(new PdfReader(stream));

            var grabbedPages = new List<MitarbeiterStammdatenblatt>();

            for (var page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                var pg = pdfDoc.GetPage(page);
                var grabbedPage = Extract<MitarbeiterStammdatenblatt>(pg);
                grabbedPages.Add(grabbedPage);
            }

            return grabbedPages;
        }

        /// <summary>
        /// Gets the Text at a Position in the PDF
        /// </summary>
        /// <param name="page"></param>
        /// <param name="x">x position in mm</param>
        /// <param name="y">y position in mm</param>
        /// <param name="w">width in mm</param>
        /// <param name="h">height in mm</param>
        /// <returns>The extracted text.</returns>
        private static string GetTextAtPosition(PdfPage page, int x, int y, int w, int h)
        {
            var xInDots = (int)(x / mmpi * dpi);
            var yInDots = (int)(y / mmpi * dpi);
            var wInDots = (int)(w / mmpi * dpi);
            var hInDots = (int)(h / mmpi * dpi);

            var rectangle = new Rectangle(xInDots, yInDots, wInDots, hInDots);

            IEventFilter[] filter = { new TextRegionEventFilter(rectangle) };
            ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), filter);
            var currentText = PdfTextExtractor.GetTextFromPage(page, strategy);

            //currentText cant be null because it gets back an String
            currentText = currentText.Trim();

            return currentText;
        }

        /// <summary>
        /// Extracts all data marked with <see cref="DocumentLocationAttribute"/> from the PDF page.
        /// </summary>
        /// <typeparam name="T">The result type.</typeparam>
        /// <param name="page">The PDF page.</param>
        /// <param name="xOffset">The offset which is added to the x value defined in <see cref="DocumentLocationAttribute"/></param>
        /// <returns>The type defined in T.</returns>
        private static T Extract<T>(PdfPage page, int xOffset = 0)
        {
            var culture = CultureInfo.GetCultureInfo("de-DE");

            if (page == null)
            {
                throw new ArgumentNullException(nameof(page), "Page must not be null");
            }

            var result = (T)Activator.CreateInstance(typeof(T));
            var properties = typeof(T).GetProperties();

            foreach (var propertyInfo in properties)
            {
                var propAttribute = propertyInfo
                    .GetCustomAttributes(typeof(DocumentLocationAttribute), false)
                    .Cast<DocumentLocationAttribute>()
                    .FirstOrDefault();

                if (propAttribute == null)
                {
                    continue;
                }

                var currentText = GetTextAtPosition(page, propAttribute.MillimetersX + xOffset,
                    propAttribute.MillimetersY, propAttribute.MillimetersWidth,
                    propAttribute.MillimetersHeight);

                if (propertyInfo.PropertyType == typeof(int))
                {
                    var tryParseInt = int.TryParse(currentText, out var currentTextIntPars);
                    if (tryParseInt)
                    {
                        propertyInfo.SetValue(result, currentTextIntPars);
                    }

                    continue;
                }
                if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    var tryParseDateTime = DateTime.TryParse(currentText, culture, DateTimeStyles.AssumeLocal, out var currentTextDateTimePars);
                    if (tryParseDateTime)
                    {
                        propertyInfo.SetValue(result, currentTextDateTimePars);
                    }

                    continue;
                }
                if (propertyInfo.PropertyType == typeof(decimal))
                {
                    var tryParseDec = decimal.TryParse(currentText, NumberStyles.Any, culture, out var currentTextDecPars);
                    if (tryParseDec)
                    {
                        propertyInfo.SetValue(result, currentTextDecPars);
                    }

                    continue;
                }
                if (propertyInfo.PropertyType == typeof(DateTime?))
                {
                    if (currentText == "")
                    {
                        propertyInfo.SetValue(result, null);
                    }
                    else
                    {
                        var tryParseDateTime = DateTime.TryParse(currentText, culture, DateTimeStyles.AssumeLocal, out var currentTextDateTimePars);
                        if (tryParseDateTime)
                        {
                            propertyInfo.SetValue(result, currentTextDateTimePars);
                        }
                    }

                    continue;
                }

                if (currentText == "")
                {
                    currentText = null;
                }

                propertyInfo.SetValue(result, currentText);
            }

            return result;
        }
    }
}
