using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!; // Добавляем = null!

        public string? Author { get; set; } // Делаем nullable

        public string? Description { get; set; } // Делаем nullable

        public int Year { get; set; }

        public decimal Price { get; set; }
    }
}