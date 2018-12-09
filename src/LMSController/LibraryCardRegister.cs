using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   public class LibraryCardRegister : ILibraryCardRegister
   {
      public LibraryCard GetLibrarCardByInventoryCode(int inventoryCode)
      {
         throw new NotImplementedException();
      }

      public ICollection<LibraryCard> GetLibrarCardsByTicketNum(int clientTicketNum)
      {
         throw new NotImplementedException();
      }
   }
}
