// Yazarlar Listesi (Authors)
using LinqJoinPractical.Models;


List<Author> authors = new List<Author>
{
    new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" }
        };

// Kitaplar Listesi (Books)
List<Book> books = new List<Book>
{
            new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
            new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
            new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
            new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
        };

// LINQ JOIN İşlemi

var bookWithAuthor = from book in books
                     join author in authors
                     on book.AuthorId equals author.AuthorId
                     select new
                     {
                         book.Title,
                         author.Name
                     };


Console.WriteLine("Kitap ve Yazarları: ");

foreach (var item in bookWithAuthor)
{
    Console.WriteLine($"Kitap: {item.Title} - Yazar: {item.Name}");
}



