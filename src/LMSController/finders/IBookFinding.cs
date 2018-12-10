namespace LMSController
{
    public interface IBookFinding
    {
        BookInformation FindBookByInventoryCode(int inventoryCode);
        BookInformation FindBookByTitle(string title);
        BookInformation FindBookByISBN(int isbn);
        BookInformation[] FindBookByLanguage(string language);
        BookInformation[] FindBookByBookSeries(string bookSeries);
    }
}
