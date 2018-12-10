using LMSModel;
using System;

namespace LMSController
{
   internal class ClientInformationRegister : IClientInformationRegister
   {
      public ClientInformation FindByLibraryTicket(int ticketNumber) => ClientInformation.Convert(Readers.FindByLibraryTicket(ticketNumber));
      public ClientInformation FindByName(string name) => ClientInformation.Convert(Readers.FindByName(name));

      public void Add(ClientInformation client)
      {
         Readers.Add(ClientInformation.Convert(client));
         Readers.Save();
      }

      public void Edit(ClientInformation client)
      {
         Readers.Edit(ClientInformation.Convert(client));
         Readers.Save();
      }

      public void Delete(ClientInformation client)
      {
         if (client == null)
         {
            throw new ArgumentNullException(nameof(client));
         }

         Readers.Delete(client.LibraryTicketNumberCode);
         Readers.Save();
      }
      
      public void RentBook(ClientInformation client, BookInformation book)
      {
         Readers.RentBook(ClientInformation.Convert(client), 0);
         Readers.Save();
      }

      public void ReturnBook(ClientInformation client, BookInformation book)
      {
         Readers.ReturnBook(0);
         Readers.Save();
      }
   }
}
