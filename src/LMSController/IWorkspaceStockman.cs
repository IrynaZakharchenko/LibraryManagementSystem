using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface IWorkspaceStockman
    {
        IBookFinding GetBookFinding();
        ILibrararyOperations GetLibrararyOperations();
    }
}
