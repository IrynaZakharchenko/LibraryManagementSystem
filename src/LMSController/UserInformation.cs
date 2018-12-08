namespace LMSController
{
   public class UserInformation
   {
      internal int UserId { get; set; }
      
      public UserCredential Credential { get; set; }
      public string Position { get; set; }
      public PersonalInformation PersonalInformation { get; set; }

      public UserInformation() { }
      public UserInformation(string name, string password, 
      string position, PersonalInformation personalInformation)
      {
         Credential = new UserCredential { Name = name, Password = password };
         Position = position;
         PersonalInformation = personalInformation;
      }
   }
}
