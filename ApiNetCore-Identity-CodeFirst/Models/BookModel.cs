using System.ComponentModel.DataAnnotations;

namespace ApiNetCore_Identity_CodeFirst.Models
{
    // validate, che giấu bớt dữ liệu nếu có
    public class BookModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [Range(0, 100)]
        public int Quantity { get; set; }

    }
}
