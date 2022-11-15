using System;
namespace ADIFConverter.Model
{
    public class antPath
    {
        public string _Abbreviation { get; set; }
        public string _Meaning { get; set; }

        public antPath (string Abbreviation, string Meaning)
        {
            _Abbreviation = Abbreviation;
            _Meaning = Meaning;
        }
    }
}

