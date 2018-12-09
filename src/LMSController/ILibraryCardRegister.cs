using System.Collections.Generic;

namespace LMSController
{
   public interface ILibraryCardRegister
   {
      ICollection<LibraryCard> GetLibrarCardsByTicketNum(int clientTicketNum);
      LibraryCard GetLibrarCardByInventoryCode(int inventoryCode);

   }
}
