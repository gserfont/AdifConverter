using System;
namespace ADIFConverter.Model
{
    public class QSLMedium
    {
        public QSLMedium(string Medium, string Description)
        {
            _medium = Medium;
            _description = Description;
        }

        public string  _medium { get; set; }
        public string _description { get; set; }
    }
}

