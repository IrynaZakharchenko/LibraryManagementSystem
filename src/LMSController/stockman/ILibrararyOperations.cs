namespace LMSController
{
   public interface ILibraryOperations
   {
      void AddBook(BookInformation bookInformation);
      void EditBook(BookInformation bookInformation);
      void DeleteBookByISBN(int isbn);
      void DeleteBookByInventoryCode(int inventoryCode);
   }
}
