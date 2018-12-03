using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface IClientInformationRegister
    {
        CClientInformation FindClientByLibraryTicket(int NumLibraryTicket);
        CClientInformation FindClientByName(string Name);
        void AddClient(CClientInformation clientInformation);
        void EditClient(CClientInformation clientInformation);
        void DeleteClient(CClientInformation clientInformation);

        void RentBook(CClientInformation client, CBookInformation book);
        void ReturnBook(CClientInformation client, CBookInformation book);
    }
}
