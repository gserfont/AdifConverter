using System;
namespace ADIFConverter.Model
{
    public class band
    {
        public band(string Band, double LowerFreq, double UpperFreq)
        {
            _lowerFreq = LowerFreq;
            _upperFreq = UpperFreq;
        }
        public string _band { get; set; }
        public double _lowerFreq { get; set; }
        public double _upperFreq { get; set; }
    }
}

