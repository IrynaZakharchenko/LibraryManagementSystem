namespace LMSController
{
   public class AuthorInformation
   {
      public string Name { get; set; }

      public AuthorInformation() { }
      public AuthorInformation(string name)
      {
         Name = name;
      }
   }
}
