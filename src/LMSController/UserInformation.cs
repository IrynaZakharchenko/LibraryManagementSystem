using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class UserInformation
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
