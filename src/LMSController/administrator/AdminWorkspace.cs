namespace LMSController
{
   internal class AdminWorkspace : IWorkspaceAdmin
   {
      private static readonly UserInformationRegister userInformationRegister = new UserInformationRegister();
      public IUserInformationRegister UserInformationRegister => userInformationRegister;
   }
}
