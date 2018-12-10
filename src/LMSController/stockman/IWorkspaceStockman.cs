namespace LMSController
{
   public interface IWorkspaceStockman
   {
      IBookFinding BookFinding { get; }
      ILibraryOperations LibraryOperations { get; }
   }
}
