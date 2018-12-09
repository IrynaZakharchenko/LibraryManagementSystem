namespace LMSController
{
   internal class StockmanWorkspace : IWorkspaceStockman
   {
      private static readonly IBookFinding bookFinding = new BookFinding();
      private static readonly ILibraryOperations libraryOperations = new LibraryOperations();

      public IBookFinding BookFinding => bookFinding;
      public ILibraryOperations LibraryOperations => libraryOperations;
   }
}
