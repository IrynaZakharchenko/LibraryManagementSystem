using System.Collections.Generic;

namespace LMSController
{
   public interface ILibraryCardRegister
   {
      ICollection<LibraryCard> GetLibraryCardsByTicketNum(int clientTicketNum);
      LibraryCard GetLibraryCardByInventoryCode(int inventoryCode);
      LibraryCard GetLibraryCardByBookTitle(string title);
   }
}
