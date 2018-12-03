using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class CSubjectInformation
    {
        public string Name { get; set; }
        public CSubjectInformation SubjectParent { get; set; }
    }
}
