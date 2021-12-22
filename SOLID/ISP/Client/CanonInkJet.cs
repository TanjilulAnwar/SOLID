using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Client
{
    class CanonInkJet : IPrintTasks, IPrintDuplexContent
    {

        public bool PhotocopyContent(string content)
        {
            Console.WriteLine("Photocopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("PrintDuplex Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
