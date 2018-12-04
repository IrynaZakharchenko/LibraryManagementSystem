namespace LMSModel
{
   public static class DBInstance
   {
      static internal LMSDBDataContext DataContext = new LMSDBDataContext();
      
      public static void SubmitChanges()
      {
         DataContext.SubmitChanges();
      }
   }
}
