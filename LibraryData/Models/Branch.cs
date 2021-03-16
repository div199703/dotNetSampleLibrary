using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IEnumerable<Asset> AssetList { get; set; }
    }
}
