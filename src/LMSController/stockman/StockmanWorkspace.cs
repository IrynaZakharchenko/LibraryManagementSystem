namespace LMSController
{
   internal class StockmanWorkspace : IWorkspaceStockman
   {
      private static readonly BookFinding bookFinding = new BookFinding();
      private static readonly LibraryOperations libraryOperations = new LibraryOperations();
      private static readonly SubjectInformationFinding subjectInformationFinding = new SubjectInformationFinding();
      private static readonly PublishHouseInformationRegister publishHouseInformationRegister = new PublishHouseInformationRegister();

      public IBookFinding BookFinding => bookFinding;
      public ILibraryOperations LibraryOperations => libraryOperations;
      public ISubjectInformationFinding SubjectInformationFinding => subjectInformationFinding;
      public IPublishHouseInformationRegister PublishHouseInformationRegister => publishHouseInformationRegister;
   }
}
