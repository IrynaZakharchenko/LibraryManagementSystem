using System;

namespace LMSController
{
   public class LibraryCard
   {
      public ClientInformation Client { get; set; }
      public int CodeRentedBook { get; set; }
      public BookInformation BookInformation { get; set; }
      public DateTime DateRentBook { get; set; }
      public DateTime? DateReturnBook { get; set; }
   }
}
