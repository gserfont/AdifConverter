using System;
namespace ADIFConverter.Model
{
    public class credit
    {
        public credit(string CreditFor, string Sponsor, string Award, string Facet)
        {
            _CreditFor = CreditFor;
            _Sponsor = Sponsor;
            _Award = Award;
            _Facet = Facet;

        }
        public string _CreditFor { get; set; }
        public string _Sponsor { get; set; }
        public string _Award { get; set; }
        public string _Facet { get; set; }
    }
}

