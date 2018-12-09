using System;
using System.Collections.Generic;

namespace LMSController
{
   internal class StockmanWorkspace : IWorkspaceStockman
   {
      private static List<BookInformation> bookStorage;
      private static IBookFinding bookFinding;
      private static readonly ILibraryOperations libraryOperations = new LibraryOperations(ref bookStorage);

      public StockmanWorkspace()
      {
         bookStorage = new List<BookInformation>() { new BookInformation(new Dictionary<int, bool> { { 12343, true }, { 67655, true }, { 78889, false } }, "Harry Potter",
            "Harry Potter and chamber os secret", 786, new AuthorInformation[] { new AuthorInformation("J.K. Rowling") },
            "Harry Potter is about to start his second year at Hogwarts.",
            new PublishHouseInformation("Bloomsbury", "USA", "fantasy"), new DateTime(1991, 02, 1),
            "english", "Harry Potter", new SubjectInformation("magic", new SubjectInformation("fairy tails", null))) };
         bookFinding = new BookFinding(ref bookStorage);
        }

      public IBookFinding BookFinding => bookFinding;
      public ILibraryOperations LibraryOperations => libraryOperations;
   }
}
