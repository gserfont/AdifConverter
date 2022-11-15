using System;
namespace ADIFConverter.Model
{
    public class dxccEntity
    {
        public dxccEntity(int EntityCode)
        {
            _EntityCode = EntityCode;
        }

        public dxccEntity()
        {
          
        }
        public dxccEntity(int EntityCode, string EntityName, bool Deleted)
        {
            _EntityCode = EntityCode;
            _EntityName = EntityName;
            _Deleted = Deleted;
        }

        public int _EntityCode { get; set; }
        public string? _EntityName { get; set; }
        public bool? _Deleted { get; set; }
    }
}

