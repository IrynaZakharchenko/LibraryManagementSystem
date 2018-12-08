using System;
using System.Collections.Generic;

namespace LMSController
{
   internal class StockmanWorkspace : IWorkspaceStockman
   {
      private static List<BookInformation> bookStorage;
      private static readonly IBookFinding bookFinding = new BookFinding(ref bookStorage);
      private static readonly ILibraryOperations libraryOperations = new LibraryOperations(ref bookStorage);

      public StockmanWorkspace()
        {
            bookStorage = new List<BookInformation>() { new BookInformation(new int[]{12343, 67655, 78889 }, "Harry Potter",
            "Harry Potter and chamber os secret", 786, new AuthorInformation[] { new AuthorInformation("J.K. Rowling") },
            "Harry Potter is about to start his second year at Hogwarts.",
            new PublishHouseInformation("Bloomsbury", "USA", "fantasy"), new DateTime(1991, 02, 1),
            "english", "Harry Potter", new SubjectInformation("magic", new SubjectInformation("fairy tails", null))) };
        }

      public IBookFinding BookFinding => bookFinding;
      public ILibraryOperations LibraryOperations => libraryOperations;
   }
}
