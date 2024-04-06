using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CookiesCookbook.Program;

namespace CookiesCookbook
{
    internal class FileMetaData
    {
        public string Name { get; set; }
        public FileFormat FileFormat { get; set; }

        public FileMetaData(string name, FileFormat fileFormat)
        {
            Name = name;
            FileFormat = fileFormat;
        }

        public string ToPath() => $"{Name}.{FileFormat.AsFileExtension()}";
    }
}
