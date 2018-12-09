namespace LMSController
{
   public interface ILibraryOperations
   {
      void AddBook(BookInformation bookInformation);
      void EditBook(BookInformation bookInformation);
      void DeleteBook(BookInformation bookInformation);
   }
}
