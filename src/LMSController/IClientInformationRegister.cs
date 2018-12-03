using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface IClientInformationRegister
    {
        ClientInformation FindClientByLibraryTicket(int numberLibraryTicket);
        ClientInformation FindClientByName(string name);
        void AddClient(ClientInformation clientInformation);
        void EditClient(ClientInformation clientInformation);
        void DeleteClient(ClientInformation clientInformation);

        void RentBook(ClientInformation client, BookInformation book);
        void ReturnBook(ClientInformation client, BookInformation book);
    }
}
