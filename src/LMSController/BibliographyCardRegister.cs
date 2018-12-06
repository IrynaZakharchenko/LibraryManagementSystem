using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   public class BibliographyCardRegister : IBibliographyCardRegister
   {
      public BookInformation[] FindBooksByClient(ClientInformation clientInformation)
      {
         throw new NotImplementedException();
      }

      public DateTime FindGetBookDateByTicketNumber(int ticketNumber)
      {
         throw new NotImplementedException();
      }

      public DateTime FindGiveBookDateByTicketNumber(int ticketNumber)
      {
         throw new NotImplementedException();
      }
   }
}
