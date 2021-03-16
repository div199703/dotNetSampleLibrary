using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryService.Models
{
    public class CreateBranchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CreateBranchResponse
    {
        public bool IsSuccess { get; set; }
    }
}
