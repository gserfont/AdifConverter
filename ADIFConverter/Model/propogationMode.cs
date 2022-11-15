using System;
namespace ADIFConverter.Model
{
    public class propogationMode
    {
        public propogationMode(string Name, String Description)
        {
            _Name = Name;
            _Description = Description;
        }

        public string _Name { get; set; }
        public string _Description { get; set; }
    }
}

