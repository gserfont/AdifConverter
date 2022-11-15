using System;
namespace ADIFConverter.Model
{
    public class HeaderFields
    {
        public string ADIF_VER { get; set; }
        public string CREATED_TIMESTAMP { get; set; }
        public string PROGRAMID { get; set; }
        public string PROGRAMVERSION { get; set; }
        public string APP_LASTQSL { get; set; }
        public object APP_NUMREC { get; set; }
    }
}

