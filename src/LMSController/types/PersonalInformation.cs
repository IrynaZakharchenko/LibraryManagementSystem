using LMSModel;
using System;

namespace LMSController
{
   public class PersonalInformation
   {
      public string FullName { get; set; }
      public DateTime Birthday { get; set; }
      public decimal Phone { get; set; }
      public string Address { get; set; }

      internal static PersonalInformation Convert(Person person)
      {
         if (person == null)
         {
            throw new ArgumentNullException(nameof(person));
         }

         return new PersonalInformation()
         {
            FullName = person.full_name,
            Birthday = person.birthday,
            Phone = person.phone,
            Address = person.address
         };
      }

      internal static Person Convert(PersonalInformation personalInformation)
      {
         return new Person
         {
            address = personalInformation.Address,
            birthday = personalInformation.Birthday,
            phone = personalInformation.Phone,
            full_name = personalInformation.FullName
         };
      }
   }
}
