using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class PersonalInformation
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public PersonalInformation() { }
        public PersonalInformation(string name, DateTime birth, string phone, string address)
        {
            FullName = name;
            Birthday = birth;
            Phone = phone;
            Address = address;
        }
    }
}
