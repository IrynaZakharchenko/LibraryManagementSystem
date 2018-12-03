using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    class UserInformationRegister : IUserInformationRegister
    {
        private List<UserInformation> localUsersList = new List<UserInformation>();

        private void InitializationTest()
        {
            UserInformation user = new UserInformation("izaharchenko", "123456", "admin", new PersonalInformation("Irina Zaharchenko",
                new DateTime(1996, 10, 16), "3465768", "Odessa, st. House"));
            UserInformation user1 = new UserInformation("hzinovatna", "123456", "librarian", new PersonalInformation("Hanna Zinovatna",
                new DateTime(1996, 11, 26), "346345768", "Odessa, Mr. House"));
            UserInformation user2 = new UserInformation("hpotter", "123456", "stockman", new PersonalInformation("Harry Potter",
                new DateTime(1980, 1, 22), "346345768", "4, Private Drive"));

            localUsersList.Add(user);
            localUsersList.Add(user1);
            localUsersList.Add(user2);
        }

        public UserInformationRegister() 
        {
            InitializationTest();
        }

        public void AddUser(UserInformation userInformation)
        {
            localUsersList.Add(userInformation);
        }

        public void DeleteUser(UserInformation userInformation)
        {
            localUsersList.Remove(userInformation);
        }

        public void EditUser(UserInformation userInformation)
        {
            localUsersList.Add(userInformation);
        }
        
        public UserInformation FindUser(string searhString)
        {
            UserInformation result = localUsersList.Find(user => user.PersonalInformation.FullName.Contains(searhString));
            if (result == null)
            {
                result = localUsersList.Find(user => user.Login.Equals(searhString));
                if (result == null)
                {
                    throw new InvalidOperationException();
                }
            }
            return result;
        }
    }
}
