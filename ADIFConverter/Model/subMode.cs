using System;
namespace ADIFConverter.Model
{
    public class subMode
    {
        public subMode(string Name, mode Mode, string Description)
        {
            _Name = Name;
            _Mode = Mode;
            _Description = Description;
        }
        public subMode(string Name, mode Mode)
        {
            _Name = Name;
            _Mode = Mode;
        }

        public string _Name { get; set; }
        public mode _Mode { get; set; }
        public string _Description { get; set; }
    }
}

