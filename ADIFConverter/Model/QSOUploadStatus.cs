using System;
namespace ADIFConverter.Model
{
    public class QSOUploadStatus
    {
        public QSOUploadStatus(string Status, string Description)
        {
            _status = Status;
            _description = Description;
        }
        public string  _status { get; set; }
        public string  _description { get; set; }
    }
}

