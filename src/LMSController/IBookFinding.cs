using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface IBookFinding
    {
        BookInformation FindBookByInventoryCode(int inventoryCode);
    }
}
