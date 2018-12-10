namespace LMSController
{
   public interface IWorkspaceLibrarian
   {
      IBookFinding BookFinding { get; }
      IClientInformationRegister ClientInformationRegister { get; }
      ILibraryCardRegister LibraryCardRegister { get; }
   }
}
