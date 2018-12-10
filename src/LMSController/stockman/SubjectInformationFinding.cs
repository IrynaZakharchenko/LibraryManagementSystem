using System.Collections.Generic;

namespace LMSController
{
   public class SubjectInformationFinding : ISubjectInformationFinding
   {
      private List<SubjectInformation> subjectStorage = new List<SubjectInformation>() { new SubjectInformation() { Name = "Potions", SubjectParent = null } };

      public SubjectInformation FindByName(string name)
      {
         return subjectStorage.Find(subject => subject.Name == name);
      }
   }
}
