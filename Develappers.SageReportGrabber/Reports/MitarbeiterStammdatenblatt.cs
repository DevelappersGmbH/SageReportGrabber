using System;

namespace Develappers.SageReportGrabber.Reports
{
    public class MitarbeiterStammdatenblatt
    {
        [DocumentLocation(100, 188, 8, 80)]
        public string Name { get; set; }

        [DocumentLocation(35, 173, 3, 5)]
        public int Personalnummer { get; set; }

        [DocumentLocation(32, 167, 4, 20)]
        public string Anrede { get; set; }

        [DocumentLocation(42, 159, 4, 20)]
        public string Straße { get; set; }

        [DocumentLocation(42, 151, 4, 20)]
        public string PostleitzahlOrt { get; set; }

        [DocumentLocation(42, 147, 4, 20)]
        public string Land { get; set; }

        [DocumentLocation(98, 171, 4, 20)]
        public string Telefon { get; set; }

        [DocumentLocation(103, 167, 4, 20)]
        public string Funktelefon { get; set; }

        [DocumentLocation(98, 164, 4, 20)]
        public string Telefax { get; set; }

        [DocumentLocation(105, 160, 5, 20)]
        public DateTime Geburtstagsdatum { get; set; }

        [DocumentLocation(102, 155, 5, 20)]
        public string Geburtsort { get; set; }

        [DocumentLocation(105, 151, 5, 20)]
        public string Geburtsname { get; set; }

        [DocumentLocation(102, 147, 5, 20)]
        public string Nationalität { get; set; }

        [DocumentLocation(103, 143, 5, 20)]
        public string Geschlecht { get; set; }

        [DocumentLocation(55, 127, 5, 20)]
        public string ArtDerLohnGehaltszahlung { get; set; }

        [DocumentLocation(41, 123, 5, 20)]
        public string VerrechnungUeber { get; set; }

        [DocumentLocation(32, 119, 5, 20)]
        public string Empfaenger { get; set; }

        [DocumentLocation(25, 115, 5, 20)]
        public string Bank { get; set; }

        [DocumentLocation(25, 110, 5, 20)]
        public string Iban { get; set; }

        [DocumentLocation(22, 93, 4, 6)]
        public decimal ArbeitszeitSo { get; set; }

        [DocumentLocation(33, 93, 4, 6)]
        public decimal ArbeitszeitMo { get; set; }

        [DocumentLocation(53, 93, 4, 6)]
        public decimal ArbeitszeitDi { get; set; }

        [DocumentLocation(68, 93, 4, 6)]
        public decimal ArbeitszeitMi { get; set; }

        [DocumentLocation(85, 93, 4, 6)]
        public decimal ArbeitszeitDo { get; set; }

        [DocumentLocation(101, 93, 4, 6)]
        public decimal ArbeitszeitFr { get; set; }

        [DocumentLocation(116, 93, 4, 6)]
        public decimal ArbeitszeitSa { get; set; }

        [DocumentLocation(30, 90, 3, 20)]
        public decimal ArbeitszeitWo { get; set; }

        [DocumentLocation(30, 83, 3, 20)]
        public decimal Gehalt { get; set; }

        [DocumentLocation(95, 83, 5, 20)]
        public decimal Stundenlohn { get; set; }

        [DocumentLocation(35, 70, 4, 5)]
        public string Steuerklasse { get; set; }

        [DocumentLocation(43, 64, 4, 10)]
        public string Kirchensteuerabzug { get; set; }

        [DocumentLocation(36, 60, 4, 10)]
        public string Arbeitnehmer { get; set; }

        [DocumentLocation(30, 56, 4, 10)]
        public string Ehegatte { get; set; }

        [DocumentLocation(35, 48, 4, 7)]
        public decimal FreibetragMonat { get; set; }

        [DocumentLocation(66, 48, 4, 7)]
        public decimal FreibetragJahr { get; set; }

        [DocumentLocation(130, 68, 4, 9)]
        public decimal Kinderfreibetraege { get; set; }

        [DocumentLocation(105, 51, 4, 35)]
        public string Etin { get; set; }

        [DocumentLocation(110, 48, 4, 30)]
        public string Idnr { get; set; }

        [DocumentLocation(27, 36, 4, 10)]
        public DateTime Eintritt { get; set; }

        [DocumentLocation(35, 32, 4, 10)]
        public string Bundesland { get; set; }

        [DocumentLocation(100, 36, 4, 30)]
        public DateTime Austritt { get; set; }

        [DocumentLocation(45, 19, 4, 25)]
        public string BerufsgenossenschaftUnternehmenszweig { get; set; }

        [DocumentLocation(109, 20, 4, 20)]
        public string BerufsgenossenschaftTarif { get; set; }

        [DocumentLocation(112, 16, 4, 20)]
        public string BerufsgenossenschaftKlasse { get; set; }

        [DocumentLocation(176, 171, 5, 10)]
        public string SvSchlüssel { get; set; }

        [DocumentLocation(162, 167, 5, 25)]
        public string Krankenkasse { get; set; }

        [DocumentLocation(173, 144, 5, 10)]
        public string Versicherungsnummer { get; set; }

        [DocumentLocation(170, 139, 5, 25)]
        public string AusgeuebteTaetigkeit { get; set; }

        [DocumentLocation(170, 130, 5, 25)]
        public string Statuskennzeichen { get; set; }

        [DocumentLocation(170, 125, 5, 25)]
        public string Beschaeftigungsart { get; set; }
    }
}
