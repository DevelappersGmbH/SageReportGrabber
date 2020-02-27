using System;

namespace Develappers.SageReportGrabber
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class DocumentLocationAttribute : Attribute
    {
        public DocumentLocationAttribute()
        {
        }

        public DocumentLocationAttribute(int millimetersX, int millimetersY, int millimetersHeight, int millimetersWidth)
        {
            MillimetersX = millimetersX;
            MillimetersY = millimetersY;
            MillimetersHeight = millimetersHeight;
            MillimetersWidth = millimetersWidth;
        }

        public int MillimetersX { get; set; }
        public int MillimetersY { get; set; }
        public int MillimetersHeight { get; set; }
        public int MillimetersWidth { get; set; }
    }
}
