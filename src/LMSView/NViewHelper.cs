using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSView
{
    namespace NViewHelper
    { 
        public enum FormViewMode
        {
            Edit,
            Create
        }

        public enum AccountMode
        {
            Admin,
            Library,
            Stockman
        }

        public static class ViewHelper
        {
            static public string MarkFieldAsImportant(string field)
            {
                return Properties.Resources.importantFieldMark + field;
            }
        }

    }

}
