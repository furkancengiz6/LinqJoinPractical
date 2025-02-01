# C# LINQ Join ile Kütüphane Yönetim Sistemi

Bu proje, C# kullanarak LINQ `join` işlemi ile **Yazarlar (Authors)** ve **Kitaplar (Books)** tablolarını ilişkilendirir ve her kitabın başlığını ilgili yazarın adıyla birlikte ekrana yazdırır.

## 🚀 Proje Açıklaması

Proje, **Yazarlar** ve **Kitaplar** olmak üzere iki temel sınıf içerir. LINQ `join` işlemi ile kitapların yazarlarıyla eşleştirilmesi sağlanır. `GetBooksWithAuthors()` metodu bu işlemi gerçekleştirerek çıktı üretir.

## 📌 Kullanılan Teknolojiler

- **C#**
- **.NET**
- **LINQ**

## 📂 Proje Yapısı

```
📦 LinqJoinLibrary
┣ 📜 Program.cs
┣ 📜 Author.cs
┣ 📜 Book.cs
┣ 📜 README.md
```

## 📖 Kod Açıklamaları

### 1️⃣ **Yazar ve Kitap Listelerini Tanımlama**

```csharp
static List<Author> GetAuthors()
{
    return new List<Author>
    {
        new Author { AuthorId = 1, Name = "Orhan Pamuk" },
        new Author { AuthorId = 2, Name = "Elif Şafak" },
        new Author { AuthorId = 3, Name = "Ahmet Ümit" }
    };
}
```

Bu metot, yazar listesini oluşturarak döndürmektedir.

### 2️⃣ **LINQ ************`Join`************ İşlemini Metot Olarak Tanımlama**

```csharp
static IEnumerable<(string BookTitle, string AuthorName)> GetBooksWithAuthors(List<Book> books, List<Author> authors)
{
    return from book in books
           join author in authors
           on book.AuthorId equals author.AuthorId
           select (book.Title, author.Name);
}
```

Bu metot, kitapları yazarlarıyla ilişkilendirerek bir liste döndürmektedir.

### 3️⃣ **Çıktı Üretme**

```csharp
Console.WriteLine("Kitaplar ve Yazarları:");
foreach (var item in bookWithAuthors)
{
    Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
}
```

Bu kod, eşleşmiş verileri ekrana yazdırmaktadır.

## 🎯 Örnek Çıktı

```
Kitaplar ve Yazarları:
Kitap: Kar, Yazar: Orhan Pamuk
Kitap: İstanbul, Yazar: Orhan Pamuk
Kitap: 10 Minutes 38 Seconds in This Strange World, Yazar: Elif Şafak
Kitap: Beyoğlu Rapsodisi, Yazar: Ahmet Ümit
```

## 📌 Nasıl Çalıştırılır?

1. **Proje klasörünü açın**
2. **Terminal veya Komut Satırında** şu komutu çalıştırın:
   ```sh
   dotnet run
   ```
3. **Çıktıyı gözlemleyin.**

## 📜 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.

