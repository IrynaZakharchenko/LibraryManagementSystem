using System;

namespace LMSController
{
   public class LibrarianWorkspace : IWorkspaceLibrarian
   {
      private static readonly IBookFinding bookFinding = new BookFinding();

      public IBookFinding BookFinding => bookFinding;
      public IClientInformationRegister ClientInformationRegister => throw new NotImplementedException();
   }
}
