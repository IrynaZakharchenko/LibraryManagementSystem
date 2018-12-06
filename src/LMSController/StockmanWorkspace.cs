using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class StockmanWorkspace : IWorkspaceStockman
    {
        private List<BookInformation> bookStorage;
        private BookFinding bookFinder;
        private LibraryOperations libraryOperations;

      public StockmanWorkspace()
        {
            bookStorage = new List<BookInformation>() { new BookInformation(1234, "Harry Potter",
            "Harry Potter and chamber os secret", 786, new AuthorInformation[] { new AuthorInformation("J.K. Rowling") },
            "Harry Potter is about to start his second year at Hogwarts.",
            new PublishHouseInformation("Bloomsbury", "USA", "fantasy"), new DateTime(1991, 02, 1),
            "english", "Harry Potter", new SubjectInformation("magic", new SubjectInformation("fairy tails", null))) };
            bookFinder = new BookFinding(ref bookStorage);
            libraryOperations = new LibraryOperations(ref bookStorage);
        }

        public IBookFinding GetBookFinding()
        {
            return bookFinder;
        }

        public ILibraryOperations GetLibraryOperations()
        {
            return libraryOperations;
        }
    }
}
