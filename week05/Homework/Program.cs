using System;

class Program
{
    static void Main(string[] args)
    {
        
        Book book1 = new Book();

        book1.SetAuthor("Adson");
        book1.SetTitle("Lord of The Ring");

        
        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();

        book2.SetAuthor("Beatriz");
        book2.SetIllustrator("Adson");
        book2.SetTitle("Comic Sofia's stories");

        Console.WriteLine(book2.GetBookInfo());
    }
}