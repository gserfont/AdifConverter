﻿using System;
namespace ADIFConverter.Model
{
    public class QSO
    {
        public QSO(string Date, string CALL, string OPERATOR, double Frequency )
        {

        }
        public string? ADDRESS { get; set; }
        public string? ADDRESS_INTL { get; set; }
        public int AGE { get; set; }
        public int A_INDEX { get; set; }
        public int ANT_AZ { get; set; }
        public int ANT_EL { get; set; }
        public antPath? ANT_PATH { get; set; }
        public arrl_SECT? ARRL_SECT { get; set; }
        public List<string>? AWARD_SUBMITTED { get; set; }
        public List<string>? GRANTED { get; set; }
        public band? BAND { get; set; }
        public band? BAND_RX { get; set; }
        public string? CALL { get; set; }
        public string? CLASS { get; set; }
        public DateTime? CLUBLOG_QSO_UPLOAD_DATE { get; set; }
        public QSOUploadStatus? CLUBLOG_QSO_UPLOAD_STATUS { get; set; }
        public string? CNTY { get; set; }
        public string?  COMMENT { get; set; }
        public string? COMMENT_INTL { get; set; }
        public continent? CONT { get; set; }
        public string? CONTACTED_OP { get; set; }
        public string? CONTEST_ID { get; set; }
        public dxccEntity? COUNTRY { get; set; }
        public string? COUNTRY_INTL { get; set; }
        public int? CQZ { get; set; }
        public List<credit>? CREDIT_SUBMITTED { get; set; }
        public List<credit>? CREDIT_GRANTED { get; set; }
        public string? DARC_DOK { get; set; }
        public int DISTANCE { get; set; }
        public dxccEntity DXCC { get; set; }
        public string? EMail { get; set; }
        public string? EQ_CALL { get; set; }
        public DateTime EQSL_QSLRDATE { get; set; }
        public DateTime EQSL_QSLSDATE { get; set; }
        public QSLRcvd EQSL_QSL_RCVD { get; set; }
        public QSLSent EQSL_QSL_SENT { get; set; }
        public int? FISTS { get; set; }
        public int? FISTS_CCS { get; set; }
        public Boolean? FORCE_INIT { get; set; }
        public double FREQ { get; set; }
        public double FREQ_RX { get; set; }
        public string GRIDSQUARE { get; set; }
        public string GUEST_OP { get; set; }
        public DateTime HRDLOG_QSO_UPLOAD_DATE { get; set; }
        public QSOUploadStatus HRDLOG_QSO_UPLOAD_STATUS { get; set; }
        public string IOTA { get; set; }
        public int IOTA_ISLAND_ID { get; set; }
        public int ITUZ { get; set; }
        public int K_INDEX { get; set; }
        public double LAT { get; set; }
        public double LON { get; set; }
        public DateTime LOTW_QSLRDATE { get; set; }
        public DateTime LOTW_QSLSDATE { get; set; }
        public QSLRcvd LOTW_QSL_RCVD { get; set; }
        public QSLSent LOTW_QSL_SENT { get; set; }
        public int MAX_BURSTS { get; set; }
        public mode MODE { get; set; }
        public string MS_SHOWER { get; set; }
        public string MY_ANTENNA { get; set; }
        public string MY_ANTENNA_INTL { get; set; }
        public arrl_SECT MY_ARRL_SECT { get; set; }
        public string MY_CITY { get; set; }
        public string MY_CITY_INTL { get; set; }
        public string MY_CNTY { get; set; }
        public string MY_COUNTRY { get; set; }
        public string MY_COUNTRY_INTL { get; set; }
        public int MY_CQ_ZONE { get; set; }
        public dxccEntity MY_DXCC { get; set; }
        public int MY_FISTS { get; set; }
        public string MY_GRIDSQUARE { get; set; }
        public string MY_IOTA { get; set; }
        public int MY_IOTA_ISLAND_ID { get; set; }
        public int MY_ITU_ZONE { get; set; }
        public double MY_LAT { get; set; }
        public double MY_LON { get; set; }
        public string MY_NAME { get; set; }
        public string MY_NAME_INTL { get; set; }
        public string MY_POSTAL_CODE { get; set; }
        public string MY_POSTAL_CODE_INTL { get; set; }
        public string MY_RIG { get; set; }
        public string MY_RIG_INTL { get; set; }
        public string MY_SIG { get; set; }
        public string MY_SIG_INTL { get; set; }
        public string MY_SIG_INFO { get; set; }
        public string MY_SIG_INFO_INTL { get; set; }
        public string MY_SOTA_REF { get; set; }
        public string MY_STATE { get; set; }
        public string MY_STREET { get; set; }
        public string MY_STREET_INTL { get; set; }
        public string MY_USACA_COUNTIES { get; set; }
        public List<string> MY_VUCC_GRIDS { get; set; }
        public string MY_WWFF_REF { get; set; }
        public string NAME { get; set; }
        public string NAME_INTL { get; set; }
        public string NOTES { get; set; }
        public string NOTES_INTL { get; set; }
        public int NR_BURSTS { get; set; }
        public int NR_PINGS { get; set; }
        public string OPERATOR { get; set; }
        public string OWNER_CALLSIGN { get; set; }
        public string PFX { get; set; }
        public string PRECEDENCE { get; set; }
        public propogationMode PROP_MODE { get; set; }
        public string PUBLIC_KEY { get; set; }
        public DateTime QRZCOM_QSO_UPLOAD_DATE { get; set; }
        public QSOUploadStatus QRZCOM_QSO_UPLOAD_STATUS { get; set; }
        public string QSLMSG { get; set; }
        public string QSLMSG_INTL { get; set; }
        public DateTime QSLRDATE { get; set; }
        public DateTime QSLSDATE { get; set; }
        public QSLRcvd QSL_RCVD { get; set; }
        public QSLVia QSL_RCVD_VIA { get; set; }
        public QSLSent QSL_SENT { get; set; }
        public QSLVia QSL_SENT_VIA { get; set; }
        public string QSL_VIA { get; set; }
        public QSOComplete QSO_COMPLETE { get; set; }
        public DateTime QSO_DATE { get; set; }
        public DateTime QSO_DATE_OFF { get; set; }
        public Boolean QSO_RANDOM { get; set; }
        public string QTH { get; set; }
        public string QTH_INTL { get; set; }
        public region REGION { get; set; }
        public string RIG { get; set; }
        public string RIG_INTL{ get; set; }
        public string RST_RCVD { get; set; }
        public string RST_SENT { get; set; }
        public int RX_PWR { get; set; }
        public string SAT_MODE { get; set; }
        public string SAT_NAME { get; set; }
        public int SFI { get; set; }
        public string SIG { get; set; }
        public string SIG_INTL { get; set; }
        public string SIG_INFO { get; set; }
        public string SIG_INFO_INTL { get; set; }
        public Boolean SILENT_KEY { get; set; }
        public string SKCC { get; set; }
        public string SOTA_REF { get; set; }
        public int SRX { get; set; }
        public string SRX_STRING { get; set; }
        public string STATE { get; set; }
        public string STATION_CALLSIGN { get; set; }
        public int STX { get; set; }
        public string STX_STRING { get; set; }
        public subMode SUBMODE { get; set; }
        public Boolean SWL { get; set; }
        public int TEN_TEN { get; set; }
        public TimeOnly TIME_OFF { get; set; }
        public TimeOnly TIME_ON { get; set; }
        public int TX_PWR { get; set; }
        public int UKSMG { get; set; }
        public string USACA_COUNTIES { get; set; }
        public string VE_PROV { get; set; }
        public string VUCC_GRIDS { get; set; }
        public string WEB { get; set; }
        public string WWFF_REF { get; set; }

    }
}

