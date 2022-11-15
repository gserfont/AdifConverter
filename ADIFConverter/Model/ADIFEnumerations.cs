using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace ADIFConverter.Model
{
    public static class ADIFEnumerations
    {
        public static List<antPath> getAntPath()
        {
            List<antPath> antPathEnumeration = new List<antPath>();
            antPathEnumeration.Add(new antPath("G", "grayline"));
            antPathEnumeration.Add(new antPath("O", "other"));
            antPathEnumeration.Add(new antPath("S", "short path"));
            antPathEnumeration.Add(new antPath("L", "long path"));
            return antPathEnumeration;
        }

        private static List<band> getbands()
        {
            List<band> bandEnumeration = new List<band>();
            bandEnumeration.Add(new band("2190m",0.136,0.137));
            bandEnumeration.Add(new band("560m",0.501,0.504));
            bandEnumeration.Add(new band("160m",1.8,2.0));
            bandEnumeration.Add(new band("80m",3.5,4));
            bandEnumeration.Add(new band("60m",5.102,5.404));
            bandEnumeration.Add(new band("40m",7.0,7.3));
            bandEnumeration.Add(new band("30m",10,10.15));
            bandEnumeration.Add(new band("20m",14,14.35));
            bandEnumeration.Add(new band("17m",18.068,18.168));
            bandEnumeration.Add(new band("15m",21,21.45));
            bandEnumeration.Add(new band("12m",24.890,24.99));
            bandEnumeration.Add(new band("10m",28,29.7));
            bandEnumeration.Add(new band("6m",50,54));
            bandEnumeration.Add(new band("4m",70,71));
            bandEnumeration.Add(new band("2m",144,148));
            bandEnumeration.Add(new band("1.25m",222,225));
            bandEnumeration.Add(new band("70cm",420,450));
            bandEnumeration.Add(new band("33cm", 902,928));
            bandEnumeration.Add(new band("23cm", 1240,1300));
            bandEnumeration.Add(new band("13cm", 2300,2450));
            bandEnumeration.Add(new band("9cm", 3300,3500));
            bandEnumeration.Add(new band("6cm", 5650,5925));
            bandEnumeration.Add(new band("3cm", 10000,10500));
            bandEnumeration.Add(new band("1.25cm", 24000,24250));
            bandEnumeration.Add(new band("6mm", 47000,47200));
            bandEnumeration.Add(new band("4mm", 75500,81000));
            bandEnumeration.Add(new band("2.5mm", 119980,120020));
            bandEnumeration.Add(new band("2mm", 142000,149000));
            bandEnumeration.Add(new band("1mm", 241000,250000));

            return bandEnumeration;

        }

        public static List<continent> getContinents()
        {
            List<continent> continentEnumeration = new List<continent>();
            continentEnumeration.Add(new continent("NA", "North America"));
            continentEnumeration.Add(new continent("SA", "South America"));
            continentEnumeration.Add(new continent("EU", "Europe"));
            continentEnumeration.Add(new continent("AF", "Africa"));
            continentEnumeration.Add(new continent("OC", "Oceana"));
            continentEnumeration.Add(new continent("AS", "Asia"));
            continentEnumeration.Add(new continent("AN", "Antarctica"));
            return continentEnumeration;
        }

        public static List<credit> getCredits()
        {
            List<credit> Credits = new List<credit>();
            Credits.Add(new credit("CQDX", "CQ Magazine", "DX", "Mixed"));
            Credits.Add(new credit("CQDX_BAND", "CQ Magazine", "DX", "Band"));
            Credits.Add(new credit("CQDX_MODE", "CQ Magazine", "DX", "Mode"));
            Credits.Add(new credit("CQDX_MOBILE", "CQ Magazine", "DX", "Mobile"));
            Credits.Add(new credit("CQDX_QRP", "CQ Magazine", "DX", "QRP"));
            Credits.Add(new credit("CQDX_SATELLITE", "CQ Magazine", "DX", "Satellite"));
            Credits.Add(new credit("CQDXFIELD", "CQ Magazine", "DX", "Mixed"));
            Credits.Add(new credit("CQDXFIELD_BAND", "CQ Magazine", "DX", "Band"));
            Credits.Add(new credit("CQDXFIELD_MODE", "CQ Magazine", "DX", "Mode"));
            Credits.Add(new credit("CQDXFIELD_MOBILE", "CQ Magazine", "DX", "Mobile"));
            Credits.Add(new credit("CQDXFIELD_QRP", "CQ Magazine", "DX", "QRP"));
            Credits.Add(new credit("CQDXFIELD_SATELLITE", "CQ Magazine", "DX", "Satellite"));
            Credits.Add(new credit("CQWAZ_MIXED", "CQ Magazine", "DX", "Mixed"));
            Credits.Add(new credit("CQWAZ_BAND", "CQ Magazine", "DX", "Band"));
            Credits.Add(new credit("CQWAZ_MODE", "CQ Magazine", "DX", "Mode"));
            Credits.Add(new credit("CQWAZ_SATELLITE", "CQ Magazine", "DX", "Satellite"));
            Credits.Add(new credit("CQWAZ_EME", "CQ Magazine", "DX", "EME"));
            Credits.Add(new credit("CQWAZ_MOBILE", "CQ Magazine", "DX", "Mobile"));
            Credits.Add(new credit("CQWAZ_QRP", "CQ Magazine", "DX", "QRP"));
            Credits.Add(new credit("CQWPX", "CQ Magazine", "DX", "Mixed"));
            Credits.Add(new credit("CQWPX_BAND", "CQ Magazine", "DX", "Band"));
            Credits.Add(new credit("CQWPX_MODE", "CQ Magazine", "DX", "Mode"));
            Credits.Add(new credit("DXCC", "ARRL", "DX Century Club (DXCC)", "Mixed"));
            Credits.Add(new credit("DXCC_BAND", "ARRL", "DX Century Club (DXCC)", "Band"));
            Credits.Add(new credit("DXCC_MODE", "ARRL", "DX Century Club (DXCC)", "Mode"));
            Credits.Add(new credit("DXCC_SATELLITE", "ARRL", "DX Century Club (DXCC)", "Satellite"));
            Credits.Add(new credit("EAUSTRALIA", "eQSL", "eAustralia", "Mixed"));
            Credits.Add(new credit("ECANADA", "eQSL", "eCanada", "Mixed"));
            Credits.Add(new credit("ECOUNTY_STATE", "eQSL", "eCounty", "State"));
            Credits.Add(new credit("EDX", "eQSL", "eDX", "Mixed"));
            Credits.Add(new credit("EDX100", "eQSL", "eDX100", "Mixed"));
            Credits.Add(new credit("EDX100_BAND", "eQSL", "eDX100", "Band"));
            Credits.Add(new credit("EDX100_MODE", "eQSL", "eDX100", "Mode"));
            Credits.Add(new credit("EECHOLINK50", "eQSL", "eEcholink50", "Echolink"));
            Credits.Add(new credit("EGRID_BAND", "eQSL", "eGrid", "Band"));
            Credits.Add(new credit("EGRID_SATELLITE", "eQSL", "eGrid", "Satellite"));
            Credits.Add(new credit("EPFX300", "eQSL", "ePfx300", "Mixed"));
            Credits.Add(new credit("EPFX300_MODE", "eQSL", "ePfx300", "Mode"));
            Credits.Add(new credit("EWAS", "eQSL", "eWAS", "Mixed"));
            Credits.Add(new credit("EWAS_BAND", "eQSL", "eWAS", "Band"));
            Credits.Add(new credit("EWAS_MODE", "eQSL", "eWAS", "Mode"));
            Credits.Add(new credit("EWAS_SATELLITE", "eQSL", "eWAS", "Satellite"));
            Credits.Add(new credit("EZ40", "eQSL", "eZ40", "Mixed"));
            Credits.Add(new credit("EZ40_MODE", "eQSL", "eZ40", "Mode"));
            Credits.Add(new credit("FFMA", "ARRL", "Fred Fish Memorial Award (FFMA)", "Mixed"));
            Credits.Add(new credit("IOTA", "RSGB", "Islands on the Air (IOTA)", "Mixed"));
            Credits.Add(new credit("IOTA_BASIC", "RSGB", "Islands on the Air (IOTA)", "Mixed"));
            Credits.Add(new credit("IOTA_CONT", "RSGB", "Islands on the Air (IOTA)", "Continent"));
            Credits.Add(new credit("IOTA_GROUP", "RSGB", "Islands on the Air (IOTA)", "Group"));
            Credits.Add(new credit("RDA", "TAG", "Russian Districts Award (RDA)", "Mixed"));
            Credits.Add(new credit("USACA", "CQ Magazine", "United States of America Counties (USA-CA)", "Mixed"));
            Credits.Add(new credit("VUCC_BAND", "ARRL", "VHF/UHF Century Club Program (VUCC)", "Band"));
            Credits.Add(new credit("VUCC_SATELLITE", "ARRL", "VHF/UHF Century Club Program (VUCC)", "Satellite"));
            Credits.Add(new credit("WAB", "WAB AG", "Worked All Britain (WAB)", "Mixed"));
            Credits.Add(new credit("WAC", "IARU", "Worked All Continents (WAC)", "Mixed"));
            Credits.Add(new credit("WAC_BAND", "IARU", "Worked All Continents (WAC)", "band"));
            Credits.Add(new credit("WAE", "DARC", "Worked All Europe (WAE)", "Mixed"));
            Credits.Add(new credit("WAE_BAND", "DARC", "Worked All Europe (WAE)", "Band"));
            Credits.Add(new credit("WAE_MODE", "DARC", "Worked All Europe (WAE)", "Mode"));
            Credits.Add(new credit("WAIP", "ARI", "Worked All Italian Provinces (WAIP)", "Mixed"));
            Credits.Add(new credit("WAIP_BAND", "ARI", "Worked All Italian Provinces (WAIP)", "Band"));
            Credits.Add(new credit("WAIP_Mode", "ARI", "Worked All Italian Provinces (WAIP)", "Mode"));
            Credits.Add(new credit("WAS", "ARRL", "Worked All States (WAS)", "Mixed"));
            Credits.Add(new credit("WAS_BAND", "ARRL", "Worked All States (WAS)", "Band"));
            Credits.Add(new credit("WAS_MODE", "ARRL", "Worked All States (WAS)", "Mode"));
            Credits.Add(new credit("WAS_NOVICE", "ARRL", "Worked All States (WAS)", "Novice"));
            Credits.Add(new credit("WAS_QRP", "ARRL", "Worked All States (WAS)", "QRP"));
            Credits.Add(new credit("WAS_SATELLITE", "ARRL", "Worked All States (WAS)", "Satellite"));
            Credits.Add(new credit("WITUZ", "RSGB", "Worked ITU Zones (WITUZ)", "Mixed"));
            Credits.Add(new credit("WITUZ_BAND", "RSGB", "Worked ITU Zones (WITUZ)", "Band"));

            return Credits;
        }

        public static List<dxccEntity> getDXCCEntity()
        {
            List<dxccEntity> dxccEntityEnumeration = new List<dxccEntity>();
            dxccEntityEnumeration.Add(new dxccEntity(0, "None", false));
            dxccEntityEnumeration.Add(new dxccEntity(1, "CANADA", false));
            dxccEntityEnumeration.Add(new dxccEntity(2, "ABU AIL IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(3, "AFGHANISTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(4, "AGALEGA & ST. BRANDON IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(5, "ALAND IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(6, "ALASKA", false));
            dxccEntityEnumeration.Add(new dxccEntity(7, "ALBANIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(8, "ALDABRA", true));
            dxccEntityEnumeration.Add(new dxccEntity(9, "AMERICAN SAMOA", false));
            dxccEntityEnumeration.Add(new dxccEntity(10, "AMSTERDAM & ST. PAUL IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(11, "ANDAMAN & NICOBAR IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(12, "ANGUILLA", false));
            dxccEntityEnumeration.Add(new dxccEntity(13, "ANTARCTICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(14, "ARMENIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(15, "ASIATIC RUSSIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(16, "NEW ZEALAND SUBANTARCTIC ISLANDS", false));
            dxccEntityEnumeration.Add(new dxccEntity(17, "AVES I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(18, "AZERBAIJAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(19, "BAJO NUEVO", true));
            dxccEntityEnumeration.Add(new dxccEntity(20, "BAKER & HOWLAND IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(21, "BALEARIC IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(22, "PALAU", false));
            dxccEntityEnumeration.Add(new dxccEntity(23, "BLENHEIM REEF", true));
            dxccEntityEnumeration.Add(new dxccEntity(24, "BOUVET", false));
            dxccEntityEnumeration.Add(new dxccEntity(25, "BRITISH NORTH BORNEO", true));
            dxccEntityEnumeration.Add(new dxccEntity(26, "BRITISH SOMALILAND", true));
            dxccEntityEnumeration.Add(new dxccEntity(27, "BELARUS", false));
            dxccEntityEnumeration.Add(new dxccEntity(28, "CANAL ZONE", true));
            dxccEntityEnumeration.Add(new dxccEntity(29, "CANARY IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(30, "CELEBE & MOLUCCA IS.", true));
            dxccEntityEnumeration.Add(new dxccEntity(31, "C. KIRIBATI (BRITISH PHOENIX IS.)", false));
            dxccEntityEnumeration.Add(new dxccEntity(32, "CEUTA & MELILLA", false));
            dxccEntityEnumeration.Add(new dxccEntity(33, "CHAGOS IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(34, "CHATHAM IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(35, "CHRISTMAS I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(36, "CLIPPERTON I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(37, "COCOS I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(38, "COCOS (KEELING) IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(39, "COMOROS", false));
            dxccEntityEnumeration.Add(new dxccEntity(40, "CRETE", false));
            dxccEntityEnumeration.Add(new dxccEntity(41, "CROZET I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(42, "DAMAO, DIU", true));
            dxccEntityEnumeration.Add(new dxccEntity(43, "DESECHEO I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(44, "DESROCHES", false));
            dxccEntityEnumeration.Add(new dxccEntity(45, "DODECANESE", false));
            dxccEntityEnumeration.Add(new dxccEntity(46, "EAST MALAYSIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(47, "EASTER I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(48, "E. KIRIBATI (LINE IS.)", false));
            dxccEntityEnumeration.Add(new dxccEntity(49, "EQUATORIAL GUINEA", false));
            dxccEntityEnumeration.Add(new dxccEntity(50, "MEXICO", false));
            dxccEntityEnumeration.Add(new dxccEntity(51, "ERITREA", false));
            dxccEntityEnumeration.Add(new dxccEntity(52, "ESTONIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(53, "ETHIOPIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(54, "EUROPEAN RUSSIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(55, "FARQUHAR", true));
            dxccEntityEnumeration.Add(new dxccEntity(56, "FERNANDO DE NORONHA", false));
            dxccEntityEnumeration.Add(new dxccEntity(57, "FRENCH EQUATORIAL AFRICA", true));
            dxccEntityEnumeration.Add(new dxccEntity(58, "FRENCH INDO-CHINA", true));
            dxccEntityEnumeration.Add(new dxccEntity(59, "FRENCH WEST AFRICA", true));
            dxccEntityEnumeration.Add(new dxccEntity(60, "BAHAMAS", false));
            dxccEntityEnumeration.Add(new dxccEntity(61, "FRANZ JOSEF LAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(62, "BARBADOS", false));
            dxccEntityEnumeration.Add(new dxccEntity(63, "FRENCH GUIANA", false));
            dxccEntityEnumeration.Add(new dxccEntity(64, "BERMUDA", false));
            dxccEntityEnumeration.Add(new dxccEntity(65, "BRITISH VIRGIN IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(66, "BELIZE", false));
            dxccEntityEnumeration.Add(new dxccEntity(67, "FRENCH INDIA", true));
            dxccEntityEnumeration.Add(new dxccEntity(68, "KUWAIT/SAUDI ARABIA NEUTRAL ZONE", true));
            dxccEntityEnumeration.Add(new dxccEntity(69, "CAYMAN IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(70, "CUBA", false));
            dxccEntityEnumeration.Add(new dxccEntity(71, "GALAPAGOS IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(72, "DOMINICAN REPUBLIC", false));
            dxccEntityEnumeration.Add(new dxccEntity(73, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(74, "EL SALVADOR", false));
            dxccEntityEnumeration.Add(new dxccEntity(75, "GEORGIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(76, "GUATEMALA", false));
            dxccEntityEnumeration.Add(new dxccEntity(77, "GRENADA", false));
            dxccEntityEnumeration.Add(new dxccEntity(78, "HAITI", false));
            dxccEntityEnumeration.Add(new dxccEntity(79, "GUADELOUPE", false));
            dxccEntityEnumeration.Add(new dxccEntity(80, "HONDURAS", false));
            dxccEntityEnumeration.Add(new dxccEntity(81, "GERMANY", true));
            dxccEntityEnumeration.Add(new dxccEntity(82, "JAMAICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(83, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(84, "MARTINIQUE", false));
            dxccEntityEnumeration.Add(new dxccEntity(85, "BONAIRE, CURACAO", true));
            dxccEntityEnumeration.Add(new dxccEntity(86, "NICARAGUA", false));
            dxccEntityEnumeration.Add(new dxccEntity(87, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(88, "PANAMA", false));
            dxccEntityEnumeration.Add(new dxccEntity(89, "TURKS & CAICOS IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(90, "TRINIDAD & TOBAGO", false));
            dxccEntityEnumeration.Add(new dxccEntity(91, "ARUBA", false));
            dxccEntityEnumeration.Add(new dxccEntity(92, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(93, "GEYSER REEF", true));
            dxccEntityEnumeration.Add(new dxccEntity(94, "ANTIGUA & BARBUDA", false));
            dxccEntityEnumeration.Add(new dxccEntity(95, "DOMINICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(96, "MONTSERRAT", false));
            dxccEntityEnumeration.Add(new dxccEntity(97, "ST. LUCIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(98, "ST. VINCENT", false));
            dxccEntityEnumeration.Add(new dxccEntity(99, "GLORIOSO IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(100, "ARGENTINA", false));
            dxccEntityEnumeration.Add(new dxccEntity(101, "GOA", true));
            dxccEntityEnumeration.Add(new dxccEntity(102, "GOLD COAST, TOGOLAND", true));
            dxccEntityEnumeration.Add(new dxccEntity(103, "GUAM", false));
            dxccEntityEnumeration.Add(new dxccEntity(104, "BOLIVIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(105, "GUANTANAMO BAY", false));
            dxccEntityEnumeration.Add(new dxccEntity(106, "GUERNSEY", false));
            dxccEntityEnumeration.Add(new dxccEntity(107, "GUINEA", false));
            dxccEntityEnumeration.Add(new dxccEntity(108, "BRAZIL", false));
            dxccEntityEnumeration.Add(new dxccEntity(109, "GUINEA-BISSAU", false));
            dxccEntityEnumeration.Add(new dxccEntity(110, "HAWAII", false));
            dxccEntityEnumeration.Add(new dxccEntity(111, "HEARD I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(112, "CHILE", false));
            dxccEntityEnumeration.Add(new dxccEntity(113, "IFNI", false));
            dxccEntityEnumeration.Add(new dxccEntity(114, "ISLE OF MAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(115, "ITALIAN SOMALILAND", true));
            dxccEntityEnumeration.Add(new dxccEntity(116, "COLOMBIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(117, "ITU HQ", false));
            dxccEntityEnumeration.Add(new dxccEntity(118, "JAN MAYEN", false));
            dxccEntityEnumeration.Add(new dxccEntity(119, "JAVA", true));
            dxccEntityEnumeration.Add(new dxccEntity(120, "ECUADOR", false));
            dxccEntityEnumeration.Add(new dxccEntity(121, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(122, "JERSEY", false));
            dxccEntityEnumeration.Add(new dxccEntity(123, "JOHNSTON I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(124, "JUAN DE NOVA, EUROPA", false));
            dxccEntityEnumeration.Add(new dxccEntity(125, "JUAN FERNANDEZ IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(126, "KALININGRAD", false));
            dxccEntityEnumeration.Add(new dxccEntity(127, "KAMARAN IS.", true));
            dxccEntityEnumeration.Add(new dxccEntity(128, "KARELO-FINNISH REPUBLIC", true));
            dxccEntityEnumeration.Add(new dxccEntity(129, "GUYANA", false));
            dxccEntityEnumeration.Add(new dxccEntity(130, "KAZAKHSTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(131, "KERGUELEN IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(132, "PARAGUAY", false));
            dxccEntityEnumeration.Add(new dxccEntity(133, "KERMADEC IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(134, "KINGMAN REEF", true));
            dxccEntityEnumeration.Add(new dxccEntity(135, "KYRGYZSTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(136, "PERU", false));
            dxccEntityEnumeration.Add(new dxccEntity(137, "REPUBLIC OF KOREA", false));
            dxccEntityEnumeration.Add(new dxccEntity(138, "KURE I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(139, "KURIA MURIA I.", true));
            dxccEntityEnumeration.Add(new dxccEntity(140, "SURINAME", false));
            dxccEntityEnumeration.Add(new dxccEntity(141, "FALKLAND IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(142, "LAKSHADWEEP IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(143, "LAOS", false));
            dxccEntityEnumeration.Add(new dxccEntity(144, "URUGUAY", false));
            dxccEntityEnumeration.Add(new dxccEntity(145, "LATVIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(146, "LITHUANIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(147, "LORD HOWE I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(148, "VENEZUELA", false));
            dxccEntityEnumeration.Add(new dxccEntity(149, "AZORES", false));
            dxccEntityEnumeration.Add(new dxccEntity(150, "AUSTRALIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(151, "MALYJ VYSOTSKIJ I.", true));
            dxccEntityEnumeration.Add(new dxccEntity(152, "MACAO", false));
            dxccEntityEnumeration.Add(new dxccEntity(153, "MACQUARIE I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(154, "YEMEN ARAB REPUBLIC", true));
            dxccEntityEnumeration.Add(new dxccEntity(155, "MALAYA", true));
            dxccEntityEnumeration.Add(new dxccEntity(156, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(157, "NAURU", false));
            dxccEntityEnumeration.Add(new dxccEntity(158, "VANUATU", false));
            dxccEntityEnumeration.Add(new dxccEntity(159, "MALDIVES", false));
            dxccEntityEnumeration.Add(new dxccEntity(160, "TONGA", false));
            dxccEntityEnumeration.Add(new dxccEntity(161, "MALPELO I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(162, "NEW CALEDONIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(163, "PAPUA NEW GUINEA", false));
            dxccEntityEnumeration.Add(new dxccEntity(164, "MANCHURIA", true));
            dxccEntityEnumeration.Add(new dxccEntity(165, "MAURITIUS", false));
            dxccEntityEnumeration.Add(new dxccEntity(166, "MARIANA IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(167, "MARKET REEF", false));
            dxccEntityEnumeration.Add(new dxccEntity(168, "MARSHALL IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(169, "MAYOTTE", false));
            dxccEntityEnumeration.Add(new dxccEntity(170, "NEW ZEALAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(171, "MELLISH REEF", false));
            dxccEntityEnumeration.Add(new dxccEntity(172, "PITCAIRN I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(173, "MICRONESIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(174, "MIDWAY I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(175, "FRENCH POLYNESIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(176, "FIJI", false));
            dxccEntityEnumeration.Add(new dxccEntity(177, "MINAMI TORISHIMA", false));
            dxccEntityEnumeration.Add(new dxccEntity(178, "MINERVA REEF", true));
            dxccEntityEnumeration.Add(new dxccEntity(179, "MOLDOVA", false));
            dxccEntityEnumeration.Add(new dxccEntity(180, "MOUNT ATHOS", false));
            dxccEntityEnumeration.Add(new dxccEntity(181, "MOZAMBIQUE", false));
            dxccEntityEnumeration.Add(new dxccEntity(182, "NAVASSA I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(183, "NETHERLANDS BORNEO", true));
            dxccEntityEnumeration.Add(new dxccEntity(184, "NETHERLANDS NEW GUINEA", true));
            dxccEntityEnumeration.Add(new dxccEntity(185, "SOLOMON IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(186, "NEWFOUNDLAND, LABRADOR", true));
            dxccEntityEnumeration.Add(new dxccEntity(187, "NIGER", false));
            dxccEntityEnumeration.Add(new dxccEntity(188, "NIUE", false));
            dxccEntityEnumeration.Add(new dxccEntity(189, "NORFOLK I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(190, "SAMOA", false));
            dxccEntityEnumeration.Add(new dxccEntity(191, "NORTH COOK IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(192, "OGASAWARA", false));
            dxccEntityEnumeration.Add(new dxccEntity(193, "OKINAWA (RYUKYU IS.)", true));
            dxccEntityEnumeration.Add(new dxccEntity(194, "OKINO TORI-SHIMA", true));
            dxccEntityEnumeration.Add(new dxccEntity(195, "ANNOBON I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(196, "PALESTINE", true));
            dxccEntityEnumeration.Add(new dxccEntity(197, "PALMYRA & JARVIS IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(198, "PAPUA TERRITORY", true));
            dxccEntityEnumeration.Add(new dxccEntity(199, "PETER 1 I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(200, "PORTUGUESE TIMOR", true));
            dxccEntityEnumeration.Add(new dxccEntity(201, "PRINCE EDWARD & MARION IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(202, "PUERTO RICO", false));
            dxccEntityEnumeration.Add(new dxccEntity(203, "ANDORRA", false));
            dxccEntityEnumeration.Add(new dxccEntity(204, "REVILLAGIGEDO", false));
            dxccEntityEnumeration.Add(new dxccEntity(205, "ASCENSION I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(206, "AUSTRIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(207, "RODRIGUEZ I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(208, "RUANDA-URUNDI", true));
            dxccEntityEnumeration.Add(new dxccEntity(209, "BELGIUM", false));
            dxccEntityEnumeration.Add(new dxccEntity(210, "SAAR", true));
            dxccEntityEnumeration.Add(new dxccEntity(211, "SABLE I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(212, "BULGARIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(213, "SAINT MARTIN", false));
            dxccEntityEnumeration.Add(new dxccEntity(214, "CORSICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(215, "CYPRUS", false));
            dxccEntityEnumeration.Add(new dxccEntity(216, "SAN ANDRES & PROVIDENCIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(217, "SAN FELIX & SAN AMBROSIO", false));
            dxccEntityEnumeration.Add(new dxccEntity(218, "CZECHOSLOVAKIA", true));
            dxccEntityEnumeration.Add(new dxccEntity(218, "SAO TOME & PRINCIPE", false));
            dxccEntityEnumeration.Add(new dxccEntity(220, "SARAWAK", true));
            dxccEntityEnumeration.Add(new dxccEntity(221, "DENMARK", false));
            dxccEntityEnumeration.Add(new dxccEntity(222, "FAROE IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(223, "ENGLAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(224, "FINLAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(225, "SARDINIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(226, "SAUDI ARABIA/IRAQ NEUTRAL ZONE", true));
            dxccEntityEnumeration.Add(new dxccEntity(227, "FRANCE", false));
            dxccEntityEnumeration.Add(new dxccEntity(228, "SERRANA BANK & RONCADOR CAY", true));
            dxccEntityEnumeration.Add(new dxccEntity(229, "GERMAN DEMOCRATIC REPUBLIC", true));
            dxccEntityEnumeration.Add(new dxccEntity(230, "FEDERAL REPUBLIC OF GERMANY", false));
            dxccEntityEnumeration.Add(new dxccEntity(231, "SIKKIM", false));
            dxccEntityEnumeration.Add(new dxccEntity(232, "SOMALIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(233, "GIBRALTAR", false));
            dxccEntityEnumeration.Add(new dxccEntity(234, "SOUTH COOK IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(235, "SOUTH GEORGIA I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(236, "GREECE", false));
            dxccEntityEnumeration.Add(new dxccEntity(237, "GREENLAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(238, "SOUTH ORKNEY IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(239, "HUNGARY", false));
            dxccEntityEnumeration.Add(new dxccEntity(240, "SOUTH SANDWICH IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(241, "SOUTH SHETLAND IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(242, "ICELAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(243, "PEOPLE'S DEMOCRATIC REP. OF YEMEN", true));
            dxccEntityEnumeration.Add(new dxccEntity(244, "SOUTHERN SUDAN", true));
            dxccEntityEnumeration.Add(new dxccEntity(245, "IRELAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(246, "SOVEREIGN MILITARY ORDER OF MALTA", false));
            dxccEntityEnumeration.Add(new dxccEntity(247, "SPRATLY IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(248, "ITALY", false));
            dxccEntityEnumeration.Add(new dxccEntity(249, "ST. KITTS & NEVIS", false));
            dxccEntityEnumeration.Add(new dxccEntity(250, "ST. HELENA", false));
            dxccEntityEnumeration.Add(new dxccEntity(251, "LIECHTENSTEIN", false));
            dxccEntityEnumeration.Add(new dxccEntity(252, "ST. PAUL I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(253, "ST. PETER & ST. PAUL ROCKS", false));
            dxccEntityEnumeration.Add(new dxccEntity(254, "LUXEMBOURG", false));
            dxccEntityEnumeration.Add(new dxccEntity(255, "ST. MAARTEN, SABA, ST. EUSTATIUS", true));
            dxccEntityEnumeration.Add(new dxccEntity(256, "MADEIRA IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(257, "MALTA", false));
            dxccEntityEnumeration.Add(new dxccEntity(258, "SUMATRA", true));
            dxccEntityEnumeration.Add(new dxccEntity(259, "SVALBARD", false));
            dxccEntityEnumeration.Add(new dxccEntity(260, "MONACO", false));
            dxccEntityEnumeration.Add(new dxccEntity(261, "SWAN IS.", true));
            dxccEntityEnumeration.Add(new dxccEntity(262, "TAJIKISTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(263, "NETHERLANDS", false));
            dxccEntityEnumeration.Add(new dxccEntity(264, "TANGIER", true));
            dxccEntityEnumeration.Add(new dxccEntity(265, "NORTHERN IRELAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(266, "NORWAY", false));
            dxccEntityEnumeration.Add(new dxccEntity(267, "TERRITORY OF NEW GUINEA", true));
            dxccEntityEnumeration.Add(new dxccEntity(268, "TIBET", true));
            dxccEntityEnumeration.Add(new dxccEntity(269, "POLAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(270, "TOKELAU IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(271, "TRIESTE", true));
            dxccEntityEnumeration.Add(new dxccEntity(272, "PORTUGAL", false));
            dxccEntityEnumeration.Add(new dxccEntity(273, "TRINDADE & MARTIM VAZ IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(274, "TRISTAN DA CUNHA & GOUGH I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(275, "ROMANIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(276, "TROMELIN I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(277, "ST. PIERRE & MIQUELON", false));
            dxccEntityEnumeration.Add(new dxccEntity(278, "SAN MARINO", false));
            dxccEntityEnumeration.Add(new dxccEntity(279, "SCOTLAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(280, "TURKMENISTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(281, "SPAIN", false));
            dxccEntityEnumeration.Add(new dxccEntity(282, "TUVALU", false));
            dxccEntityEnumeration.Add(new dxccEntity(283, "UK SOVEREIGN BASE AREAS ON CYPRUS", false));
            dxccEntityEnumeration.Add(new dxccEntity(284, "SWEDEN", false));
            dxccEntityEnumeration.Add(new dxccEntity(285, "VIRGIN IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(286, "UGANDA", false));
            dxccEntityEnumeration.Add(new dxccEntity(287, "SWITZERLAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(288, "UKRAINE", false));
            dxccEntityEnumeration.Add(new dxccEntity(289, "UNITED NATIONS HQ", false));
            dxccEntityEnumeration.Add(new dxccEntity(290, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(291, "UNITED STATES OF AMERICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(292, "UZBEKISTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(293, "VIET NAM", false));
            dxccEntityEnumeration.Add(new dxccEntity(294, "WALES", false));
            dxccEntityEnumeration.Add(new dxccEntity(295, "VATICAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(296, "SERBIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(297, "WAKE I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(298, "WALLIS & FUTUNA IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(299, "WEST MALAYSIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(300, "Undefined", true));
            dxccEntityEnumeration.Add(new dxccEntity(301, "W. KIRIBATI (GILBERT IS. )", false));
            dxccEntityEnumeration.Add(new dxccEntity(302, "WESTERN SAHARA", false));
            dxccEntityEnumeration.Add(new dxccEntity(303, "WILLIS I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(304, "BAHRAIN", false));
            dxccEntityEnumeration.Add(new dxccEntity(305, "BANGLADESH", false));
            dxccEntityEnumeration.Add(new dxccEntity(306, "BHUTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(307, "ZANZIBAR", true));
            dxccEntityEnumeration.Add(new dxccEntity(308, "COSTA RICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(309, "MYANMAR", false));
            dxccEntityEnumeration.Add(new dxccEntity(312, "CAMBODIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(315, "SRI LANKA", false));
            dxccEntityEnumeration.Add(new dxccEntity(318, "CHINA", false));
            dxccEntityEnumeration.Add(new dxccEntity(321, "HONG KONG", false));
            dxccEntityEnumeration.Add(new dxccEntity(324, "INDIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(327, "INDONESIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(330, "IRAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(333, "IRAQ", false));
            dxccEntityEnumeration.Add(new dxccEntity(336, "ISRAEL", false));
            dxccEntityEnumeration.Add(new dxccEntity(339, "JAPAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(342, "JORDAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(344, "DEMOCRATIC PEOPLE'S REP. OF KOREA", false));
            dxccEntityEnumeration.Add(new dxccEntity(345, "BRUNEI DARUSSALAM", false));
            dxccEntityEnumeration.Add(new dxccEntity(348, "KUWAIT", false));
            dxccEntityEnumeration.Add(new dxccEntity(354, "LEBANON", false));
            dxccEntityEnumeration.Add(new dxccEntity(363, "MONGOLIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(369, "NEPAL", false));
            dxccEntityEnumeration.Add(new dxccEntity(370, "OMAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(372, "PAKISTAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(375, "PHILIPPINES", false));
            dxccEntityEnumeration.Add(new dxccEntity(376, "QATAR", false));
            dxccEntityEnumeration.Add(new dxccEntity(378, "SAUDI ARABIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(379, "SEYCHELLES", false));
            dxccEntityEnumeration.Add(new dxccEntity(381, "SINGAPORE", false));
            dxccEntityEnumeration.Add(new dxccEntity(382, "DJIBOUTI", false));
            dxccEntityEnumeration.Add(new dxccEntity(384, "SYRIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(386, "TAIWAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(387, "THAILAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(390, "TURKEY", false));
            dxccEntityEnumeration.Add(new dxccEntity(391, "UNITED ARAB EMIRATES", false));
            dxccEntityEnumeration.Add(new dxccEntity(400, "ALGERIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(401, "ANGOLA", false));
            dxccEntityEnumeration.Add(new dxccEntity(402, "BOTSWANA", false));
            dxccEntityEnumeration.Add(new dxccEntity(404, "BURUNDI", false));
            dxccEntityEnumeration.Add(new dxccEntity(406, "CAMEROON", false));
            dxccEntityEnumeration.Add(new dxccEntity(408, "CENTRAL AFRICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(409, "CAPE VERDE", false));
            dxccEntityEnumeration.Add(new dxccEntity(410, "CHAD", false));
            dxccEntityEnumeration.Add(new dxccEntity(411, "COMOROS", false));
            dxccEntityEnumeration.Add(new dxccEntity(412, "REPUBLIC OF THE CONGO", false));
            dxccEntityEnumeration.Add(new dxccEntity(414, "DEMOCRATIC REPUBLIC OF THE CONGO", false));
            dxccEntityEnumeration.Add(new dxccEntity(416, "BENIN", false));
            dxccEntityEnumeration.Add(new dxccEntity(420, "GABON", false));
            dxccEntityEnumeration.Add(new dxccEntity(422, "THE GAMBIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(424, "GHANA", false));
            dxccEntityEnumeration.Add(new dxccEntity(428, "COTE D'IVOIRE", false));
            dxccEntityEnumeration.Add(new dxccEntity(430, "KENYA", false));
            dxccEntityEnumeration.Add(new dxccEntity(432, "LESOTHO", false));
            dxccEntityEnumeration.Add(new dxccEntity(434, "LIBERIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(436, "LIBYA", false));
            dxccEntityEnumeration.Add(new dxccEntity(438, "MADAGASCAR", false));
            dxccEntityEnumeration.Add(new dxccEntity(440, "MALAWI", false));
            dxccEntityEnumeration.Add(new dxccEntity(442, "MALI", false));
            dxccEntityEnumeration.Add(new dxccEntity(444, "MAURITANIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(450, "NIGERIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(452, "ZIMBABWE", false));
            dxccEntityEnumeration.Add(new dxccEntity(453, "REUNION I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(454, "RWANDA", false));
            dxccEntityEnumeration.Add(new dxccEntity(456, "SENEGAL", false));
            dxccEntityEnumeration.Add(new dxccEntity(458, "SIERRA LEONE", false));
            dxccEntityEnumeration.Add(new dxccEntity(460, "ROTUMA I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(462, "SOUTH AFRICA", false));
            dxccEntityEnumeration.Add(new dxccEntity(464, "NAMIBIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(466, "SUDAN", false));
            dxccEntityEnumeration.Add(new dxccEntity(468, "SWAZILAND", false));
            dxccEntityEnumeration.Add(new dxccEntity(470, "TANZANIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(474, "TUNISIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(478, "EGYPT", false));
            dxccEntityEnumeration.Add(new dxccEntity(480, "BURKINA FASO", false));
            dxccEntityEnumeration.Add(new dxccEntity(482, "ZAMBIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(483, "TOGO", false));
            dxccEntityEnumeration.Add(new dxccEntity(488, "WALVIS BAY", true));
            dxccEntityEnumeration.Add(new dxccEntity(489, "CONWAY REEF", false));
            dxccEntityEnumeration.Add(new dxccEntity(490, "BANABA I. (OCEAN I.)", false));
            dxccEntityEnumeration.Add(new dxccEntity(492, "YEMEN", false));
            dxccEntityEnumeration.Add(new dxccEntity(493, "PENGUIN IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(497, "CROATIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(499, "SLOVENIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(501, "BOSNIA-HERZEGOVINA", false));
            dxccEntityEnumeration.Add(new dxccEntity(502, "MACEDONIA", false));
            dxccEntityEnumeration.Add(new dxccEntity(503, "CZECH REPUBLIC", false));
            dxccEntityEnumeration.Add(new dxccEntity(504, "SLOVAK REPUBLIC", false));
            dxccEntityEnumeration.Add(new dxccEntity(505, "PRATAS I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(506, "SCARBOROUGH REEF", false));
            dxccEntityEnumeration.Add(new dxccEntity(507, "TEMOTU PROVINCE", false));
            dxccEntityEnumeration.Add(new dxccEntity(508, "AUSTRAL I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(509, "MARQUESAS IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(510, "PALESTINE", false));
            dxccEntityEnumeration.Add(new dxccEntity(511, "TIMOR-LESTE", false));
            dxccEntityEnumeration.Add(new dxccEntity(512, "CHESTERFIELD IS.", false));
            dxccEntityEnumeration.Add(new dxccEntity(513, "DUCIE I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(514, "MONTENEGRO", false));
            dxccEntityEnumeration.Add(new dxccEntity(515, "SWAINS I.", false));
            dxccEntityEnumeration.Add(new dxccEntity(516, "SAINT BARTHELEMY", false));
            dxccEntityEnumeration.Add(new dxccEntity(517, "CURACAO", false));
            dxccEntityEnumeration.Add(new dxccEntity(518, "ST MAARTEN", false));
            dxccEntityEnumeration.Add(new dxccEntity(519, "SABA & ST. EUSTATIUS", false));
            dxccEntityEnumeration.Add(new dxccEntity(520, "BONAIRE", false));
            dxccEntityEnumeration.Add(new dxccEntity(521, "SOUTH SUDAN (REPUBLIC OF)", false));
            dxccEntityEnumeration.Add(new dxccEntity(522, "REPUBLIC OF KOSOVO", false));

            return dxccEntityEnumeration;
        }

        public static dxccEntity getDxccEntity(int dxccEntityCode)
        {
            List<dxccEntity> dxccEntityList = getDXCCEntity();
            dxccEntity theEntity = dxccEntityList.Where(a => a._EntityCode.Equals(dxccEntityCode)).FirstOrDefault() ?? new dxccEntity();
            return theEntity;
        }


        public static List<dxccEntity> getDxccEntity(string countryNameSubstring)
        {
            List<dxccEntity> dxccEntityList = getDXCCEntity();
            List<dxccEntity> returnListOfCountries = new List<dxccEntity>();
            
            foreach (dxccEntity aCOuntry in dxccEntityList)
            {
                if (string.IsNullOrEmpty(aCOuntry._EntityName)) continue;
                if (aCOuntry._EntityName.ToUpper().Contains(countryNameSubstring.ToUpper()))
                {
                    returnListOfCountries.Add(aCOuntry);
                }
            }

            return returnListOfCountries;
        }


        private static List<mode> getModes()
        {
            List<mode> modeEnumeration = new List<mode>();
            modeEnumeration.Add(new mode("AM"));
            modeEnumeration.Add(new mode("ARDOP", "Amateur Radio Digital Open Protocol"));
            modeEnumeration.Add(new mode("ATV"));
            modeEnumeration.Add(new mode("CHIP"));
            modeEnumeration.Add(new mode("CLO"));
            modeEnumeration.Add(new mode("CONTESTI"));
            modeEnumeration.Add(new mode("CW"));
            modeEnumeration.Add(new mode("DIGITALVOICE"));
            modeEnumeration.Add(new mode("DOMINO"));
            modeEnumeration.Add(new mode("DYNAMIC"));
            modeEnumeration.Add(new mode("FSK441"));
            modeEnumeration.Add(new mode("FT8", "Franke-Taylor design, 8-FSK modulation"));
            modeEnumeration.Add(new mode("HELL"));
            modeEnumeration.Add(new mode("ISCAT"));
            modeEnumeration.Add(new mode("JT4"));
            modeEnumeration.Add(new mode("JT6M"));
            modeEnumeration.Add(new mode("JT9"));
            modeEnumeration.Add(new mode("JT44"));
            modeEnumeration.Add(new mode("JT65"));
            modeEnumeration.Add(new mode("MFSK"));
            modeEnumeration.Add(new mode("MSK144"));
            modeEnumeration.Add(new mode("MT63"));
            modeEnumeration.Add(new mode("OLIVIA"));
            modeEnumeration.Add(new mode("OPERA"));
            modeEnumeration.Add(new mode("PAC"));
            modeEnumeration.Add(new mode("PAX"));
            modeEnumeration.Add(new mode("PKT"));
            modeEnumeration.Add(new mode("PSK"));
            modeEnumeration.Add(new mode("PSK2K"));
            modeEnumeration.Add(new mode("Q15"));
            modeEnumeration.Add(new mode("QRA64"));
            modeEnumeration.Add(new mode("ROS"));
            modeEnumeration.Add(new mode("RTTY"));
            modeEnumeration.Add(new mode("RTTYM"));
            modeEnumeration.Add(new mode("SSB"));
            modeEnumeration.Add(new mode("SSTV"));
            modeEnumeration.Add(new mode("T10", "Tonal 10 digital mode with focus on sensitivity, band capacity and resistance to the HF Doppler frequency spread"));
            modeEnumeration.Add(new mode("THOR"));
            modeEnumeration.Add(new mode("THRB"));
            modeEnumeration.Add(new mode("TOR"));
            modeEnumeration.Add(new mode("V4"));
            modeEnumeration.Add(new mode("VOI"));
            modeEnumeration.Add(new mode("WINMOR"));
            modeEnumeration.Add(new mode("WSPR"));
            modeEnumeration.Add(new mode("AMTORFEC", true));
            modeEnumeration.Add(new mode("ASCI", true));
            modeEnumeration.Add(new mode("C4FM", "C4FM 4-level FSK Technology", true));
            modeEnumeration.Add(new mode("CHIP64", true));
            modeEnumeration.Add(new mode("CHIP128", true));
            modeEnumeration.Add(new mode("DOMINOF", true));
            modeEnumeration.Add(new mode("DSTAR", "Digital Smart Technologies for Amateur Radio", true));
            modeEnumeration.Add(new mode("FMHELL", true));
            modeEnumeration.Add(new mode("FSK31", true));
            modeEnumeration.Add(new mode("GTOR", true));
            modeEnumeration.Add(new mode("HELL80", true));
            modeEnumeration.Add(new mode("HFSK", true));
            modeEnumeration.Add(new mode("JT4A", true));
            modeEnumeration.Add(new mode("JT4B", true));
            modeEnumeration.Add(new mode("JT4C", true));
            modeEnumeration.Add(new mode("JT4D", true));
            modeEnumeration.Add(new mode("JT4E", true));
            modeEnumeration.Add(new mode("JT4F", true));
            modeEnumeration.Add(new mode("JT4G", true));
            modeEnumeration.Add(new mode("JT65A", true));
            modeEnumeration.Add(new mode("JT65B", true));
            modeEnumeration.Add(new mode("JT65C", true));
            modeEnumeration.Add(new mode("MFSK8", true));
            modeEnumeration.Add(new mode("MFSK16", true));
            modeEnumeration.Add(new mode("PAC2", true));
            modeEnumeration.Add(new mode("PAC3", true));
            modeEnumeration.Add(new mode("PAX2", true));
            modeEnumeration.Add(new mode("PCW", true));
            modeEnumeration.Add(new mode("PSK10", true));
            modeEnumeration.Add(new mode("PSK31", true));
            modeEnumeration.Add(new mode("PSK63", true));
            modeEnumeration.Add(new mode("PSK63F", true));
            modeEnumeration.Add(new mode("PSK125", true));
            modeEnumeration.Add(new mode("PSKAM10", true));
            modeEnumeration.Add(new mode("PSKAM31", true));
            modeEnumeration.Add(new mode("PSKAM50", true));
            modeEnumeration.Add(new mode("PSKFEC31", true));
            modeEnumeration.Add(new mode("PSKHELL", true));
            modeEnumeration.Add(new mode("QPSK31", true));
            modeEnumeration.Add(new mode("QPSK63", true));
            modeEnumeration.Add(new mode("QPSK125", true));
            modeEnumeration.Add(new mode("THRBX", true));
            return modeEnumeration;
        }

        public static List<subMode> getSubmodes()
        {
            List<subMode> subModeEnumeration = new();
            List<mode> modes = new();
            modes = getModes();
            mode PSKMode = modes.Where(a => a._Name.Equals("PSK")).First();
            mode RTTYMode = modes.Where(a => a._Name.Equals("RTTY")).First();
            mode DigitalVoiceMode = modes.Where(a => a._Name.Equals("DIGITALVOICE")).First();
            mode TORMode = modes.Where(a => a._Name.Equals("TOR")).First();
            mode CHIPMode = modes.Where(a => a._Name.Equals("CHIP")).First();
            mode DOMINOMode = modes.Where(a => a._Name.Equals("DOMINO")).First();
            mode HELLMode = modes.Where(a => a._Name.Equals("HELL")).First();
            mode MFSKMode = modes.Where(a => a._Name.Equals("MFSK")).First();
            mode ISCATMode = modes.Where(a => a._Name.Equals("ISCAT")).First();
            mode JT4Mode = modes.Where(a => a._Name.Equals("JT4")).First();
            mode JT9Mode = modes.Where(a => a._Name.Equals("JT9")).First();
            mode JT65Mode = modes.Where(a => a._Name.Equals("JT65")).First();
            mode SSBMode = modes.Where(a => a._Name.Equals("SSB")).First();
            mode OLIVIAMode = modes.Where(a => a._Name.Equals("OLIVIA")).First();
            mode OPERAMode = modes.Where(a => a._Name.Equals("OPERA")).First();
            mode PACMode = modes.Where(a => a._Name.Equals("PAC")).First();
            mode PAXMode = modes.Where(a => a._Name.Equals("PAX")).First();
            mode CWMode = modes.Where(a => a._Name.Equals("CW")).First();
            mode QRA64Mode = modes.Where(a => a._Name.Equals("QRA64")).First();
            mode ROSMode = modes.Where(a => a._Name.Equals("ROS")).First();
            mode THORMode = modes.Where(a => a._Name.Equals("THOR")).First();
            mode THRBMode = modes.Where(a => a._Name.Equals("THRB")).First();
            mode DYNAMICMode = modes.Where(a => a._Name.Equals("DYNAMIC")).First();

            subModeEnumeration.Add(new subMode("8PSK125", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK125F", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK125FL", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK250", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK250F", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK250FL", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK500", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK500F", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK1000", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK1000F", PSKMode));
            subModeEnumeration.Add(new subMode("8PSK1200F", PSKMode));
            subModeEnumeration.Add(new subMode("AMTORFEC", TORMode));
            subModeEnumeration.Add(new subMode("ASCI", RTTYMode));
            subModeEnumeration.Add(new subMode("C4FM", DigitalVoiceMode));
            subModeEnumeration.Add(new subMode("CHIP64", CHIPMode));
            subModeEnumeration.Add(new subMode("CHIP128", CHIPMode));
            subModeEnumeration.Add(new subMode("DMR", DigitalVoiceMode));
            subModeEnumeration.Add(new subMode("DOM-M", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM4", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM5", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM8", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM11", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM16", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM22", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM44", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOM88", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOMINOEX", DOMINOMode));
            subModeEnumeration.Add(new subMode("DOMINOF", DOMINOMode));
            subModeEnumeration.Add(new subMode("DSTAR", DigitalVoiceMode));
            subModeEnumeration.Add(new subMode("FMHELL", HELLMode));
            subModeEnumeration.Add(new subMode("FSK31", PSKMode));
            subModeEnumeration.Add(new subMode("FSKHELL", HELLMode));
            subModeEnumeration.Add(new subMode("FSQCALL", MFSKMode));
            subModeEnumeration.Add(new subMode("FST4", MFSKMode));
            subModeEnumeration.Add(new subMode("FST4W", MFSKMode));
            subModeEnumeration.Add(new subMode("FT4", MFSKMode));
            subModeEnumeration.Add(new subMode("GTOR", TORMode));
            subModeEnumeration.Add(new subMode("HELL80", HELLMode));
            subModeEnumeration.Add(new subMode("HELLX5", HELLMode));
            subModeEnumeration.Add(new subMode("HELLX9", HELLMode));
            subModeEnumeration.Add(new subMode("HFSK", HELLMode));
            subModeEnumeration.Add(new subMode("ISCAT-A", ISCATMode));
            subModeEnumeration.Add(new subMode("ISCAT-B", ISCATMode));
            subModeEnumeration.Add(new subMode("JS8", MFSKMode));
            subModeEnumeration.Add(new subMode("JT4A", JT4Mode));
            subModeEnumeration.Add(new subMode("JT4B", JT4Mode));
            subModeEnumeration.Add(new subMode("JT4C", JT4Mode));
            subModeEnumeration.Add(new subMode("JT4D", JT4Mode));
            subModeEnumeration.Add(new subMode("JT4E", JT4Mode));
            subModeEnumeration.Add(new subMode("JT4F", JT4Mode));
            subModeEnumeration.Add(new subMode("JT4G", JT4Mode));
            subModeEnumeration.Add(new subMode("JT9-1", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9-2", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9-5", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9-10", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9-30", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9A", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9B", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9C", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9D", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9E", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9E FAST", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9F", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9F FAST", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9G", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9G FAST", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9H", JT9Mode));
            subModeEnumeration.Add(new subMode("JT9H FAST", JT9Mode));
            subModeEnumeration.Add(new subMode("JT65A", JT65Mode));
            subModeEnumeration.Add(new subMode("JT65B", JT65Mode));
            subModeEnumeration.Add(new subMode("JT65B2", JT65Mode));
            subModeEnumeration.Add(new subMode("JT65C", JT65Mode));
            subModeEnumeration.Add(new subMode("JT65C2", JT65Mode));
            subModeEnumeration.Add(new subMode("JTMS", MFSKMode));
            subModeEnumeration.Add(new subMode("LSB", SSBMode));
            subModeEnumeration.Add(new subMode("MFSK4", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK8", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK11", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK16", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK22", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK31", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK32", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK64", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK64L", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK128", MFSKMode));
            subModeEnumeration.Add(new subMode("MFSK128L", MFSKMode));
            subModeEnumeration.Add(new subMode("NAVTEX", TORMode));
            subModeEnumeration.Add(new subMode("OLIVIA 4/125", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OLIVIA 4/250", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OLIVIA 8/250", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OLIVIA 8/500", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OLIVIA 16/500", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OLIVIA 16/1000", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OLIVIA 32/1000", OLIVIAMode));
            subModeEnumeration.Add(new subMode("OPERA-BEACON", OPERAMode));
            subModeEnumeration.Add(new subMode("OPERA-QSO", OPERAMode));
            subModeEnumeration.Add(new subMode("PAC2", PACMode));
            subModeEnumeration.Add(new subMode("PAC3", PACMode));
            subModeEnumeration.Add(new subMode("PAC4", PACMode));
            subModeEnumeration.Add(new subMode("PAX2", PAXMode));
            subModeEnumeration.Add(new subMode("PCW", CWMode));
            subModeEnumeration.Add(new subMode("PSK10", PSKMode));
            subModeEnumeration.Add(new subMode("PSK31", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63F", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63RC10", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63RC20", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63RC32", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63RC4", PSKMode));
            subModeEnumeration.Add(new subMode("PSK63RC5", PSKMode));
            subModeEnumeration.Add(new subMode("PSK125", PSKMode));
            subModeEnumeration.Add(new subMode("PSK125RC10", PSKMode));
            subModeEnumeration.Add(new subMode("PSK125RC12", PSKMode));
            subModeEnumeration.Add(new subMode("PSK125RC16", PSKMode));
            subModeEnumeration.Add(new subMode("PSK125RC4", PSKMode));
            subModeEnumeration.Add(new subMode("PSK125RC5", PSKMode));
            subModeEnumeration.Add(new subMode("PSK250", PSKMode));
            subModeEnumeration.Add(new subMode("PSK250RC2", PSKMode));
            subModeEnumeration.Add(new subMode("PSK250RC3", PSKMode));
            subModeEnumeration.Add(new subMode("PSK250RC5", PSKMode));
            subModeEnumeration.Add(new subMode("PSK250RC6", PSKMode));
            subModeEnumeration.Add(new subMode("PSK250RC7", PSKMode));
            subModeEnumeration.Add(new subMode("PSK500", PSKMode));
            subModeEnumeration.Add(new subMode("PSK500RC2", PSKMode));
            subModeEnumeration.Add(new subMode("PSK500RC3", PSKMode));
            subModeEnumeration.Add(new subMode("PSK500RC4", PSKMode));
            subModeEnumeration.Add(new subMode("PSK800RC2", PSKMode));
            subModeEnumeration.Add(new subMode("PSK1000", PSKMode));
            subModeEnumeration.Add(new subMode("PSK1000RC2", PSKMode));
            subModeEnumeration.Add(new subMode("PSKAM10", PSKMode));
            subModeEnumeration.Add(new subMode("PSKAM31", PSKMode));
            subModeEnumeration.Add(new subMode("PSKAM50", PSKMode));
            subModeEnumeration.Add(new subMode("PSKFEC31", PSKMode));
            subModeEnumeration.Add(new subMode("PSKHELL", HELLMode));
            subModeEnumeration.Add(new subMode("QPSK31", PSKMode));
            subModeEnumeration.Add(new subMode("Q65", MFSKMode));
            subModeEnumeration.Add(new subMode("QPSK63", PSKMode));
            subModeEnumeration.Add(new subMode("QPSK125", PSKMode));
            subModeEnumeration.Add(new subMode("QPSK250", PSKMode));
            subModeEnumeration.Add(new subMode("QPSK500", PSKMode));
            subModeEnumeration.Add(new subMode("QRA64A", QRA64Mode));
            subModeEnumeration.Add(new subMode("QRA64B", QRA64Mode));
            subModeEnumeration.Add(new subMode("QRA64C", QRA64Mode));
            subModeEnumeration.Add(new subMode("QRA64D", QRA64Mode));
            subModeEnumeration.Add(new subMode("QRA64E", QRA64Mode));
            subModeEnumeration.Add(new subMode("ROS-EME", ROSMode));
            subModeEnumeration.Add(new subMode("ROS-HF", ROSMode));
            subModeEnumeration.Add(new subMode("ROS-MF", ROSMode));
            subModeEnumeration.Add(new subMode("SIM31", PSKMode));
            subModeEnumeration.Add(new subMode("SITORB", TORMode));
            subModeEnumeration.Add(new subMode("SLOWHELL", HELLMode));
            subModeEnumeration.Add(new subMode("THOR-M", THORMode));
            subModeEnumeration.Add(new subMode("THOR4", THORMode));
            subModeEnumeration.Add(new subMode("THOR5", THORMode));
            subModeEnumeration.Add(new subMode("THOR8", THORMode));
            subModeEnumeration.Add(new subMode("THOR11", THORMode));
            subModeEnumeration.Add(new subMode("THOR16", THORMode));
            subModeEnumeration.Add(new subMode("THOR22", THORMode));
            subModeEnumeration.Add(new subMode("THOR25X4", THORMode));
            subModeEnumeration.Add(new subMode("THOR50X1", THORMode));
            subModeEnumeration.Add(new subMode("THOR50X2", THORMode));
            subModeEnumeration.Add(new subMode("THOR100", THORMode));
            subModeEnumeration.Add(new subMode("THRBX", THRBMode));
            subModeEnumeration.Add(new subMode("THRBX1", THRBMode));
            subModeEnumeration.Add(new subMode("THRBX2", THRBMode));
            subModeEnumeration.Add(new subMode("THRBX4", THRBMode));
            subModeEnumeration.Add(new subMode("THROB1", THRBMode));
            subModeEnumeration.Add(new subMode("THROB2", THRBMode));
            subModeEnumeration.Add(new subMode("THROB4", THRBMode));
            subModeEnumeration.Add(new subMode("USB", SSBMode));
            subModeEnumeration.Add(new subMode("VARA HF", DYNAMICMode));
            subModeEnumeration.Add(new subMode("VARA SATELLITE", DYNAMICMode));
            subModeEnumeration.Add(new subMode("VARA FM 1200", DYNAMICMode));
            subModeEnumeration.Add(new subMode("VARA FM 9600", DYNAMICMode));


            return subModeEnumeration;

        }

        private static List<propogationMode> getPropogationModes()
        {
            List<propogationMode> propogationModeEnumeration = new List<propogationMode>();
            propogationModeEnumeration.Add(new propogationMode("AS", "Aircraft Scatter"));
            propogationModeEnumeration.Add(new propogationMode("AUE", "Aurora - E"));
            propogationModeEnumeration.Add(new propogationMode("AUR", "Aurora"));
            propogationModeEnumeration.Add(new propogationMode("ECH", "EchoLink"));
            propogationModeEnumeration.Add(new propogationMode("EME", "Earth - Moon - Earth"));
            propogationModeEnumeration.Add(new propogationMode("ASES", "Sporadic E"));
            propogationModeEnumeration.Add(new propogationMode("F2", "F2 Reflection"));
            propogationModeEnumeration.Add(new propogationMode("FAI", "Field Aligned Irregularities"));
            propogationModeEnumeration.Add(new propogationMode("GWAVE", "Ground Wave"));
            propogationModeEnumeration.Add(new propogationMode("INTERNET", "Internet - assisted"));
            propogationModeEnumeration.Add(new propogationMode("ION", "Ionoscatter"));
            propogationModeEnumeration.Add(new propogationMode("IRL", "IRLP"));
            propogationModeEnumeration.Add(new propogationMode("LOS", "Line of Sight(includes transmission through obstacles such as walls)"));
            propogationModeEnumeration.Add(new propogationMode("MS", "Meteor scatter"));
            propogationModeEnumeration.Add(new propogationMode("RPT", "Terrestrial or atmospheric repeater or transponder"));
            propogationModeEnumeration.Add(new propogationMode("RS", "Rain scatter"));
            propogationModeEnumeration.Add(new propogationMode("SAT", "Satellite"));
            propogationModeEnumeration.Add(new propogationMode("TEP", "Trans - equatorial"));
            propogationModeEnumeration.Add(new propogationMode("TR", "Tropospheric ducting"));


            return propogationModeEnumeration;
        }

        public static List<QSLMedium> getQSLMediums()
        {
            List<QSLMedium> QSLMediumEnumeration = new List<QSLMedium>();
            QSLMediumEnumeration.Add(new QSLMedium("CARD", "QSO confirmation via paper QSL card"));
            QSLMediumEnumeration.Add(new QSLMedium("EQSL", "QSO confirmation via eQSL.cc"));
            QSLMediumEnumeration.Add(new QSLMedium("LOTW", "QSO confirmation via ARRL Logbook of the World"));

            return QSLMediumEnumeration;
        }

        public static List<QSLRcvd> GetQSLRcvds()
        {
            List<QSLRcvd> QSLRcvdEnumerations = new List<QSLRcvd>();
            QSLRcvdEnumerations.Add(new QSLRcvd("Y", "yes(confirmed)", "-An incoming QSL card has been received -The QSO has been confirmed by the online service"));
            QSLRcvdEnumerations.Add(new QSLRcvd("N", "no", "-An incoming QSL card has not been received  -The QSO has not been confirmed by the online service"));
            QSLRcvdEnumerations.Add(new QSLRcvd("R", "requested", ""));
            QSLRcvdEnumerations.Add(new QSLRcvd("I", "ignore or invalid", " -An incoming QSL card has been received -The QSO has been confirmed by the online service"));
            QSLRcvdEnumerations.Add(new QSLRcvd("V", "verified", "-DXCC award credit granted for the QSL card - instead use\n<CREDIT_GRANTED:39>DXCC:card,DXCC_BAND:card,DXCC_MODE:card -DXCC credit granted for the LoTW confirmation - instead use <CREDIT_GRANTED:39>DXCC:lotw,DXCC_BAND:lotw,DXCC_MODE:lotw"));
            return QSLRcvdEnumerations;
        }

        public static List<QSLSent> GetQSLsSent()
        {
            List<QSLSent> QSLsSentEnumerations = new List<QSLSent>();
            QSLsSentEnumerations.Add(new QSLSent("Y", "yes(confirmed)", "-An outgoing QSL card has been sent -The QSO has been uploaded to, and accepted by, the online service"));
            QSLsSentEnumerations.Add(new QSLSent("N", "no", "-Do not send an outgoing QSL card -Do not upload the QSO to the online service"));
            QSLsSentEnumerations.Add(new QSLSent("R", "requested", "-The contacted station has requested a QSL card -The contacted station has requested the QSO be uploaded to the online service"));
            QSLsSentEnumerations.Add(new QSLSent("Q", "queued", " -An outgoing QSL card has been selected to be sent -A QSO has been selected to be uploaded to the online service"));
            QSLsSentEnumerations.Add(new QSLSent("I", "ignore or invalid", ""));
            return QSLsSentEnumerations;
        }

        public static List<QSLVia> getQSLVia()
        {
            List<QSLVia> QSLViaEnumeration = new List<QSLVia>();
            QSLViaEnumeration.Add(new QSLVia("B", "bureau")); 
            QSLViaEnumeration.Add(new QSLVia("D", "direct")); 
            QSLViaEnumeration.Add(new QSLVia("E", "electronic")); 
            QSLViaEnumeration.Add(new QSLVia("m", "manager"));
            return QSLViaEnumeration;
        }

        public static List<QSOComplete> GetQSOComplete()
        {
            List<QSOComplete> QSOCompleteEnumeration = new List<QSOComplete>();
            QSOCompleteEnumeration.Add(new QSOComplete("Y", "yes"));
            QSOCompleteEnumeration.Add(new QSOComplete("N", "no"));
            QSOCompleteEnumeration.Add(new QSOComplete("nil", "not heard"));
            QSOCompleteEnumeration.Add(new QSOComplete("?", "uncertain"));
            return QSOCompleteEnumeration;
        }

        public static List<QSOUploadStatus> getQSOUploadStatus()
        {
            List<QSOUploadStatus> QSOUploadStatuses = new List<QSOUploadStatus>();
            QSOUploadStatuses.Add(new QSOUploadStatus("Y", "The QSO has been uploaded to, and accepted by, the online service"));
            QSOUploadStatuses.Add(new QSOUploadStatus("N", "Do not upload the QSO to the online service"));
            QSOUploadStatuses.Add(new QSOUploadStatus("M", "The QSO has been modified since being uploaded to the online service"));
            return QSOUploadStatuses;
        }

        public static List<sponsoredAward> getSponsoredAwards()
        {
            List<sponsoredAward> sponsoredAwards = new List<sponsoredAward>();
            sponsoredAwards.Add(new sponsoredAward("ADIF_", "ADIF Development Group https://www.adif.org/313/ADIF_313.htm#XL_ADIF_Development_Group"));
            sponsoredAwards.Add(new sponsoredAward("ARI_", "ARI - Associazione Radioamatori Italiani http://www.ari.it/"));
            sponsoredAwards.Add(new sponsoredAward("ARRL_", "ARRL - American Radio Relay League http://www.arrl.org/"));
            sponsoredAwards.Add(new sponsoredAward("CQ_", "CQ Magazine http://www.cq-amateur-radio.com/"));
            sponsoredAwards.Add(new sponsoredAward("DARC_", "DARC - Deutscher Amateur-Radio-Club e.V. http://www.darc.de/"));
            sponsoredAwards.Add(new sponsoredAward("EQSL_", "eQSL http://eqsl.cc/"));
            sponsoredAwards.Add(new sponsoredAward("IARU_", "IARU - International Amateur Radio Union http://www.iaru.org/"));
            sponsoredAwards.Add(new sponsoredAward("JARL_", "JARL - Japan Amateur Radio League http://www.jarl.or.jp/English/"));
            sponsoredAwards.Add(new sponsoredAward("RSGB_", "RSGB - Radio Society of Great Britain http://rsgb.org/"));
            sponsoredAwards.Add(new sponsoredAward("TAG_", "TAG - Tambov award group http://rdaward.org/"));
            sponsoredAwards.Add(new sponsoredAward("WABAG_", "WAB - Worked all Britain http://www.worked-all-britain.co.uk/"));


            return sponsoredAwards;



        }

        public static List<region> getRegion()
        {
            List<region> Regions = new List<region>();
            Regions.Add(new region("NONE", 0, "Not within a WAE or CQ region that is within a DXCC entity", String.Empty, new List<string>()));
            Regions.Add(new region("IV", 206, "ITU Vienna", "4U1V", new List<string>(){ "CQ", "WAE" }));
            Regions.Add(new region("AI", 248, "African Italy", "IG9", new List<string>() { "WAE" }));
            Regions.Add(new region("SY", 248, "Sicily", "IT9", new List<string>() { "CQ", "WAE" }));
            Regions.Add(new region("BI", 259, "Bear Island", "JW/B", new List<string>() { "CQ", "WAE" }));
            Regions.Add(new region("SI", 279, "Shetland Islands", "GM/S", new List<string>() { "CQ", "WAE" }));
            Regions.Add(new region("KO", 296, "Kosovo", "Z6", new List<string>() { "CQ", "WAE" }));
            Regions.Add(new region("ET", 390, "European Turkey", "TA1", new List<string>() { "CQ" }));


            return Regions;

        }

        private static List<award> getAwards()
        {
            List<award> awardEnumeration = new List<award>();
            awardEnumeration.Add(new award("AJA"));
            awardEnumeration.Add(new award("CQDX"));
            awardEnumeration.Add(new award("CQDXFIELD"));
            awardEnumeration.Add(new award("CQWAZ_MIXED"));
            awardEnumeration.Add(new award("CQWAZ_CW"));
            awardEnumeration.Add(new award("CQWAZ_PHONE"));
            awardEnumeration.Add(new award("CQWAZ_RTTY"));
            awardEnumeration.Add(new award("CQWAZ_160m"));
            awardEnumeration.Add(new award("CQWPX"));
            awardEnumeration.Add(new award("DARC_DOK"));
            awardEnumeration.Add(new award("DXCC"));
            awardEnumeration.Add(new award("DXCC_MIXED"));
            awardEnumeration.Add(new award("DXCC_CW"));
            awardEnumeration.Add(new award("DXCC_PHONE"));
            awardEnumeration.Add(new award("DXCC_RTTY"));
            awardEnumeration.Add(new award("IOTA"));
            awardEnumeration.Add(new award("JCC"));
            awardEnumeration.Add(new award("JCG"));
            awardEnumeration.Add(new award("MARATHON"));
            awardEnumeration.Add(new award("RDA"));
            awardEnumeration.Add(new award("WAB"));
            awardEnumeration.Add(new award("WAC"));
            awardEnumeration.Add(new award("WAE"));
            awardEnumeration.Add(new award("WAIP"));
            awardEnumeration.Add(new award("WAJA"));
            awardEnumeration.Add(new award("WAS"));
            awardEnumeration.Add(new award("WAZ"));
            awardEnumeration.Add(new award("USACA"));
            awardEnumeration.Add(new award("VUCC"));
            return awardEnumeration;
        }


    }
}

