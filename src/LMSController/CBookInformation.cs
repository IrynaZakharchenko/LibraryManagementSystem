using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class CBookInformation
    {
        public int InventoryCode { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public int Isbn { get; set; }
        public string Anotation { get; set; }
        public CPublishHouseInformation PublishHouse { get; set; }
        public DateTime PublishDate { get; set; }
        public string Language { get; set; }
        public string BookSeries { get; set; }
        public CSubjectInformation Subject { get; set; }
    }
}
