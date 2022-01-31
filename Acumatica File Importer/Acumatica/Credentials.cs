using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumatica_File_Importer.Acumatica
{
   public class AcConfiguration
    {
        public string baseURL { get; set; }
        public string user { get; set; }
        public string pwd { get; set; }
        public string company { get; set; }
        public string branch { get; set; }
    }
}
