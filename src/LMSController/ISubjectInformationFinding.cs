﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface ISubjectInformationFinding
    {
        SubjectInformation FindByName(string name);
    }
}