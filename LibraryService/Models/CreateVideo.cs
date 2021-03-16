using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryService.Models
{
    public class CreateVideoRequest
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int LocationId { get; set; }
    }
    public class CreateVideoResponse
    {
        public bool IsSuccess { get; set; }
    }
}