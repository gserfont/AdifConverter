using System;
namespace ADIFConverter.Model
{
    public class continent
    {
        public continent(string Abbreviation, string Continent)
        {
            _abbreviation = Abbreviation;
            _continent = Continent;
        }
        public string _abbreviation { get; set; }
        public string _continent { get; set; }    }
}

