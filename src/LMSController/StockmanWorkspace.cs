using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class StockmanWorkspace : IWorkspaceStockman
    {
        public IBookFinding GetBookFinding()
        {
            throw new NotImplementedException();
        }

        public ILibraryOperations LibraryOperations()
        {
            throw new NotImplementedException();
        }
    }
}
