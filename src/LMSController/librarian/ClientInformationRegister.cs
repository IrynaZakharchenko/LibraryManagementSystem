using System;

namespace LMSController
{
   internal class ClientInformationRegister : IClientInformationRegister
   {
      public void Add(ClientInformation client)
      {
         throw new NotImplementedException();
      }

      public void Delete(ClientInformation client)
      {
         throw new NotImplementedException();
      }

      public void Edit(ClientInformation client)
      {
         throw new NotImplementedException();
      }

      public ClientInformation FindByLibraryTicket(int ticketNumber)
      {
         throw new NotImplementedException();
      }

      public ClientInformation FindByName(string name)
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
