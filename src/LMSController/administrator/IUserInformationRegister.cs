namespace LMSController
{
   public interface IUserInformationRegister
   {
      string[] GetPossiblePositions();

      UserInformation FindByName(string userName);

      void Add(UserInformation userInformation);
      void Edit(UserInformation userInformation);
      void Delete(UserInformation userInformation);
   }
}
