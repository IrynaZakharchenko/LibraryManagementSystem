namespace LMSController
{
   public interface IPublishHouseInformationRegister
   {
      event OperationEventHandler OnOperationExecute;

      PublishHouseInformation FindByName(string name);

      void Add(PublishHouseInformation publishHouse);
      void Delete(PublishHouseInformation publishHouse);
   }
}
