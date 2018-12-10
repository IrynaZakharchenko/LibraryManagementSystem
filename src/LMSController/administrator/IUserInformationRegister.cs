namespace LMSController
{
   public interface IUserInformationRegister
   {
      UserInformation FindUser(string userName);
      string[] PossiblePositions();
      void AddUser(UserInformation userInformation);
      void EditUser(UserInformation userInformation);
      void DeleteUser(UserInformation userInformation);
   }
}
