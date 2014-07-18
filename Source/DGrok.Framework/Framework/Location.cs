// DGrok Delphi parser
// Copyright (C) 2007 Joe White
// http://www.excastle.com/dgrok
//
// Licensed under the Open Software License version 3.0
// http://www.opensource.org/licenses/osl-3.0.php
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DGrok.Framework
{
    public class Location
    {
        private string _fileName;
        private int _offset;

        public Location(string fileName, int offset)
        {
            _fileName = fileName;
            _offset = offset;
        }

        public string Directory
        {
            get
            {
                if (String.IsNullOrEmpty(_fileName))
                    return "";
                return Path.GetDirectoryName(_fileName);
            }
        }
        public string FileName
        {
            get { return _fileName; }
        }
        public int Offset
        {
            get { return _offset; }
        }
    }
}