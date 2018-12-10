namespace LMSController
{
   public interface IClientInformationRegister
   {
      ClientInformation FindByLibraryTicket(int ticketNumber);
      ClientInformation FindByName(string name);

      void Add(ClientInformation client);
      void Edit(ClientInformation client);
      void Delete(ClientInformation client);

      void RentBook(ClientInformation client, BookInformation book);
      void ReturnBook(ClientInformation client, BookInformation book);
   }
}
