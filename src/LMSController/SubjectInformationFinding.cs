using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class SubjectInformationFinding : ISubjectInformationFinding
    {
        private List<SubjectInformation> subjectStorage = new List<SubjectInformation>() { new SubjectInformation("Potions", null) };

        public SubjectInformation FindByName(string name)
        {
            return subjectStorage.Find(subject => subject.Name == name);
        }
    }
}
