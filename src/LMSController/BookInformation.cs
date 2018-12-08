using System;

namespace LMSController
{
   public class BookInformation
   {
      public int[] InventoryCode { get; set; }
      public string Title { get; set; }
      public string FullTitle { get; set; }
      public int ISBN { get; set; }
      public AuthorInformation[] Authors { get; set; }
      public string Annotation { get; set; }
      public PublishHouseInformation PublishHouse { get; set; }
      public DateTime PublishDate { get; set; }
      public string Language { get; set; }
      public string BookSeries { get; set; }
      public SubjectInformation Subject { get; set; }

      public BookInformation() { }
      public BookInformation(int[] inventoryCode, string title, string fullTitle, int isbn,
             AuthorInformation[] authors, string annotation, PublishHouseInformation publishHouse,
             DateTime publishDate, string language, string bookSeries, SubjectInformation subject)
      {
         InventoryCode = inventoryCode;
         Title = title;
         FullTitle = fullTitle;
         ISBN = isbn;
         Authors = authors;
         Annotation = annotation;
         PublishHouse = publishHouse;
         PublishDate = publishDate;
         Language = language;
         BookSeries = bookSeries;
         Subject = subject;
      }
   }
}
