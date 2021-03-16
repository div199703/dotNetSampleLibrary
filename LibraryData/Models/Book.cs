using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Book : Asset
    {
        public string Author { get; set; }
        public int ISBN { get; set; }
    }
}
