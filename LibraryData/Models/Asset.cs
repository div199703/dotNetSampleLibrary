using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int LocationId { get; set; }
    }
}
