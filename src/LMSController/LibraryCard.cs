using System;

namespace LMSController
{
   public class LibraryCard
   {
      public ClientInformation Client { get; set; }
      public BookInformation RentedBook { get; set; }
      public DateTime DateRentBook { get; set; }
      public DateTime DateReturnBook { get; set; }
   }
}
