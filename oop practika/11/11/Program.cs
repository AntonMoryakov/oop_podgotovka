using _11;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        // Создаем и заполняем базу данных
        using (var db = new LibraryContext())
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var author1 = new Author { Name = "Leo Tolstoy" };
            var author2 = new Author { Name = "Fyodor Dostoevsky" };

            db.Authors.AddRange(author1, author2);

            var book1 = new Book { Title = "War and Peace", Author = author1 };
            var book2 = new Book { Title = "Anna Karenina", Author = author1 };
            var book3 = new Book { Title = "Crime and Punishment", Author = author2 };
            var book4 = new Book { Title = "The Brothers Karamazov", Author = author2 };

            db.Books.AddRange(book1, book2, book3, book4);

            db.SaveChanges();
        }

        // Выводим список всех книг с указанием автора
        using (var db = new LibraryContext())
        {
            var books = db.Books.Include(b => b.Author).ToList();
            foreach (var book in books)
            {
                string authorName = book.Author != null ? book.Author.Name : "Unknown";
                Console.WriteLine($"Title: {book.Title}, Author: {authorName}");
            }
        }
    }
}