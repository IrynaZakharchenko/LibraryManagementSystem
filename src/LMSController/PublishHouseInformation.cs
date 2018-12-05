using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class PublishHouseInformation
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }

        public PublishHouseInformation() { }
        public PublishHouseInformation(string name, string location, string category)
        {
            Name = name;
            Location = location;
            Category = category;
        }
    }
}
