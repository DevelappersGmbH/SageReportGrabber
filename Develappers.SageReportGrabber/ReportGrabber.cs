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

        private static T Extract<T>(PdfPage page)
        {
            var culture = CultureInfo.GetCultureInfo("de-DE");

            if (page == null)
            {
                throw new ArgumentNullException(nameof(page), "Page must not be null");
            }

            const int dpi = 72;
            const double mmpi = 25.4d;

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

                var x = (int)(propAttribute.MillimetersX / mmpi * dpi);
                var y = (int)(propAttribute.MillimetersY / mmpi * dpi);
                var w = (int)(propAttribute.MillimetersWidth / mmpi * dpi);
                var h = (int)(propAttribute.MillimetersHeight / mmpi * dpi);

                var rectangle = new Rectangle(x, y, w, h);

                IEventFilter[] filter = { new TextRegionEventFilter(rectangle) };
                ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), filter);
                var currentText = PdfTextExtractor.GetTextFromPage(page, strategy);

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
