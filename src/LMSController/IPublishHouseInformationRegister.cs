using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface IPublishHouseInformationRegister
    {
        event OperationEventHandler OnOperationExecute;

        PublishHouseInformation FindPublishHouseByName(string name);
        void AddPublishHouse(PublishHouseInformation publishHouse);
        void DeletePublishHouse(PublishHouseInformation publishHouse);
        void EditPublishHouse(PublishHouseInformation publishHouse);
    }
}
