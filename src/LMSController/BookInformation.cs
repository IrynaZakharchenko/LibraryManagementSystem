using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class BookInformation
    {
        public int InventoryCode { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public int Isbn { get; set; }
        public AuthorInformation[] Authors { get; set; }
        public string Annotation { get; set; }
        public PublishHouseInformation PublishHouse { get; set; }
        public DateTime PublishDate { get; set; }
        public string Language { get; set; }
        public string BookSeries { get; set; }
        public SubjectInformation Subject { get; set; }
    }
}
