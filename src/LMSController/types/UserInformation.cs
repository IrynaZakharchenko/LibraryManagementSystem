namespace LMSController
{
   public class UserInformation
   {
      internal int UserId { get; set; }
      
      public UserCredential Credential { get; set; }
      public string Position { get; set; }
      public PersonalInformation PersonalInformation { get; set; }
   }
}
