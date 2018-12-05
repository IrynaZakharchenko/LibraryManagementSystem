using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class SubjectInformation
    {
        public string Name { get; set; }
        public SubjectInformation SubjectParent { get; set; }

        public SubjectInformation() { }
        public SubjectInformation(string subjectName, SubjectInformation parent)
        {
            Name = subjectName;
            SubjectParent = parent;
        }
    }
}
