using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   public interface IBibliographyCardRegister
   {
      BookInformation[] FindBooksByClient(ClientInformation clientInformation);
      DateTime FindGetBookDateByTicketNumber(int ticketNumber);
      DateTime FindGiveBookDateByTicketNumber(int ticketNumber);
   }
}
