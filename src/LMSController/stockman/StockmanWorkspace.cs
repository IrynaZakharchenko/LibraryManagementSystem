namespace LMSController
{
   internal class StockmanWorkspace : IWorkspaceStockman
   {
      private static readonly BookFinding bookFinding = new BookFinding();
      private static readonly LibraryOperations libraryOperations = new LibraryOperations();

      public IBookFinding BookFinding => bookFinding;
      public ILibraryOperations LibraryOperations => libraryOperations;
   }
}
