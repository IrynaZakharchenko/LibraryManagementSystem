namespace LMSController
{
   public interface IWorkspaceLibrarian
   {
      IBookFinding BookFinding { get; }
      IClientInformationRegister ClientInformationRegister { get; }
   }
}
