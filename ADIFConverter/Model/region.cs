using System;
namespace ADIFConverter.Model
{
    public class region
    {
        public region(string RegionEntityCode, int dxccCode, string Region, string Prefix, List<string> Applicability)
        {
            _RegionEntityCode = RegionEntityCode;
            _Region = Region;
            _prefix = Prefix;
            _Applicability = Applicability;
            _dxccEntity = ADIFEnumerations.getDxccEntity(dxccCode);
            
            
        }

        public string _RegionEntityCode { get; set; }
        public dxccEntity _dxccEntity { get; set; }
        public string _Region { get; set; }
        public string _prefix { get; set; }
        public List<string> _Applicability { get; set; }

    }
}

