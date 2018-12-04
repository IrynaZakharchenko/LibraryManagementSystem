using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface ILibraryOperations
    {
        void AddBook(BookInformation bookInformation);
        void EditBook(BookInformation bookInformation);
        void DeleteBook(BookInformation bookInformation);
    }
}
