using System;
namespace ADIFConverter.Model
{
    public class sponsoredAward
    {
        public sponsoredAward(string Sponsor, String SponsoringOrganisation)
        {
            _sponsor = Sponsor;
            _SponsoringOrganization = SponsoringOrganisation;
        }

        public string _sponsor { get; set; }
        public string _SponsoringOrganization { get; set; }
    }
}

