using System;
namespace ADIFConverter.Model
{
    public class QSOComplete
    {
        public QSOComplete(string Abbreviation, string Meaning)
        {
            _abbreviation = Abbreviation;
            _meaning = Meaning;
        }
        public string _abbreviation { get; set; }
        public string _meaning { get; set; }
    }
}

