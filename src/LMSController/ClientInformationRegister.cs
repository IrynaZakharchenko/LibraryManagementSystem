using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   public class ClientInformationRegister : IClientInformationRegister
   {
      public void AddClient(ClientInformation clientInformation)
      {
         throw new NotImplementedException();
      }

      public void DeleteClient(ClientInformation clientInformation)
      {
         throw new NotImplementedException();
      }

      public void EditClient(ClientInformation clientInformation)
      {
         throw new NotImplementedException();
      }

      public ClientInformation FindClientByLibraryTicket(int numberLibraryTicket)
      {
         throw new NotImplementedException();
      }

      public ClientInformation FindClientByName(string name)
      {
         throw new NotImplementedException();
      }
     
      public void RentBook(ClientInformation client, BookInformation book)
      {
         throw new NotImplementedException();
      }

      public void ReturnBook(ClientInformation client, BookInformation book)
      {
         throw new NotImplementedException();
      }
   }
}
