using LibraryData.Models;

namespace LibraryService.Models
{
    public class CreateBookRequest
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public int LocationId { get; set; }
    }

    public class CreateBookResponse
    {
        public bool IsSuccess { get; set; }
    }
}
