using System;
namespace ADIFConverter.Model
{
    public class mode
    {
        public mode(string Name,List<subMode> SubModes, string Description)
        {
            _Name = Name;
            _Submodes = SubModes;
            _Description = Description;
        }

        public mode(string Name, List<subMode> SubModes)
        {
            _Name = Name;
            _Submodes = SubModes;
        }
        public mode(string Name,string Description)
        {
            _Name = Name;
            _Description = Description;
        }
        public mode(string Name)
        {
            _Name = Name;
        }
        public mode(string Name, string Description,bool Import_only)
        {
            _Name = Name;
            _Description = Description;
            _import_only = Import_only;

        }
        public mode(string Name,bool Import_only)
        {
            _Name = Name;
            _import_only = Import_only;

        }

        public string _Name { get; set; }
        public List<subMode>? _Submodes { get; set; }
        public string?  _Description { get; set; }
        public bool? _import_only { get; set; }
    }
}

