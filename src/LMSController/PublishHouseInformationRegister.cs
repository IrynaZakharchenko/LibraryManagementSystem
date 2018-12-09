using LMSModel;

namespace LMSController
{
   public delegate void OperationEventHandler(bool result);

   public class PublishHouseInformationRegister : IPublishHouseInformationRegister
   {
      public event OperationEventHandler OnOperationExecute;

      public void Add(PublishHouseInformation publishHouse)
      {
         if (publishHouse == null)
         {
            throw new System.ArgumentNullException(nameof(publishHouse));
         }

         try
         {
            PublishingHouses.Add(new PublishingHouse()
            {
               category = publishHouse.Category,
               location = publishHouse.Location,
               name = publishHouse.Name
            });
            PublishingHouses.Save();

            OnOperationExecute(true);
         }
         catch
         {
            OnOperationExecute(false);
         }
      }

      public void Delete(PublishHouseInformation publishHouse)
      {
         if (publishHouse == null)
         {
            throw new System.ArgumentNullException(nameof(publishHouse));
         }

         try
         {
            PublishingHouses.Delete(new PublishingHouse()
            {
               category = publishHouse.Category,
               location = publishHouse.Location,
               name = publishHouse.Name
            });

            OnOperationExecute(true);
         }
         catch
         {
            OnOperationExecute(false);
         }
      }

      public PublishHouseInformation FindByName(string name)
      {
         if (name == null)
         {
            throw new System.ArgumentNullException(nameof(name));
         }

         PublishHouseInformation publishHouseInformation = null;
         PublishingHouse publishingHouse = PublishingHouses.FindByName(name);
         if (publishingHouse != null)
         {
            publishHouseInformation = new PublishHouseInformation()
            {
               Category = publishingHouse.category,
               Location = publishingHouse.location,
               Name = publishingHouse.name
            };
         }

         return publishHouseInformation;
      }
   }
}
