using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public delegate void OperationEventHandler(bool result);

    public class PublishHouseInformationRegister : IPublishHouseInformationRegister
    {
        private List<PublishHouseInformation> publishHousesList = new List<PublishHouseInformation>()
        { new PublishHouseInformation("Piter", "St. Peterburg", "Science") };

        public event OperationEventHandler OnOperationExecute;

        public void AddPublishHouse(PublishHouseInformation publishHouse)
        {
            publishHousesList.Add(publishHouse);
            OnOperationExecute(true);
        }

        public void DeletePublishHouse(PublishHouseInformation publishHouse)
        {
            publishHousesList.Remove(publishHouse);
            OnOperationExecute(true);
        }

        public void EditPublishHouse(PublishHouseInformation publishHouse)
        {
            publishHousesList.Add(publishHouse);
            OnOperationExecute(true);
        }

        public PublishHouseInformation FindPublishHouseByName(string name)
        {
            return publishHousesList.Find(publishHouse => publishHouse.Name == name);
        }
    }
}
