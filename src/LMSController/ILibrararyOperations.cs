using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface ILibrararyOperations
    {
        void AddBook(CBookInformation bookInformation);
        void EditBook(CBookInformation bookInformation);
        void DeleteBook(CBookInformation bookInformation);
    }
}
