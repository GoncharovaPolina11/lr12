// Data/DbInitializer.cs
using BookStoreApi.Models;

namespace BookStoreApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BookStoreContext context)
        {
            // Проверяем, есть ли уже книги в базе
            if (context.Books.Any())
            {
                return; // База уже инициализирована
            }

            // Создаем начальные данные
            var books = new Book[]
            {
                new Book { Title = "Война и мир", Author = "Лев Толстой", Description = "Роман-эпопея", Year = 1869, Price = 15.99m },
                new Book { Title = "Преступление и наказание", Author = "Фёдор Достоевский", Description = "Психологический роман", Year = 1866, Price = 12.50m },
                new Book { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Description = "Фантастический роман", Year = 1967, Price = 10.99m }
            };

            // Добавляем книги в контекст
            context.Books.AddRange(books);
            
            // Сохраняем изменения в базе
            context.SaveChanges();
        }
    }
}