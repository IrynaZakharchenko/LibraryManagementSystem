using LMSModel;
using System;
using System.Collections.Generic;

namespace LMSController
{
   internal class LibraryCardRegister : ILibraryCardRegister
   {
      public ICollection<LibraryCard> GetLibraryCardsByTicketNum(int ticketNumber) => Convert(Bibliographies.FindByTicketNumber(ticketNumber));
      public LibraryCard GetLibraryCardByInventoryCode(int inventoryCode) => Convert(Bibliographies.FindByInventoryCode(inventoryCode));

      private static LibraryCard Convert(Bibliography bibliography)
      {
         if (bibliography == null)
         {
            throw new ArgumentNullException(nameof(bibliography));
         }

         return new LibraryCard()
         {
            DateRentBook = bibliography.give_date,
            DateReturnBook = bibliography.get_date,
            CodeRentedBook = bibliography.id_book_instance,
            Client = ClientInformation.Convert(bibliography.Reader)
         };
      }

      private static ICollection<LibraryCard> Convert(ICollection<Bibliography> bibliographies)
      {
         if (bibliographies == null)
         {
            return null;
         }

         List<LibraryCard> libraryCards = new List<LibraryCard>();
         foreach (var bibliography in bibliographies)
         {
            libraryCards.Add(Convert(bibliography));
         }

         return libraryCards;
      }
   }
}
