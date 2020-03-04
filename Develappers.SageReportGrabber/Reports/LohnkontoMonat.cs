
namespace Develappers.SageReportGrabber.Reports
{
    public class LohnkontoMonat
    {
        [DocumentLocation(38, 178, 3, 18)]
        public string Abrechnungsmonat { get; set; }
        [DocumentLocation(39, 175, 3, 5)]
        public string Stklasse { get; set; }
        [DocumentLocation(45, 175, 3, 12)]
        public string Konf { get; set; }
        [DocumentLocation(59, 175, 3, 2)]
        public string Bl { get; set; }
        [DocumentLocation(47, 172, 3, 4)]
        public decimal MonFreib { get; set; }
        [DocumentLocation(60, 172, 3, 4)]
        public decimal JahrFreib { get; set; }
        [DocumentLocation(45, 169, 3, 5)]
        public decimal Kindfreib { get; set; }
        [DocumentLocation(59, 166, 4, 10)]
        public decimal LStTage { get; set; }
        [DocumentLocation(42, 163, 3, 8)]
        public decimal LStBrutto { get; set; }
        [DocumentLocation(57, 163, 3, 5)]
        public decimal SonstBezug { get; set; }
        [DocumentLocation(44, 160, 3, 5)]
        public decimal LStL { get; set; }
        [DocumentLocation(57, 160, 3, 5)]
        public decimal LStS { get; set; }
        [DocumentLocation(44, 157, 3, 5)]
        public decimal KiStL { get; set; }
        [DocumentLocation(57, 157, 3, 5)]
        public decimal KiStS { get; set; }
        [DocumentLocation(44, 154, 3, 5)]
        public decimal SolZuL { get; set; }
        [DocumentLocation(57, 154, 3, 5)]
        public decimal SolZuS { get; set; }
        [DocumentLocation(44, 151, 3, 5)]
        public decimal ABK { get; set; }
        [DocumentLocation(44, 148, 3, 5)]
        public decimal LStPauschalL { get; set; }
        [DocumentLocation(57, 148, 3, 5)]
        public decimal LStPauschalS { get; set; }
        [DocumentLocation(44, 147, 3, 5)]
        public decimal KiStPauschalL { get; set; }
        [DocumentLocation(57, 147, 3, 5)]
        public decimal KiStPauschalS { get; set; }
        [DocumentLocation(44, 142, 3, 5)]
        public decimal SolZuPauschalL { get; set; }
        [DocumentLocation(57, 142, 3, 5)]
        public decimal SolZuPauschalS { get; set; }
        [DocumentLocation(44, 139, 3, 5)]
        public decimal SFNZLStfrei { get; set; }
        [DocumentLocation(57, 139, 3, 5)]
        public decimal SFNZLStfreiPfl { get; set; }
        [DocumentLocation(44, 136, 3, 5)]
        public decimal StfreiLtPar3Nr63EStG { get; set; }
        [DocumentLocation(44, 133, 3, 5)]
        public decimal FahrtenStfrei { get; set; }
        [DocumentLocation(57, 133, 3, 5)]
        public decimal FahrtenPauschal { get; set; }
        [DocumentLocation(38, 130, 3, 5)]
        public string Sozialversicherungsschluessel { get; set; }
        [DocumentLocation(46, 130, 3, 2)]
        public string Personengruppenschluessel { get; set; }
        [DocumentLocation(51, 130, 3, 2)]
        public string Taetigkeitsschluessel { get; set; }
        [DocumentLocation(38, 127, 3, 20)]
        public string Krankenkasse { get; set; }
        [DocumentLocation(38, 124, 3, 5)]
        public string RK { get; set; }
        [DocumentLocation(38, 121, 3, 4)]
        public decimal SVTgKV { get; set; }
        [DocumentLocation(46, 121, 3, 4)]
        public decimal SVTgRV { get; set; }
        [DocumentLocation(52, 121, 3, 4)]
        public decimal SVTgAV { get; set; }
        [DocumentLocation(58, 121, 3, 4)]
        public decimal SVTgPV { get; set; }
        [DocumentLocation(40, 118, 3, 5)]
        public decimal EGATgKV { get; set; }
        [DocumentLocation(46, 118, 3, 5)]
        public decimal EGATgRV { get; set; }
        [DocumentLocation(52, 118, 3, 5)]
        public decimal EGATgAV { get; set; }
        [DocumentLocation(58, 118, 3, 5)]
        public decimal EGATgPV { get; set; }
        [DocumentLocation(42, 115, 3, 4)]
        public decimal SVBrutto { get; set; }
        [DocumentLocation(57, 115, 3, 3)]
        public decimal EGA { get; set; }
        [DocumentLocation(44, 112, 3, 4)]
        public decimal Par23cSoziallstgAgLstgL { get; set; }
        [DocumentLocation(57, 112, 3, 4)]
        public decimal Par23cSoziallstgAgLstgE { get; set; }
        [DocumentLocation(44, 109, 3, 4)]
        public decimal GesamtentgeltL { get; set; }
        [DocumentLocation(44, 109, 3, 4)]
        public decimal GesamtentgeltE { get; set; }
        [DocumentLocation(44, 106, 3, 4)]
        public decimal Par23cZBE { get; set; }
        [DocumentLocation(57, 106, 3, 4)]
        public decimal SVFreibetr { get; set; }
        [DocumentLocation(44, 103, 3, 4)]
        public decimal SFNZSVfrei { get; set; }
        [DocumentLocation(57, 103, 3, 4)]
        public decimal SFNZSVfreiPfl { get; set; }
        [DocumentLocation(42, 100, 3, 7)]
        public decimal KVBruttiL { get; set; }
        [DocumentLocation(57, 100, 3, 7)]
        public decimal KVBruttiE { get; set; }
        [DocumentLocation(42, 97, 3, 7)]
        public decimal RVBruttiL { get; set; }
        [DocumentLocation(57, 97, 3, 7)]
        public decimal RVBruttiE { get; set; }
        [DocumentLocation(42, 94, 3, 7)]
        public decimal AVBruttiL { get; set; }
        [DocumentLocation(57, 94, 3, 7)]
        public decimal AVBruttiE { get; set; }
        [DocumentLocation(42, 91, 3, 7)]
        public decimal PVBruttiL { get; set; }
        [DocumentLocation(57, 91, 3, 7)]
        public decimal PVBruttiE { get; set; }
        [DocumentLocation(43, 88, 3, 7)]
        public decimal KVANAL { get; set; }
        [DocumentLocation(57, 88, 3, 7)]
        public decimal KVANAE { get; set; }
        [DocumentLocation(43, 85, 3, 7)]
        public decimal KVAGAL { get; set; }
        [DocumentLocation(57, 85, 3, 7)]
        public decimal KVAGAE { get; set; }
        [DocumentLocation(44, 82, 3, 5)]
        public decimal KVZuschFreiw { get; set; }
        [DocumentLocation(58, 82, 3, 5)]
        public decimal KVZuschPrivat { get; set; }
        [DocumentLocation(44, 79, 3, 5)]
        public decimal KVFreiwGesamt { get; set; }
        [DocumentLocation(44, 76, 3, 5)]
        public decimal PauschAGBtrZurKVL { get; set; }
        [DocumentLocation(57, 76, 3, 5)]
        public decimal PauschAGBtrZurKVE { get; set; }
        [DocumentLocation(44, 73, 3, 5)]
        public decimal RVANAL { get; set; }
        [DocumentLocation(57, 73, 3, 5)]
        public decimal RVANAE { get; set; }
        [DocumentLocation(44, 70, 3, 5)]
        public decimal RVAGAL { get; set; }
        [DocumentLocation(57, 70, 3, 5)]
        public decimal RVAGAE { get; set; }
        [DocumentLocation(44, 67, 3, 5)]
        public decimal RVFreiw { get; set; }
        [DocumentLocation(44, 64, 3, 5)]
        public decimal PauschAgBtrZurRVL { get; set; }
        [DocumentLocation(57, 64, 3, 5)]
        public decimal PauschAgBtrZurRVE { get; set; }
        [DocumentLocation(44, 61, 3, 5)]
        public decimal AVANAL { get; set; }
        [DocumentLocation(57, 61, 3, 5)]
        public decimal AVANAE { get; set; }
        [DocumentLocation(44, 58, 3, 5)]
        public decimal AVAGAL { get; set; }
        [DocumentLocation(57, 58, 3, 5)]
        public decimal AVAGAE { get; set; }
        [DocumentLocation(44, 55, 3, 5)]
        public decimal PVANAL { get; set; }
        [DocumentLocation(57, 55, 3, 5)]
        public decimal PVANAE { get; set; }
        [DocumentLocation(44, 52, 3, 5)]
        public decimal PVAGAL { get; set; }
        [DocumentLocation(57, 52, 3, 5)]
        public decimal PVAGAE { get; set; }
        [DocumentLocation(44, 49, 3, 5)]
        public decimal PVFreiw { get; set; }
        [DocumentLocation(57, 49, 3, 5)]
        public decimal PVPriv { get; set; }
        [DocumentLocation(44, 46, 3, 5)]
        public decimal PVfreiwGesamt { get; set; }
        [DocumentLocation(44, 43, 3, 5)]
        public decimal EinheitlPSt { get; set; }
        [DocumentLocation(57, 43, 3, 5)]
        public string Gleitzone { get; set; }
        [DocumentLocation(44, 40, 3, 6)]
        public decimal USchl { get; set; }
        [DocumentLocation(57, 40, 3, 5)]
        public decimal UBrutto { get; set; }
        [DocumentLocation(44, 37, 3, 5)]
        public decimal U1 { get; set; }
        [DocumentLocation(57, 37, 3, 5)]
        public decimal U2 { get; set; }
        [DocumentLocation(44, 34, 3, 5)]
        public decimal IGUlfd { get; set; }
        [DocumentLocation(57, 34, 3, 5)]
        public decimal IGUEGA { get; set; }
        [DocumentLocation(44, 31, 3, 5)]
        public decimal BGStd { get; set; }
        [DocumentLocation(55, 31, 3, 5)]
        public decimal BGBrutto { get; set; }
        [DocumentLocation(44, 28, 3, 5)]
        public decimal GesAbz { get; set; }
        [DocumentLocation(57, 28, 3, 5)]
        public decimal PersAbz { get; set; }
        [DocumentLocation(42, 25, 3, 5)]
        public decimal Bruttoverd { get; set; }
        [DocumentLocation(56, 25, 3, 5)]
        public decimal Auszahlung { get; set; }
        [DocumentLocation(44, 22, 3, 5)]
        public decimal Netto { get; set; }
        [DocumentLocation(57, 22, 3, 5)]
        public decimal Korrekturverr { get; set; }
        [DocumentLocation(53, 19, 3, 5)]
        public decimal ASp { get; set; }
        [DocumentLocation(59, 19, 3, 4)]
        public decimal USp { get; set; }
        [DocumentLocation(37, 16, 3, 16)]
        public string Status { get; set; }
    }
}
