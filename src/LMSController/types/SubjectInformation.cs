namespace LMSController
{
   public class SubjectInformation
   {
      public string Name { get; set; }
      public SubjectInformation SubjectParent { get; set; }
   }
}
