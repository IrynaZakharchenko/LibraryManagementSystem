using System;
using System.Collections.Generic;

namespace LMSController
{
   public class LibraryCardRegister : ILibraryCardRegister
   {
      public LibraryCard GetLibraryCardByBookTitle(string title)
      {
         throw new NotImplementedException();
      }

      public LibraryCard GetLibraryCardByInventoryCode(int inventoryCode)
      {
         throw new NotImplementedException();
      }

      public ICollection<LibraryCard> GetLibraryCardsByTicketNum(int clientTicketNum)
      {
         throw new NotImplementedException();
      }
   }
}
