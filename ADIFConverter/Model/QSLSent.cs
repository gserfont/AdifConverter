﻿using System;
namespace ADIFConverter.Model
{
    public class QSLSent
    {
        public QSLSent(string Status, String Meaning, String Description)
        {
            _status = Status;
            _meaning = Meaning;
            _description = Description;
        }

        public string _status { get; set; }
        public string _meaning { get; set; }
        public string _description { get; set; }

    }
}

