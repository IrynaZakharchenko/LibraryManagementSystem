namespace LMSController
{
   internal class AdminWorkspace : IWorkspaceAdmin
   {
      private static readonly IUserInformationRegister userInformationRegister = new UserInformationRegister();
      public IUserInformationRegister UserInformationRegister => userInformationRegister;
   }
}
