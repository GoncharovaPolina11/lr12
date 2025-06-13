// Data/BookStoreContext.cs
using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Data
{
    // Наследуемся от DbContext - основного класса для работы с EF Core
    public class BookStoreContext : DbContext
    {
        // Конструктор, принимающий параметры конфигурации
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        // DbSet представляет коллекцию сущностей в контексте
        public DbSet<Book> Books { get; set; }

        // Можно переопределить метод для дополнительной настройки модели
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(b => b.Price)
                .HasPrecision(18, 2); // 18 цифр всего, 2 после запятой
        }

    }
}