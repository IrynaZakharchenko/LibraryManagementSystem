using LMSModel;

namespace LMSController
{
   internal class BookFinding : IBookFinding
   {
      public BookInformation FindByInventoryCode(int inventoryCode) => Convert(Books.FindByInventoryCode(inventoryCode));
      public BookInformation FindByTitle(string title) => Convert(Books.FindByTitle(title));
      public BookInformation FindByISBN(int isbn) => Convert(Books.FindByISBN(isbn));
      public BookInformation[] FindByLanguage(string language) => Convert(Books.FindByLanguage(language));
      public BookInformation[] FindByBookSeries(string bookSeries) => Convert(Books.FindByBookSeries(bookSeries));

      private static BookInformation[] Convert(Book[] books)
      {
         if (books == null)
         {
            return null;
         }

         BookInformation[] bookInformations = new BookInformation[books.Length];
         for (int i = 0; i < books.Length; ++i)
         {
            bookInformations[i] = Convert(books[i]);
         }

         return bookInformations;
      }

      private static BookInformation Convert(Book book)
      {
         BookInformation bookInformation = null;

         if (book != null)
         {
            bookInformation = new BookInformation()
            {
               BookSeries = book.book_series,
               Annotation = book.annotation,
               FullTitle = book.full_title,
               ISBN = book.id_book_isbn,
               Language = book.language,
               PublishDate = book.date_publish,
               PublishHouse = new PublishHouseInformation()
               {
                  Category = book.PublishingHouse.category,
                  Location = book.PublishingHouse.location,
                  Name = book.PublishingHouse.name
               },
               Subject = new SubjectInformation()
               {
                  Name = book.Subject.name,
               },
               Title = book.title,
               InventoryCode = Books.FindInventoryCodesByISBN(book.id_book_isbn),
               Authors = Convert(Books.FindAutorsByISBN(book.id_book_isbn))
            };
         }
         return bookInformation;
      }

      private static AuthorInformation[] Convert(string[] names)
      {
         AuthorInformation[] authorInformations = new AuthorInformation[names.Length];
         for (int i = 0; i < authorInformations.Length; ++i)
         {
            authorInformations[i] = new AuthorInformation() { Name = names[i] };
         }
         return authorInformations;
      }
   }
}
