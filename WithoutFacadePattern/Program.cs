using System;
using WithoutFacadePattern.API;

namespace WithoutFacadePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var authorService = new AuthorService();
            var publisherService = new PublisherService();
            var titleService = new TitleService();
            var isbn = "123456789";

            var author = authorService.LookUpAuthor(isbn);
            var publisher = publisherService.LookUpPublisher(isbn);
            var title = titleService.LookUpTitle(isbn);

            Console.WriteLine($"Information for the book with the isbn  {isbn}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"The author is: {author}");
            Console.WriteLine($"The title is: {title}");
            Console.WriteLine($"The publisher is {publisher}");

            Console.ReadKey();
        }
    }
}