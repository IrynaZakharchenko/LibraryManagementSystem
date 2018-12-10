using System.Collections.Generic;

namespace LMSController
{
   public interface ILibraryCardRegister
   {
      ICollection<LibraryCard> GetLibraryCardsByTicketNum(int ticketNumber);
      LibraryCard GetLibraryCardByInventoryCode(int inventoryCode);
   }
}
