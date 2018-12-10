namespace LMSController
{
   public interface IBookFinding
   {
      BookInformation FindByInventoryCode(int inventoryCode);
      BookInformation FindByTitle(string title);
      BookInformation FindByISBN(int isbn);
      BookInformation[] FindByLanguage(string language);
      BookInformation[] FindByBookSeries(string bookSeries);
   }
}
