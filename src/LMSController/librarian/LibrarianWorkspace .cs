namespace LMSController
{
   public class LibrarianWorkspace : IWorkspaceLibrarian
   {
      private static readonly BookFinding bookFinding = new BookFinding();
      private static readonly ClientInformationRegister clientInformationRegister = new ClientInformationRegister();
      private static readonly LibraryCardRegister libraryCardRegister = new LibraryCardRegister();

      public IBookFinding BookFinding => bookFinding;
      public IClientInformationRegister ClientInformationRegister => clientInformationRegister;
      public ILibraryCardRegister LibraryCardRegister => libraryCardRegister;
   }
}
