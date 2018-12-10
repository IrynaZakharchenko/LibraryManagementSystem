using LMSModel;
using System;

namespace LMSController
{
   public class ClientInformation
   {
      public int LibraryTicketNumberCode { get; set; }
      public PersonalInformation PersonalInformation { get; set; }

      internal static ClientInformation Convert(Reader reader)
      {
         ClientInformation clientInformation = null;
         if (reader != null)
         {
            clientInformation = new ClientInformation()
            {
               LibraryTicketNumberCode = reader.id_reader_ticket,
               PersonalInformation = PersonalInformation.Convert(reader.Person)
            };
         }

         return clientInformation;
      }

      internal static Reader Convert(ClientInformation clientInformation)
      {
         if (clientInformation == null)
         {
            throw new ArgumentNullException(nameof(clientInformation));
         }

         return new Reader()
         {
            id_reader_ticket = clientInformation.LibraryTicketNumberCode,
            Person = PersonalInformation.Convert(clientInformation.PersonalInformation)
         };
      }
   }
}
