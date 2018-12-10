using System;
using System.Collections.Generic;

namespace LMSController
{
   public class BookInformation
   {
      public IDictionary<int, bool> InventoryCode { get; set; }
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
   }
}
