using System;
namespace ADIFConverter.Model
{
    public class QSLVia
    {
        public QSLVia(string Via, String Description)
        {
            _Via = Via;
            _Description = Description;
        }

        public string _Via { get; set; }
        public string _Description { get; set; }
    }
}

