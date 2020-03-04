using System;
using System.Collections.Generic;

namespace Develappers.SageReportGrabber.Reports
{
    public class Lohnkonto
    {
        [DocumentLocation(28, 184, 3, 23)]
        public string Name { get; set; }
        [DocumentLocation(10, 183, 4, 5)]
        public int Personalnummer { get; set; }
        [DocumentLocation(62, 180, 3, 14)]
        public DateTime? Geburtstagsdatum { get; set; }
        [DocumentLocation(80, 184, 3, 23)]
        public string StraßeHausnummer { get; set; }
        [DocumentLocation(80, 180, 3, 20)]
        public string PostleitzahlOrt { get; set; }
        [DocumentLocation(124, 185, 3, 15)]
        public DateTime? Eintrittsdatum { get; set; }
        [DocumentLocation(124, 182, 3, 15)]
        public DateTime? Austrittsdatum { get; set; }
        [DocumentLocation(140, 185, 3, 20)]
        public string Rentenversicherungsnummer { get; set; }
        [DocumentLocation(195, 185, 3, 27)]
        public string BeschaeftigtAls { get; set; }
        [DocumentLocation(195, 182, 3, 8)]
        public string Rentenbezug { get; set; }
        public List<LohnkontoMonat> Monate { get; set; }
    }
}
